﻿using Client.Forms.Exceptions;
using Common.Communication;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms.ServerCommunication
{
    public class Communication
    {
        private static Communication instance;
        private Socket socket;
        private CommunicationHelper helper;

        private Communication()
        {

        }

        public static Communication Instance
        {
            get
            {
                if (instance == null) instance = new Communication();
                return instance;
            }
        }

        internal void Connect()
        {
            if(socket == null || !socket.Connected)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9000);
                helper = new CommunicationHelper(socket);
            }
        }

        public Output SendRequestGetResult<Output>(Operation operacija, object objekat = null) where Output : class
        {
            SendRequest(operacija, objekat);
            return GetResult<Output>();
        }

        public void SendRequestNoResult(Operation operacija, object objekat = null)
        {
            SendRequest(operacija, objekat);
            GetResult();
        }


        private void SendRequest(Operation operacija, object objekat)
        {
            try
            {
                Request request = new Request
                {
                    Operation = operacija,
                    RequestObject = objekat
                };
                helper.Send(request);

            }
            catch (IOException ex)
            {
                throw new ServerCommunicationException(ex.Message);
            }
        }
        private T GetResult<T>() where T : class
        {
            Response response = helper.Receive<Response>();
            if(response.Uspesno)
            {
                return (T)response.ResponseObject;
            }
            else
            {
                throw new SystemOperationException(response.Poruka);
            }
        }

        internal void Close()
        {
            if (socket == null) return;
            Request request = new Request
            {
                Operation = Operation.End
            };
            helper.Send(request);
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            socket = null;
        }

        private void GetResult()
        {
            Response response = helper.Receive<Response>();
            if (!response.Uspesno)
            {
                throw new SystemOperationException(response.Poruka);
            }
        }
    }

}
