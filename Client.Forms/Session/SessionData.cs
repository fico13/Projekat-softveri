using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Forms.Session
{
    public class SessionData
    {
        private static SessionData instance;
        private static object lockObject = new object();
        private SessionData()
        {

        }

        public static SessionData Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(lockObject)
                    {
                        if (instance == null) instance = new SessionData();
                    }
                }
                return instance;
            }
        }

        public Administrator Administrator { get; set; }
    }
}
