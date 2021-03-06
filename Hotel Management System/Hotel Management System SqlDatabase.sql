USE [Pansiyon]
GO
/****** Object:  Table [dbo].[Tbl_Complaints]    Script Date: 25.09.2021 13:40:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Complaints](
	[Cid] [smallint] IDENTITY(1,1) NOT NULL,
	[Complaint] [nvarchar](400) NOT NULL,
	[ComplaintDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Tbl_Complaints] PRIMARY KEY CLUSTERED 
(
	[Cid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Deneme]    Script Date: 25.09.2021 13:40:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Deneme](
	[id] [smallint] NOT NULL,
	[mainCourses] [nvarchar](300) NOT NULL,
	[mainCourseNames] [nvarchar](50) NOT NULL,
	[sideDishes] [nvarchar](300) NOT NULL,
	[sideDishesNames] [nvarchar](50) NOT NULL,
	[desserts] [nvarchar](300) NOT NULL,
	[dessertsNames] [nvarchar](50) NOT NULL,
	[mealDate] [nvarchar](15) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Manager]    Script Date: 25.09.2021 13:40:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Manager](
	[MId] [smallint] IDENTITY(1,1) NOT NULL,
	[MName] [varchar](20) NOT NULL,
	[MSurname] [varchar](20) NOT NULL,
	[MGender] [char](6) NOT NULL,
	[MUsername] [varchar](15) NOT NULL,
	[MPass] [varchar](65) NOT NULL,
	[MMail] [varchar](50) NOT NULL,
	[MPhone] [char](20) NOT NULL,
	[Mentry] [datetime] NOT NULL,
	[MImage] [varchar](300) NOT NULL,
 CONSTRAINT [PK_tbl_Manager] PRIMARY KEY CLUSTERED 
(
	[MId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Notice]    Script Date: 25.09.2021 13:40:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Notice](
	[NId] [smallint] IDENTITY(1,1) NOT NULL,
	[Notice] [varchar](500) NOT NULL,
	[NoticeDate] [datetime] NOT NULL,
 CONSTRAINT [PK_tbl_Notice] PRIMARY KEY CLUSTERED 
(
	[NId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Personal]    Script Date: 25.09.2021 13:40:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Personal](
	[PersonalId] [smallint] IDENTITY(1,1) NOT NULL,
	[PName] [varchar](20) NOT NULL,
	[PSurname] [varchar](20) NOT NULL,
	[PGender] [char](6) NOT NULL,
	[PUsername] [varchar](15) NOT NULL,
	[PPass] [varchar](65) NOT NULL,
	[PMail] [varchar](50) NOT NULL,
	[PPhone] [char](20) NOT NULL,
	[PEntry] [datetime] NOT NULL,
	[PImage] [varchar](300) NOT NULL,
 CONSTRAINT [PK_tbl_Personal] PRIMARY KEY CLUSTERED 
(
	[PersonalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Reports]    Script Date: 25.09.2021 13:40:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Reports](
	[Rid] [smallint] IDENTITY(1,1) NOT NULL,
	[Report] [nvarchar](400) NOT NULL,
	[ReportDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Tbl_Reports] PRIMARY KEY CLUSTERED 
(
	[Rid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Rooms]    Script Date: 25.09.2021 13:40:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Rooms](
	[RId] [smallint] IDENTITY(1,1) NOT NULL,
	[RNo] [smallint] NOT NULL,
	[REmptyFull] [bit] NOT NULL,
 CONSTRAINT [PK_tbl_Rooms] PRIMARY KEY CLUSTERED 
(
	[RId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Stdnt]    Script Date: 25.09.2021 13:40:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Stdnt](
	[SId] [smallint] IDENTITY(1,1) NOT NULL,
	[SName] [varchar](20) NOT NULL,
	[SSurname] [varchar](20) NOT NULL,
	[SGender] [char](6) NOT NULL,
	[SUserName] [varchar](15) NOT NULL,
	[SPass] [varchar](65) NOT NULL,
	[SMail] [varchar](50) NOT NULL,
	[SPhone] [char](20) NOT NULL,
	[SRoomNo] [char](10) NOT NULL,
	[SEntry] [datetime] NOT NULL,
	[SImage] [varchar](300) NOT NULL,
 CONSTRAINT [PK_tbl_Stdnt] PRIMARY KEY CLUSTERED 
(
	[SId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tbl_Complaints] ON 

INSERT [dbo].[Tbl_Complaints] ([Cid], [Complaint], [ComplaintDate]) VALUES (2, N'yunus emre', CAST(N'2021-09-10T17:24:19.277' AS DateTime))
SET IDENTITY_INSERT [dbo].[Tbl_Complaints] OFF
GO
INSERT [dbo].[tbl_Deneme] ([id], [mainCourses], [mainCourseNames], [sideDishes], [sideDishesNames], [desserts], [dessertsNames], [mealDate]) VALUES (1, N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Main Courses\barbunya.jpg', N'Barbunya', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Side Dishes\ayvalı kereviz.jpg', N'Ayvalı Kereviz', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\desserts\ay tatlısı.jpg', N'Ay Tatlısı', N'06 . 09 . 2021')
INSERT [dbo].[tbl_Deneme] ([id], [mainCourses], [mainCourseNames], [sideDishes], [sideDishesNames], [desserts], [dessertsNames], [mealDate]) VALUES (2, N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Main Courses\çullama.jpg', N'Çullama', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Side Dishes\balkabağı.jpg', N'Balkabağı', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\desserts\gelin pastası.jpg', N'Gelin Pastası', N'06 . 09 . 2021')
INSERT [dbo].[tbl_Deneme] ([id], [mainCourses], [mainCourseNames], [sideDishes], [sideDishesNames], [desserts], [dessertsNames], [mealDate]) VALUES (3, N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Main Courses\enginar.jpg', N'Enginar', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Side Dishes\bebek enginar.jpg', N'Bebek Enginar', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\desserts\irmik helvası.jpg', N'İrmik Helvası', N'06 . 09 . 2021')
INSERT [dbo].[tbl_Deneme] ([id], [mainCourses], [mainCourseNames], [sideDishes], [sideDishesNames], [desserts], [dessertsNames], [mealDate]) VALUES (4, N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Main Courses\fasülye kavurması.jpg', N'Fasülye Kavurması', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Side Dishes\harşıl.jpg', N'Harşıl', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\desserts\kek.jpg', N'Kek', N'06 . 09 . 2021')
INSERT [dbo].[tbl_Deneme] ([id], [mainCourses], [mainCourseNames], [sideDishes], [sideDishesNames], [desserts], [dessertsNames], [mealDate]) VALUES (5, N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Main Courses\hünkar beğendi.jpg', N'Hünkar Beğendi', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Side Dishes\iç pilav.jpg', N'İç Pilav', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\desserts\magnolia.jpg', N'Magnolia', N'06 . 09 . 2021')
INSERT [dbo].[tbl_Deneme] ([id], [mainCourses], [mainCourseNames], [sideDishes], [sideDishesNames], [desserts], [dessertsNames], [mealDate]) VALUES (6, N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Main Courses\kabak borani.jpg', N'Kabak Boranı', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Side Dishes\ıspanak çorbası.jpg', N'Ispanak Çorbası', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\desserts\muhallebi.jpg', N'Muhallebi', N'06 . 09 . 2021')
INSERT [dbo].[tbl_Deneme] ([id], [mainCourses], [mainCourseNames], [sideDishes], [sideDishesNames], [desserts], [dessertsNames], [mealDate]) VALUES (7, N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Main Courses\lazanya.jpg', N'Lazanya', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Side Dishes\kabak dolması.jpg', N'Kabak Dolması', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\desserts\nevzine.jpg', N'Nevzine', N'06 . 09 . 2021')
INSERT [dbo].[tbl_Deneme] ([id], [mainCourses], [mainCourseNames], [sideDishes], [sideDishesNames], [desserts], [dessertsNames], [mealDate]) VALUES (8, N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Main Courses\macar kebabı.jpg', N'Macar Kebabı', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Side Dishes\kabak mücver.jpg', N'Kabak Mücver', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\desserts\profiterol.jpg', N'Profiterol', N'06 . 09 . 2021')
INSERT [dbo].[tbl_Deneme] ([id], [mainCourses], [mainCourseNames], [sideDishes], [sideDishesNames], [desserts], [dessertsNames], [mealDate]) VALUES (9, N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Main Courses\mantar.jpg', N'Mantar', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Side Dishes\kerevizli levrek.jpg', N'Kerevizli Levrek', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\desserts\puding.jpg', N'Puding', N'06 . 09 . 2021')
INSERT [dbo].[tbl_Deneme] ([id], [mainCourses], [mainCourseNames], [sideDishes], [sideDishesNames], [desserts], [dessertsNames], [mealDate]) VALUES (10, N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Main Courses\mantı.jpg', N'Mantı', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Side Dishes\mantarlı tavuk sote.jpg', N'Mantarlı Tavuk Sote', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\desserts\revani.jpg', N'Revani', N'06 . 09 . 2021')
INSERT [dbo].[tbl_Deneme] ([id], [mainCourses], [mainCourseNames], [sideDishes], [sideDishesNames], [desserts], [dessertsNames], [mealDate]) VALUES (11, N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Main Courses\sebzeli güveç.jpg', N'Sebzeli Güveç', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Side Dishes\melki yemeği.jpg', N'Melki Yemeği', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\desserts\soğuk baklava.jpg', N'Soğuk Baklava', N'06 . 09 . 2021')
INSERT [dbo].[tbl_Deneme] ([id], [mainCourses], [mainCourseNames], [sideDishes], [sideDishesNames], [desserts], [dessertsNames], [mealDate]) VALUES (12, N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Main Courses\sömelek köfte.jpg', N'Sömelek Köfte', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Side Dishes\paçanga böreği.jpg', N'Paçanga Böreği', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\desserts\şekerpare.jpg', N'Şekerpare', N'06 . 09 . 2021')
INSERT [dbo].[tbl_Deneme] ([id], [mainCourses], [mainCourseNames], [sideDishes], [sideDishesNames], [desserts], [dessertsNames], [mealDate]) VALUES (13, N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Main Courses\tas kebabı.jpg', N'Tas Kebabı', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Side Dishes\pırasa.jpg', N'Pırasa', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\desserts\turta.jpg', N'Turta', N'06 . 09 . 2021')
INSERT [dbo].[tbl_Deneme] ([id], [mainCourses], [mainCourseNames], [sideDishes], [sideDishesNames], [desserts], [dessertsNames], [mealDate]) VALUES (14, N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Main Courses\tavuk göğsü.jpg', N'Tavuk Göğsü', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Side Dishes\soslu tavuk.jpg', N'Soslu Tavuk', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\desserts\un helvası.jpg', N'Un Helvası', N'06 . 09 . 2021')
INSERT [dbo].[tbl_Deneme] ([id], [mainCourses], [mainCourseNames], [sideDishes], [sideDishesNames], [desserts], [dessertsNames], [mealDate]) VALUES (15, N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Main Courses\et köfte.jpg', N'Et Köfte', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\Side Dishes\hafif kısır.jpg', N'Hafif Kısır', N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\mealList\desserts\kaşık tatlısı.jpg', N'Kaşık Tatlısı', N'06 . 09 . 2021')
GO
SET IDENTITY_INSERT [dbo].[tbl_Manager] ON 

INSERT [dbo].[tbl_Manager] ([MId], [MName], [MSurname], [MGender], [MUsername], [MPass], [MMail], [MPhone], [Mentry], [MImage]) VALUES (2, N'Hatun', N'Keskin', N'Female', N'Hatun21', N'fbc36b1db6b55124ca3948dc32fb47096ae4d61b34daf2fa293ebf6cd9ce1e74', N'example@gmail.com', N'(536) 852-9764      ', CAST(N'2021-09-22T00:00:00.000' AS DateTime), N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\ManagerFemale.png')
INSERT [dbo].[tbl_Manager] ([MId], [MName], [MSurname], [MGender], [MUsername], [MPass], [MMail], [MPhone], [Mentry], [MImage]) VALUES (4, N'Mehmet', N'Bicim', N'Male  ', N'Mehmet21', N'64d59ecf027dfd21b8ca6ff0deefa2895cb3e624d0f55972f15e0ca56247ed0d', N'example@gmail.com', N'(589) 647-8512      ', CAST(N'2020-05-21T00:00:00.000' AS DateTime), N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\manager.jpg')
SET IDENTITY_INSERT [dbo].[tbl_Manager] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Notice] ON 

INSERT [dbo].[tbl_Notice] ([NId], [Notice], [NoticeDate]) VALUES (6, N'yarın yapılacak olan yurt/ pansiyon seçmelerine son kayıt bugun sona eriyor. Tüm ogrencilerin bilgisine.', CAST(N'2021-08-22T13:44:18.707' AS DateTime))
INSERT [dbo].[tbl_Notice] ([NId], [Notice], [NoticeDate]) VALUES (7, N'iste yurt olarak hayvanlara yapıcağımız yardımlarda yurdumuzdan gelmek isteyen ogrencilerin kayıt yaptırması gerekmektedir.', CAST(N'2021-08-22T13:44:54.043' AS DateTime))
INSERT [dbo].[tbl_Notice] ([NId], [Notice], [NoticeDate]) VALUES (8, N'yapılan incelemeler neticesinde haftaya salı günü aynı saatte tekrar kurul toplanacak.', CAST(N'2021-08-22T13:45:28.293' AS DateTime))
INSERT [dbo].[tbl_Notice] ([NId], [Notice], [NoticeDate]) VALUES (9, N'ogrencilerin burs ve kredi sonuçları açıklanmıştır.', CAST(N'2021-08-22T13:45:56.917' AS DateTime))
INSERT [dbo].[tbl_Notice] ([NId], [Notice], [NoticeDate]) VALUES (10, N'akşam saat 23:00 ''dan itibaren yurda girişler yasaklanacaktır.', CAST(N'2021-08-22T13:46:16.557' AS DateTime))
INSERT [dbo].[tbl_Notice] ([NId], [Notice], [NoticeDate]) VALUES (11, N'Yurda dışardan yiyecek sokmak yasak.', CAST(N'2021-08-22T13:46:27.617' AS DateTime))
INSERT [dbo].[tbl_Notice] ([NId], [Notice], [NoticeDate]) VALUES (12, N'Tüm görevli personellerin dikkatine!!', CAST(N'2021-08-22T13:46:40.310' AS DateTime))
INSERT [dbo].[tbl_Notice] ([NId], [Notice], [NoticeDate]) VALUES (13, N'yarın iste teknoversite gunu dolayısıyla ogrencilerin yurt sorumluluk faaliyetleri geçici süreliğine ertelenmiştir.', CAST(N'2021-08-22T13:47:19.230' AS DateTime))
INSERT [dbo].[tbl_Notice] ([NId], [Notice], [NoticeDate]) VALUES (14, N'iste yaz kampı ile gençlerimizin doğa ile bütünleşik yaşamı sağlamak amacıyla bir tur düzenlenecektir.', CAST(N'2021-08-22T13:47:58.110' AS DateTime))
INSERT [dbo].[tbl_Notice] ([NId], [Notice], [NoticeDate]) VALUES (102, N'Teknofest katılımları ile ilgili gerekli belgeleri idareye teslim ediniz!!!', CAST(N'2021-09-10T17:37:16.547' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_Notice] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Personal] ON 

INSERT [dbo].[tbl_Personal] ([PersonalId], [PName], [PSurname], [PGender], [PUsername], [PPass], [PMail], [PPhone], [PEntry], [PImage]) VALUES (14, N'poyraz', N'kızıl', N'Male  ', N'poyraz21', N'e886b495b677510e3a4f5bb12240cb72916c8fc6555270cc54bfa45738fee6b0', N'example@gmail.com', N'5896856532          ', CAST(N'2021-02-21T00:00:00.000' AS DateTime), N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\Personal1.png')
INSERT [dbo].[tbl_Personal] ([PersonalId], [PName], [PSurname], [PGender], [PUsername], [PPass], [PMail], [PPhone], [PEntry], [PImage]) VALUES (21, N'hande', N'soral', N'Female', N'hande21', N'93b3438ac5c4ad1e862242fc6fb4c2cd8f1555a21351855ce429413707ec71cd', N'example@gmail.com', N'(569) 879-7979      ', CAST(N'2021-09-09T00:05:18.000' AS DateTime), N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\Personal2.png')
INSERT [dbo].[tbl_Personal] ([PersonalId], [PName], [PSurname], [PGender], [PUsername], [PPass], [PMail], [PPhone], [PEntry], [PImage]) VALUES (114, N'bill', N'gates', N'Male  ', N'bill21', N'9548b3c39a7ef3f6ff1e1fb3053ee07d7ce004c8f6537870711cd635363ae926', N'example@gmail.com', N'(615) 616-5161      ', CAST(N'2021-09-10T17:34:51.000' AS DateTime), N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\personal_3.jpg')
SET IDENTITY_INSERT [dbo].[tbl_Personal] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Rooms] ON 

INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (1, 1, 1)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (2, 2, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (3, 3, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (4, 4, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (5, 5, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (6, 6, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (7, 7, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (8, 8, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (9, 9, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (10, 10, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (11, 11, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (12, 12, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (13, 13, 1)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (14, 14, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (15, 15, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (16, 16, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (17, 17, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (18, 18, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (19, 19, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (20, 20, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (21, 21, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (22, 22, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (23, 23, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (24, 24, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (25, 25, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (26, 26, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (27, 27, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (28, 28, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (29, 29, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (30, 30, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (31, 31, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (32, 32, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (33, 33, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (34, 34, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (35, 35, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (36, 36, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (37, 37, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (38, 38, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (39, 39, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (40, 40, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (41, 41, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (42, 42, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (43, 43, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (44, 44, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (45, 45, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (46, 46, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (47, 47, 0)
INSERT [dbo].[tbl_Rooms] ([RId], [RNo], [REmptyFull]) VALUES (48, 48, 1)
SET IDENTITY_INSERT [dbo].[tbl_Rooms] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Stdnt] ON 

INSERT [dbo].[tbl_Stdnt] ([SId], [SName], [SSurname], [SGender], [SUserName], [SPass], [SMail], [SPhone], [SRoomNo], [SEntry], [SImage]) VALUES (127, N'yunus', N'emre', N'Male  ', N'yunus21', N'09b904a5ba798e840f70e6151de72340a492aa744d56dff501fbb648e8a694be', N'example@gmail.com', N'5698754125          ', N'1         ', CAST(N'2021-02-21T00:00:00.000' AS DateTime), N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\Student.png')
INSERT [dbo].[tbl_Stdnt] ([SId], [SName], [SSurname], [SGender], [SUserName], [SPass], [SMail], [SPhone], [SRoomNo], [SEntry], [SImage]) VALUES (128, N'hale', N'demir', N'Female', N'hale21', N'c48fda01a05de97230d9929ad399b42884484863e1116d38c5bafcac71787de1', N'example@gmail.com', N'(548) 979-8797      ', N'48        ', CAST(N'2021-09-09T00:04:09.000' AS DateTime), N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\student.jpg')
INSERT [dbo].[tbl_Stdnt] ([SId], [SName], [SSurname], [SGender], [SUserName], [SPass], [SMail], [SPhone], [SRoomNo], [SEntry], [SImage]) VALUES (217, N'melisa', N'döngel', N'Female', N'melisa21', N'd73f8e9531852531ea9f4fcd87941def0b5e3f16015cccfbf0062f4d86229fc0', N'example@gmail.com', N'(849) 848-9498      ', N'13        ', CAST(N'2021-09-10T17:33:13.000' AS DateTime), N'C:\Users\emree\Desktop\Pansiyon otomasyonu\Resimler\student_2.png')
SET IDENTITY_INSERT [dbo].[tbl_Stdnt] OFF
GO
