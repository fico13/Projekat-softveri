
CREATE TABLE [dbo].[Administrator](
	[AdministratorId] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](50) NOT NULL,
	[Prezime] [varchar](50) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Administrator] PRIMARY KEY CLUSTERED 
(
	[AdministratorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dvorana]    Script Date: 30-Aug-23 20:13:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dvorana](
	[DvoranaId] [int] IDENTITY(1,1) NOT NULL,
	[ImeDvorane] [varchar](50) NOT NULL,
	[DrzavaDvorane] [varchar](50) NOT NULL,
	[Kapacitet] [int] NOT NULL,
 CONSTRAINT [PK_Dvorana] PRIMARY KEY CLUSTERED 
(
	[DvoranaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Igrac]    Script Date: 30-Aug-23 20:13:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Igrac](
	[IgracId] [int] IDENTITY(1,1) NOT NULL,
	[ImeIgraca] [varchar](50) NOT NULL,
	[PrezimeIgraca] [varchar](50) NOT NULL,
	[DrzavaIgraca] [varchar](50) NOT NULL,
	[Pozicija] [int] NOT NULL,
	[BrojNaDresu] [int] NOT NULL,
	[Visina] [int] NOT NULL,
	[Tezina] [float] NOT NULL,
	[TimId] [int] NOT NULL,
 CONSTRAINT [PK_Igrac] PRIMARY KEY CLUSTERED 
(
	[IgracId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Statistika]    Script Date: 30-Aug-23 20:13:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statistika](
	[UtakmicaId] [int] NOT NULL,
	[IgracId] [int] NOT NULL,
	[Poeni] [int] NOT NULL,
	[Skokovi] [int] NOT NULL,
	[Asistencije] [int] NOT NULL,
 CONSTRAINT [PK_Statistika] PRIMARY KEY CLUSTERED 
(
	[UtakmicaId] ASC,
	[IgracId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = ON, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tim]    Script Date: 30-Aug-23 20:13:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tim](
	[TimId] [int] IDENTITY(1,1) NOT NULL,
	[ImeTima] [varchar](50) NOT NULL,
	[DrzavaTima] [varchar](50) NOT NULL,
	[BrojPobeda] [int] NOT NULL,
	[BrojPoraza] [int] NOT NULL,
	[Bodovi] [int] NOT NULL,
	[DvoranaId] [int] NOT NULL,
 CONSTRAINT [PK_Tim] PRIMARY KEY CLUSTERED 
(
	[TimId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utakmica]    Script Date: 30-Aug-23 20:13:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utakmica](
	[UtakmicaId] [int] IDENTITY(1,1) NOT NULL,
	[BrojPoenaDomacin] [int] NOT NULL,
	[BrojPoenaGost] [int] NOT NULL,
	[DatumOdigravanja] [datetime] NOT NULL,
	[DomacinId] [int] NOT NULL,
	[GostId] [int] NOT NULL,
 CONSTRAINT [PK_Utakmica] PRIMARY KEY CLUSTERED 
(
	[UtakmicaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Administrator] ON 

INSERT [dbo].[Administrator] ([AdministratorId], [Ime], [Prezime], [Username], [Password]) VALUES (1, N'Filip', N'Jovanovic', N'fico', N'fico')
INSERT [dbo].[Administrator] ([AdministratorId], [Ime], [Prezime], [Username], [Password]) VALUES (2, N'Aleksandar', N'Jolic', N'jola', N'jola')
SET IDENTITY_INSERT [dbo].[Administrator] OFF
GO
SET IDENTITY_INSERT [dbo].[Dvorana] ON 

INSERT [dbo].[Dvorana] ([DvoranaId], [ImeDvorane], [DrzavaDvorane], [Kapacitet]) VALUES (1, N'Mercedes-Benz Arena', N'Nemacka', 14500)
INSERT [dbo].[Dvorana] ([DvoranaId], [ImeDvorane], [DrzavaDvorane], [Kapacitet]) VALUES (2, N'Sinan Erdem', N'Turska', 16000)
INSERT [dbo].[Dvorana] ([DvoranaId], [ImeDvorane], [DrzavaDvorane], [Kapacitet]) VALUES (3, N'Gaston Medecin', N'Monako', 4700)
INSERT [dbo].[Dvorana] ([DvoranaId], [ImeDvorane], [DrzavaDvorane], [Kapacitet]) VALUES (4, N'Fernando Buesa', N'Spanija', 15504)
INSERT [dbo].[Dvorana] ([DvoranaId], [ImeDvorane], [DrzavaDvorane], [Kapacitet]) VALUES (5, N'Aleksandar Nikolic', N'Srbija', 8000)
INSERT [dbo].[Dvorana] ([DvoranaId], [ImeDvorane], [DrzavaDvorane], [Kapacitet]) VALUES (6, N'Mediolanum', N'Italija', 12700)
INSERT [dbo].[Dvorana] ([DvoranaId], [ImeDvorane], [DrzavaDvorane], [Kapacitet]) VALUES (7, N'Palau Blaugrana', N'Spanija', 7585)
INSERT [dbo].[Dvorana] ([DvoranaId], [ImeDvorane], [DrzavaDvorane], [Kapacitet]) VALUES (8, N'BMW Park', N'Nemacka', 6700)
INSERT [dbo].[Dvorana] ([DvoranaId], [ImeDvorane], [DrzavaDvorane], [Kapacitet]) VALUES (9, N'Ulker Sports Arena', N'Turska', 13800)
INSERT [dbo].[Dvorana] ([DvoranaId], [ImeDvorane], [DrzavaDvorane], [Kapacitet]) VALUES (10, N'Astrobol', N'Francuska', 5556)
INSERT [dbo].[Dvorana] ([DvoranaId], [ImeDvorane], [DrzavaDvorane], [Kapacitet]) VALUES (11, N'Menora Mivtacim', N'Izrael', 10383)
INSERT [dbo].[Dvorana] ([DvoranaId], [ImeDvorane], [DrzavaDvorane], [Kapacitet]) VALUES (12, N'Dvorana mira i prijateljstva', N'Grcka', 12700)
INSERT [dbo].[Dvorana] ([DvoranaId], [ImeDvorane], [DrzavaDvorane], [Kapacitet]) VALUES (13, N'OAKA', N'Grcka', 19250)
INSERT [dbo].[Dvorana] ([DvoranaId], [ImeDvorane], [DrzavaDvorane], [Kapacitet]) VALUES (14, N'Stark arena', N'Srbija', 22386)
INSERT [dbo].[Dvorana] ([DvoranaId], [ImeDvorane], [DrzavaDvorane], [Kapacitet]) VALUES (15, N'WiZink centar', N'Spanija', 17953)
INSERT [dbo].[Dvorana] ([DvoranaId], [ImeDvorane], [DrzavaDvorane], [Kapacitet]) VALUES (16, N'La Fonteta', N'Spanija', 9000)
INSERT [dbo].[Dvorana] ([DvoranaId], [ImeDvorane], [DrzavaDvorane], [Kapacitet]) VALUES (17, N'Segafredo Arena', N'Italija', 9980)
INSERT [dbo].[Dvorana] ([DvoranaId], [ImeDvorane], [DrzavaDvorane], [Kapacitet]) VALUES (18, N'Zalgiris Arena', N'Litvanija', 15415)
SET IDENTITY_INSERT [dbo].[Dvorana] OFF
GO
SET IDENTITY_INSERT [dbo].[Igrac] ON 

INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (1, N'Maodo', N'Lo', N'Nemacka', 1, 0, 191, 82, 1)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (2, N'Jaleen', N'Smith', N'SAD', 2, 3, 190, 93, 1)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (3, N'Louis', N'Olinde', N'Nemacka', 3, 19, 205, 88, 1)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (4, N'Luke', N'Sikma', N'SAD', 4, 43, 203, 107, 1)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (5, N'Christ', N'Koumadje', N'Cad', 5, 21, 223, 122, 1)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (6, N'Vasilije', N'Micic', N'Srbija', 1, 22, 196, 91, 2)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (7, N'Rodrigue', N'Beaubois', N'Francuska', 2, 1, 190, 83, 2)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (8, N'Elijah', N'Bryant', N'SAD', 3, 6, 196, 95, 2)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (11, N'Amath', N'Mbaye', N'Francuska', 4, 24, 206, 98, 2)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (12, N'Ante', N'Zizic', N'Hrvatska', 5, 41, 210, 115, 2)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (13, N'Mike', N'James', N'SAD', 1, 55, 185, 86, 3)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (14, N'Jordan', N'Loyd', N'SAD', 2, 3, 193, 95, 3)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (15, N'Jaron', N'Blossomgame', N'SAD', 3, 4, 203, 100, 3)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (16, N'John', N'Brown', N'SAD', 4, 0, 203, 93, 3)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (17, N'Donatas', N'Motiejunas', N'Litvanija', 5, 20, 213, 101, 3)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (18, N'Darius', N'Thompson', N'SAD', 1, 13, 193, 89, 4)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (19, N'Markus', N'Howard', N'SAD', 2, 0, 180, 82, 4)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (20, N'Rokas', N'Giedraitis', N'Litvanija', 3, 31, 201, 81, 4)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (21, N'Daulton', N'Hommes', N'SAD', 4, 34, 203, 98, 4)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (22, N'Maik', N'Kotsar', N'Estonija', 5, 21, 211, 122, 4)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (23, N'Facundo', N'Campazzo', N'Argentina', 1, 7, 180, 75, 5)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (24, N'Ognjen', N'Dobric', N'Srbija', 2, 13, 198, 98, 5)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (25, N'Stefan', N'Lazarevic', N'Srbija', 3, 2, 198, 82, 5)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (26, N'Benjamin', N'Bentil', N'Gana', 4, 50, 206, 107, 5)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (27, N'Luka', N'Mitrovic', N'Srbija', 5, 9, 206, 102, 5)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (28, N'Kevin', N'Pangos', N'Kanada', 1, 5, 188, 84, 6)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (29, N'Billy', N'Baron', N'SAD', 2, 12, 188, 88, 6)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (30, N'Shavon', N'Shields', N'SAD', 3, 31, 201, 102, 6)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (31, N'Nicolo', N'Melli', N'Italija', 4, 9, 206, 107, 6)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (32, N'Kyle', N'Hines', N'SAD', 5, 42, 198, 104, 6)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (33, N'Nicolas', N'Laprovitola', N'Argentina', 1, 20, 193, 80, 7)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (34, N'Cory', N'Higgins', N'SAD', 2, 22, 196, 82, 7)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (35, N'Nikola', N'Kalinic', N'Srbija', 3, 10, 203, 101, 7)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (36, N'Nikola', N'Mirotic', N'Spanija', 4, 33, 208, 113, 7)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (37, N'Jan', N'Vesely', N'Ceska', 5, 6, 211, 109, 7)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (38, N'Cassius', N'Winston', N'SAD', 1, 5, 185, 84, 8)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (39, N'Ognjen', N'Jaramaz', N'Srbija', 2, 10, 193, 82, 8)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (40, N'Vladimir', N'Lucic', N'Srbija', 3, 11, 203, 91, 8)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (41, N'Augustine', N'Rubit', N'SAD', 4, 21, 201, 100, 8)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (42, N'Othello', N'Hunter', N'SAD', 5, 8, 203, 102, 8)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (43, N'Nick', N'Calathes', N'Grcka', 1, 33, 198, 97, 9)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (44, N'Marko', N'Guduric', N'Srbija', 2, 23, 198, 91, 9)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (45, N'Nigel', N'Hayes-Davis', N'SAD', 3, 14, 203, 115, 9)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (46, N'Dyshawn', N'Pierre', N'Kanada', 4, 21, 198, 104, 9)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (47, N'Johnathan', N'Motley', N'SAD', 5, 0, 208, 104, 9)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (48, N'Nando', N'De Colo', N'Francuska', 1, 12, 196, 88, 10)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (49, N'Retin', N'Obasohan', N'Belgija', 2, 32, 191, 100, 10)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (50, N'David', N'Lighty', N'Francuska', 3, 23, 198, 98, 10)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (51, N'Amine', N'Noua', N'Francuska', 4, 2, 203, 89, 10)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (52, N'Youssoupha', N'Fall', N'Senegal', 5, 19, 221, 123, 10)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (53, N'Lorenzo', N'Brown', N'Spanija', 1, 4, 196, 86, 11)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (54, N'Wade', N'Baldwin', N'SAD', 2, 5, 193, 100, 11)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (55, N'Bonzie', N'Colson', N'SAD', 3, 50, 196, 102, 11)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (56, N'Jarell', N'Martin', N'SAD', 4, 6, 208, 108, 11)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (57, N'Josh', N'Nebo', N'SAD', 5, 32, 206, 111, 11)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (58, N'Thomas', N'Walkup', N'Grcka', 1, 0, 193, 88, 12)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (59, N'Isaiah', N'Canaan', N'SAD', 2, 3, 183, 91, 12)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (60, N'Kostas', N'Papanikolaou', N'Grcka', 3, 16, 203, 102, 12)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (61, N'Sasha', N'Vezenkov', N'Bugarska', 4, 14, 206, 102, 12)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (62, N'Moustapha', N'Fall', N'Francuska', 5, 10, 218, 107, 12)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (63, N'Paris', N'Lee', N'SAD', 1, 5, 183, 84, 13)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (64, N'Marius', N'Grigonis', N'Litvanija', 2, 40, 198, 88, 13)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (65, N'Dwayne', N'Bacon', N'SAD', 3, 24, 198, 100, 13)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (66, N'Derrick', N'Williams', N'SAD', 4, 8, 203, 109, 13)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (67, N'Georgios', N'Papagiannis', N'Grcka', 5, 6, 218, 125, 13)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (68, N'Dante', N'Exum', N'Australija', 1, 11, 196, 97, 14)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (69, N'Kevin', N'Punter', N'SAD', 2, 7, 193, 81, 14)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (70, N'James', N'Nunnally', N'SAD', 3, 21, 201, 100, 14)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (71, N'Zac', N'Leday', N'SAD', 4, 2, 201, 104, 14)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (72, N'Mathias', N'Lessort', N'Francuska', 5, 26, 206, 113, 14)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (73, N'Nigel', N'Williams-Goss', N'SAD', 1, 0, 191, 86, 15)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (74, N'Dzanan ', N'Musa', N'Bosna i Hercegovina', 2, 31, 206, 98, 15)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (75, N'Mario', N'Hezonja', N'Hrvatska', 3, 11, 203, 100, 15)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (76, N'Guerschon', N'Yabusele', N'Francuska', 4, 28, 203, 118, 15)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (77, N'Edy', N'Tavares', N'Zelenortska ostrva', 5, 22, 221, 120, 15)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (78, N'Jared', N'Harper', N'SAD', 1, 0, 183, 79, 16)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (79, N'Klemen', N'Prepelic', N'Slovenija', 2, 3, 191, 77, 16)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (80, N'Victor', N'Claver', N'Spanija', 3, 1, 208, 107, 16)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (81, N'James', N'Webb', N'SAD', 4, 5, 206, 92, 16)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (82, N'Bojan', N'Dubljevic', N'Crna Gora', 1, 14, 206, 110, 16)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (83, N'Milos', N'Teodosic', N'Srbija', 1, 44, 196, 89, 17)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (84, N'Iffe', N'Lundberg', N'Danska', 2, 19, 193, 92, 17)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (85, N'Semi', N'Ojeleye', N'SAD', 3, 37, 198, 109, 17)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (86, N'Tornike', N'Shengelia', N'Gruzija', 4, 21, 206, 100, 17)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (87, N'Mam', N'Jaiteh', N'Francuska', 5, 14, 211, 112, 17)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (88, N'Lukas', N'Lekavicius', N'Litvanija', 1, 4, 183, 76, 18)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (89, N'Ignas', N'Brazdeikis', N'Litvanija', 2, 17, 201, 100, 18)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (90, N'Edgaras', N'Ulanovas', N'Litvanija', 3, 92, 198, 87, 18)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (91, N'Rolands', N'Smits', N'Letonija', 4, 10, 208, 107, 18)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (92, N'Kevarrius', N'Hayes', N'SAD', 5, 8, 206, 103, 18)
INSERT [dbo].[Igrac] ([IgracId], [ImeIgraca], [PrezimeIgraca], [DrzavaIgraca], [Pozicija], [BrojNaDresu], [Visina], [Tezina], [TimId]) VALUES (1001, N'asda', N'asda', N'asdad', 1, 23, 150, 123, 1)
SET IDENTITY_INSERT [dbo].[Igrac] OFF
GO
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (1, 1, 11, 3, 6)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (1, 2, 9, 0, 2)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (1, 3, 11, 10, 4)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (1, 4, 15, 6, 7)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (1, 5, 8, 6, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (1, 68, 22, 3, 4)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (1, 69, 13, 6, 3)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (1, 70, 7, 2, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (1, 71, 13, 1, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (1, 72, 9, 6, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (2, 6, 16, 0, 6)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (2, 7, 10, 4, 2)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (2, 8, 4, 4, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (2, 11, 6, 4, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (2, 12, 6, 5, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (2, 23, 0, 0, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (2, 24, 0, 0, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (2, 25, 6, 3, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (2, 26, 13, 4, 2)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (2, 27, 3, 4, 5)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (3, 13, 26, 3, 6)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (3, 14, 0, 4, 5)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (3, 15, 4, 3, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (3, 16, 6, 6, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (3, 17, 8, 1, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (3, 83, 0, 0, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (3, 84, 14, 6, 2)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (3, 85, 11, 2, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (3, 86, 0, 0, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (3, 87, 9, 4, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (4, 18, 8, 5, 11)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (4, 19, 12, 1, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (4, 20, 19, 7, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (4, 21, 8, 2, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (4, 22, 21, 9, 4)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (4, 78, 10, 1, 2)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (4, 79, 12, 2, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (4, 80, 3, 4, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (4, 81, 3, 4, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (4, 82, 0, 5, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (5, 28, 3, 4, 2)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (5, 29, 18, 4, 5)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (5, 30, 0, 0, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (5, 31, 16, 4, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (5, 32, 8, 6, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (5, 48, 18, 5, 4)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (5, 49, 2, 1, 3)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (5, 50, 12, 2, 3)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (5, 51, 6, 8, 3)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (5, 52, 11, 4, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (6, 33, 16, 2, 3)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (6, 34, 10, 4, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (6, 35, 11, 1, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (6, 36, 0, 0, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (6, 37, 5, 6, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (6, 58, 5, 4, 4)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (6, 59, 9, 0, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (6, 60, 2, 3, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (6, 61, 20, 8, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (6, 62, 0, 0, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (8, 38, 6, 1, 2)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (8, 39, 2, 3, 2)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (8, 40, 2, 3, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (8, 41, 2, 2, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (8, 42, 18, 8, 3)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (8, 43, 12, 4, 5)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (8, 44, 6, 1, 5)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (8, 45, 11, 3, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (8, 46, 10, 3, 4)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (8, 47, 8, 7, 4)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (9, 53, 13, 2, 11)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (9, 54, 15, 2, 2)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (9, 55, 16, 6, 2)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (9, 56, 3, 4, 2)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (9, 57, 8, 3, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (9, 88, 10, 4, 2)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (9, 89, 8, 5, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (9, 90, 3, 2, 2)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (9, 91, 9, 9, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (9, 92, 16, 9, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (10, 63, 12, 3, 3)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (10, 64, 5, 0, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (10, 65, 0, 0, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (10, 66, 15, 4, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (10, 67, 6, 5, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (10, 73, 0, 0, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (10, 74, 13, 3, 3)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (10, 75, 8, 3, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (10, 76, 6, 5, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (10, 77, 14, 6, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (11, 18, 11, 4, 7)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (11, 19, 33, 0, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (11, 20, 13, 9, 3)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (11, 21, 5, 3, 2)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (11, 22, 4, 1, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (11, 68, 4, 3, 4)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (11, 69, 26, 5, 2)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (11, 70, 13, 0, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (11, 71, 23, 10, 2)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (11, 72, 19, 12, 2)
GO
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (12, 68, 3, 2, 2)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (12, 69, 10, 3, 3)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (12, 70, 20, 4, 4)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (12, 71, 4, 9, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (12, 72, 14, 7, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (12, 83, 0, 0, 4)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (12, 84, 4, 0, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (12, 85, 6, 3, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (12, 86, 0, 0, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (12, 87, 6, 3, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (1001, 28, 12, 1, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (1001, 29, 10, 1, 3)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (1001, 30, 25, 4, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (1001, 31, 7, 2, 0)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (1001, 32, 0, 1, 2)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (1001, 68, 7, 4, 1)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (1001, 69, 7, 5, 2)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (1001, 70, 2, 3, 2)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (1001, 71, 23, 5, 3)
INSERT [dbo].[Statistika] ([UtakmicaId], [IgracId], [Poeni], [Skokovi], [Asistencije]) VALUES (1001, 72, 12, 10, 0)
GO
SET IDENTITY_INSERT [dbo].[Tim] ON 

INSERT [dbo].[Tim] ([TimId], [ImeTima], [DrzavaTima], [BrojPobeda], [BrojPoraza], [Bodovi], [DvoranaId]) VALUES (1, N'Alba Berlin', N'Nemacka', 1, 0, 2, 1)
INSERT [dbo].[Tim] ([TimId], [ImeTima], [DrzavaTima], [BrojPobeda], [BrojPoraza], [Bodovi], [DvoranaId]) VALUES (2, N'Anadolu Efes', N'Turska', 1, 0, 2, 2)
INSERT [dbo].[Tim] ([TimId], [ImeTima], [DrzavaTima], [BrojPobeda], [BrojPoraza], [Bodovi], [DvoranaId]) VALUES (3, N'Monako', N'Monako', 1, 0, 2, 3)
INSERT [dbo].[Tim] ([TimId], [ImeTima], [DrzavaTima], [BrojPobeda], [BrojPoraza], [Bodovi], [DvoranaId]) VALUES (4, N'Baskonija', N'Spanija', 2, 0, 4, 4)
INSERT [dbo].[Tim] ([TimId], [ImeTima], [DrzavaTima], [BrojPobeda], [BrojPoraza], [Bodovi], [DvoranaId]) VALUES (5, N'Crvena zvezda', N'Srbija', 0, 1, 1, 5)
INSERT [dbo].[Tim] ([TimId], [ImeTima], [DrzavaTima], [BrojPobeda], [BrojPoraza], [Bodovi], [DvoranaId]) VALUES (6, N'Olimpija Milano', N'Italija', 2, 0, 4, 6)
INSERT [dbo].[Tim] ([TimId], [ImeTima], [DrzavaTima], [BrojPobeda], [BrojPoraza], [Bodovi], [DvoranaId]) VALUES (7, N'Barselona', N'Spanija', 0, 1, 1, 7)
INSERT [dbo].[Tim] ([TimId], [ImeTima], [DrzavaTima], [BrojPobeda], [BrojPoraza], [Bodovi], [DvoranaId]) VALUES (8, N'Bajern Minhen', N'Nemacka', 0, 1, 1, 8)
INSERT [dbo].[Tim] ([TimId], [ImeTima], [DrzavaTima], [BrojPobeda], [BrojPoraza], [Bodovi], [DvoranaId]) VALUES (9, N'Fenerbahce', N'Turska', 1, 0, 2, 9)
INSERT [dbo].[Tim] ([TimId], [ImeTima], [DrzavaTima], [BrojPobeda], [BrojPoraza], [Bodovi], [DvoranaId]) VALUES (10, N'Asvel', N'Francuska', 0, 1, 1, 10)
INSERT [dbo].[Tim] ([TimId], [ImeTima], [DrzavaTima], [BrojPobeda], [BrojPoraza], [Bodovi], [DvoranaId]) VALUES (11, N'Makabi Tel Aviv', N'Izrael', 1, 0, 2, 11)
INSERT [dbo].[Tim] ([TimId], [ImeTima], [DrzavaTima], [BrojPobeda], [BrojPoraza], [Bodovi], [DvoranaId]) VALUES (12, N'Olimpijakos', N'Grcka', 1, 0, 2, 12)
INSERT [dbo].[Tim] ([TimId], [ImeTima], [DrzavaTima], [BrojPobeda], [BrojPoraza], [Bodovi], [DvoranaId]) VALUES (13, N'Panatanaikos', N'Grcka', 0, 1, 1, 13)
INSERT [dbo].[Tim] ([TimId], [ImeTima], [DrzavaTima], [BrojPobeda], [BrojPoraza], [Bodovi], [DvoranaId]) VALUES (14, N'Partizan', N'Srbija', 1, 3, 5, 14)
INSERT [dbo].[Tim] ([TimId], [ImeTima], [DrzavaTima], [BrojPobeda], [BrojPoraza], [Bodovi], [DvoranaId]) VALUES (15, N'Real Madrid', N'Spanija', 1, 0, 2, 15)
INSERT [dbo].[Tim] ([TimId], [ImeTima], [DrzavaTima], [BrojPobeda], [BrojPoraza], [Bodovi], [DvoranaId]) VALUES (16, N'Valensija', N'Spanija', 0, 1, 1, 16)
INSERT [dbo].[Tim] ([TimId], [ImeTima], [DrzavaTima], [BrojPobeda], [BrojPoraza], [Bodovi], [DvoranaId]) VALUES (17, N'Virtus Bolonja', N'Italija', 0, 2, 2, 17)
INSERT [dbo].[Tim] ([TimId], [ImeTima], [DrzavaTima], [BrojPobeda], [BrojPoraza], [Bodovi], [DvoranaId]) VALUES (18, N'Zalgiris', N'Litvanija', 0, 1, 1, 18)
SET IDENTITY_INSERT [dbo].[Tim] OFF
GO
SET IDENTITY_INSERT [dbo].[Utakmica] ON 

INSERT [dbo].[Utakmica] ([UtakmicaId], [BrojPoenaDomacin], [BrojPoenaGost], [DatumOdigravanja], [DomacinId], [GostId]) VALUES (1, 100, 84, CAST(N'2022-10-07T20:00:06.000' AS DateTime), 1, 14)
INSERT [dbo].[Utakmica] ([UtakmicaId], [BrojPoenaDomacin], [BrojPoenaGost], [DatumOdigravanja], [DomacinId], [GostId]) VALUES (2, 72, 59, CAST(N'2022-10-07T19:30:18.000' AS DateTime), 2, 5)
INSERT [dbo].[Utakmica] ([UtakmicaId], [BrojPoenaDomacin], [BrojPoenaGost], [DatumOdigravanja], [DomacinId], [GostId]) VALUES (3, 66, 83, CAST(N'2022-10-07T20:30:25.000' AS DateTime), 17, 3)
INSERT [dbo].[Utakmica] ([UtakmicaId], [BrojPoenaDomacin], [BrojPoenaGost], [DatumOdigravanja], [DomacinId], [GostId]) VALUES (4, 71, 81, CAST(N'2022-10-06T20:30:21.000' AS DateTime), 16, 4)
INSERT [dbo].[Utakmica] ([UtakmicaId], [BrojPoenaDomacin], [BrojPoenaGost], [DatumOdigravanja], [DomacinId], [GostId]) VALUES (5, 62, 69, CAST(N'2022-10-06T20:00:57.000' AS DateTime), 10, 6)
INSERT [dbo].[Utakmica] ([UtakmicaId], [BrojPoenaDomacin], [BrojPoenaGost], [DatumOdigravanja], [DomacinId], [GostId]) VALUES (6, 70, 80, CAST(N'2022-10-07T20:30:47.000' AS DateTime), 7, 12)
INSERT [dbo].[Utakmica] ([UtakmicaId], [BrojPoenaDomacin], [BrojPoenaGost], [DatumOdigravanja], [DomacinId], [GostId]) VALUES (8, 62, 74, CAST(N'2022-10-06T20:30:00.000' AS DateTime), 8, 9)
INSERT [dbo].[Utakmica] ([UtakmicaId], [BrojPoenaDomacin], [BrojPoenaGost], [DatumOdigravanja], [DomacinId], [GostId]) VALUES (9, 84, 83, CAST(N'2022-10-06T20:05:00.000' AS DateTime), 11, 18)
INSERT [dbo].[Utakmica] ([UtakmicaId], [BrojPoenaDomacin], [BrojPoenaGost], [DatumOdigravanja], [DomacinId], [GostId]) VALUES (10, 68, 71, CAST(N'2022-10-06T20:00:21.000' AS DateTime), 13, 15)
INSERT [dbo].[Utakmica] ([UtakmicaId], [BrojPoenaDomacin], [BrojPoenaGost], [DatumOdigravanja], [DomacinId], [GostId]) VALUES (11, 103, 96, CAST(N'2022-10-14T20:30:00.000' AS DateTime), 4, 14)
INSERT [dbo].[Utakmica] ([UtakmicaId], [BrojPoenaDomacin], [BrojPoenaGost], [DatumOdigravanja], [DomacinId], [GostId]) VALUES (12, 90, 62, CAST(N'2022-10-20T20:30:00.000' AS DateTime), 14, 17)
INSERT [dbo].[Utakmica] ([UtakmicaId], [BrojPoenaDomacin], [BrojPoenaGost], [DatumOdigravanja], [DomacinId], [GostId]) VALUES (1001, 75, 80, CAST(N'2022-10-18T20:45:00.000' AS DateTime), 14, 6)
SET IDENTITY_INSERT [dbo].[Utakmica] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Unique_Username]    Script Date: 30-Aug-23 20:13:44 ******/
ALTER TABLE [dbo].[Administrator] ADD  CONSTRAINT [Unique_Username] UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Igrac]  WITH CHECK ADD  CONSTRAINT [FK_Igrac_Tim] FOREIGN KEY([TimId])
REFERENCES [dbo].[Tim] ([TimId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Igrac] CHECK CONSTRAINT [FK_Igrac_Tim]
GO
ALTER TABLE [dbo].[Statistika]  WITH CHECK ADD  CONSTRAINT [FK_Statistika_Igrac] FOREIGN KEY([IgracId])
REFERENCES [dbo].[Igrac] ([IgracId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Statistika] CHECK CONSTRAINT [FK_Statistika_Igrac]
GO
ALTER TABLE [dbo].[Statistika]  WITH CHECK ADD  CONSTRAINT [FK_Statistika_Utakmica] FOREIGN KEY([UtakmicaId])
REFERENCES [dbo].[Utakmica] ([UtakmicaId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Statistika] CHECK CONSTRAINT [FK_Statistika_Utakmica]
GO
ALTER TABLE [dbo].[Tim]  WITH CHECK ADD  CONSTRAINT [FK_Tim_Dvorana] FOREIGN KEY([DvoranaId])
REFERENCES [dbo].[Dvorana] ([DvoranaId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Tim] CHECK CONSTRAINT [FK_Tim_Dvorana]
GO
ALTER TABLE [dbo].[Utakmica]  WITH CHECK ADD  CONSTRAINT [FK_Utakmica_Tim] FOREIGN KEY([DomacinId])
REFERENCES [dbo].[Tim] ([TimId])
GO
ALTER TABLE [dbo].[Utakmica] CHECK CONSTRAINT [FK_Utakmica_Tim]
GO
ALTER TABLE [dbo].[Utakmica]  WITH CHECK ADD  CONSTRAINT [FK_Utakmica_Tim1] FOREIGN KEY([GostId])
REFERENCES [dbo].[Tim] ([TimId])
GO
ALTER TABLE [dbo].[Utakmica] CHECK CONSTRAINT [FK_Utakmica_Tim1]
GO
USE [master]
GO
ALTER DATABASE [Projekat] SET  READ_WRITE 
GO
