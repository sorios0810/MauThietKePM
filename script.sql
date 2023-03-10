CREATE DATABASE QLMoto
USE [QLMoto]
GO
/****** Object:  Table [dbo].[ChiTietDG]    Script Date: Sat 19 6 2021 5:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDG](
	[IDKH] [int] NOT NULL,
	[IDMau] [varchar](50) NOT NULL,
	[NoiDungDG] [nvarchar](200) NULL,
 CONSTRAINT [PK_ChiTietDanhGia] PRIMARY KEY CLUSTERED 
(
	[IDKH] ASC,
	[IDMau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHD]    Script Date: Sat 19 6 2021 5:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHD](
	[IDHD] [varchar](50) NOT NULL,
	[IDXe] [varchar](50) NOT NULL,
	[KhuyenMai] [int] NULL,
	[GiaBan] [money] NOT NULL,
 CONSTRAINT [PK_ChiTietHD] PRIMARY KEY CLUSTERED 
(
	[IDHD] ASC,
	[IDXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatLich]    Script Date: Sat 19 6 2021 5:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatLich](
	[IDDatLich] [int] IDENTITY(1,1) NOT NULL,
	[IDMau] [varchar](50) NOT NULL,
	[IDKH] [int] NOT NULL,
	[NgayDat] [datetime] NOT NULL,
	[XacNhan] [bit] NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_DatLich] PRIMARY KEY CLUSTERED 
(
	[IDDatLich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hang]    Script Date: Sat 19 6 2021 5:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hang](
	[IDHang] [varchar](50) NOT NULL,
	[TenHang] [nvarchar](50) NOT NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_Hang] PRIMARY KEY CLUSTERED 
(
	[IDHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: Sat 19 6 2021 5:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[IDHD] [varchar](50) NOT NULL,
	[IDKH] [int] NOT NULL,
	[NgayDat] [date] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[IDHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: Sat 19 6 2021 5:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[IDKH] [int] NOT NULL,
	[IDType] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Pass] [varchar](50) NOT NULL,
	[TenKH] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [varchar](20) NOT NULL,
	[Avatar] [varchar](max) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[IDKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: Sat 19 6 2021 5:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[IDKM] [varchar](50) NOT NULL,
	[GiaTri] [int] NOT NULL,
 CONSTRAINT [PK_KhuyenMai] PRIMARY KEY CLUSTERED 
(
	[IDKM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MauXe]    Script Date: Sat 19 6 2021 5:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MauXe](
	[IDMau] [varchar](50) NOT NULL,
	[IDKM] [varchar](50) NOT NULL,
	[IDHang] [varchar](50) NOT NULL,
	[TenXe] [nvarchar](50) NOT NULL,
	[GiaBan] [money] NOT NULL,
	[HinhAnh1] [varchar](max) NULL,
	[HinhAnh2] [varchar](max) NULL,
	[HinhAnh3] [varchar](max) NULL,
	[BaoHanh] [int] NOT NULL,
	[MoTa] [nvarchar](max) NOT NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_MauXe] PRIMARY KEY CLUSTERED 
(
	[IDMau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: Sat 19 6 2021 5:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[IDNV] [int] NOT NULL,
	[IDType] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Pass] [varchar](50) NOT NULL,
	[TenNV] [nvarchar](100) NOT NULL,
	[DienThoai] [varchar](20) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[CMND] [varchar](20) NOT NULL,
	[Avatar] [varchar](max) NULL,
	[IDRole] [varchar](50) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[IDNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: Sat 19 6 2021 5:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[IDRole] [varchar](50) NOT NULL,
	[QLMau] [bit] NOT NULL,
	[QLHang] [bit] NOT NULL,
	[QLGia] [bit] NOT NULL,
	[QLHD] [bit] NOT NULL,
	[QLNV] [bit] NOT NULL,
	[QLBanHang] [bit] NOT NULL,
	[QLDatLich] [bit] NOT NULL,
	[DSXe] [bit] NOT NULL,
	[DSKH] [bit] NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[IDRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeAcc]    Script Date: Sat 19 6 2021 5:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeAcc](
	[IDType] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TypeAcc] PRIMARY KEY CLUSTERED 
(
	[IDType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: Sat 19 6 2021 5:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[IDXe] [varchar](50) NOT NULL,
	[IDMau] [varchar](50) NOT NULL,
	[TrangThai] [bit] NOT NULL,
	[TenXe] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Xe] PRIMARY KEY CLUSTERED 
(
	[IDXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[ChiTietDG] ([IDKH], [IDMau], [NoiDungDG]) VALUES (2, N'DCT1', N'Xe rất đẹp, đáng đồng tiền bát gạo !!!')
GO
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD1', N'MT-10-1', 0, 659000000.0000)
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD1', N'MT-10-2', 0, 659000000.0000)
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD2', N'S1000RR-1', 0, 949000000.0000)
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD2', N'S1000RR-2', 0, 949000000.0000)
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD3', N'S1000RR-4', 0, 949000000.0000)
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD4', N'R9T-RACER-3', 0, 659000000.0000)
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD4', N'R9T-RACER-5', 0, 659000000.0000)
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD4', N'S1000RR-3', 0, 949000000.0000)
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD5', N'BMW-HP4-6', 0, 1100000000.0000)
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD5', N'XZF-R1-5', 0, 729000000.0000)
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD6', N'MULTISTRADA-1260S-3', 0, 743000000.0000)
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD6', N'R1200-GSA-3', 0, 659000000.0000)
INSERT [dbo].[ChiTietHD] ([IDHD], [IDXe], [KhuyenMai], [GiaBan]) VALUES (N'HD7', N'XDIEVAL-1', 10, 200000000.0000)
GO
SET IDENTITY_INSERT [dbo].[DatLich] ON 

INSERT [dbo].[DatLich] ([IDDatLich], [IDMau], [IDKH], [NgayDat], [XacNhan], [GhiChu]) VALUES (1, N'BMW4', 2, CAST(N'2021-04-14T00:00:00.000' AS DateTime), 1, NULL)
INSERT [dbo].[DatLich] ([IDDatLich], [IDMau], [IDKH], [NgayDat], [XacNhan], [GhiChu]) VALUES (2, N'BMW4', 1, CAST(N'2021-04-14T00:00:00.000' AS DateTime), 1, NULL)
SET IDENTITY_INSERT [dbo].[DatLich] OFF
GO
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'BMW', N'BMW', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'DCT', N'Ducati', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'HD', N'Honda', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'KTM', N'KTM', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'KW', N'Kawasaki', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'SZ', N'Suzuki', 1)
INSERT [dbo].[Hang] ([IDHang], [TenHang], [TrangThai]) VALUES (N'YM', N'Yamaha', 1)
GO
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [NgayDat]) VALUES (N'HD1', 1, CAST(N'2021-04-04' AS Date))
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [NgayDat]) VALUES (N'HD2', 1, CAST(N'2021-06-06' AS Date))
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [NgayDat]) VALUES (N'HD3', 2, CAST(N'2021-06-07' AS Date))
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [NgayDat]) VALUES (N'HD4', 2, CAST(N'2021-06-08' AS Date))
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [NgayDat]) VALUES (N'HD5', 3, CAST(N'2021-06-19' AS Date))
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [NgayDat]) VALUES (N'HD6', 51, CAST(N'2021-06-19' AS Date))
INSERT [dbo].[HoaDon] ([IDHD], [IDKH], [NgayDat]) VALUES (N'HD7', 1, CAST(N'2021-06-19' AS Date))
GO
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (1, N'type03', N'cus.huflit1@gmail.com', N'724303', N'Nguyễn Ngọc Trúc', N'abc', N'0335488xxx', N'/img/avt-kh1.jpg')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (2, N'type03', N'cus.huflit2@gmail.com', N'customer', N'Customer2', N'abc', N'123', N'/img/icon.png')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (3, N'type03', N'fkelk2@wunderground.com', N'CNai5saz533', N'Freida Kelk', N'0 Warner Street', N'543-961-8733', N'https://robohash.org/optioautemiusto.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (4, N'type03', N'lmclaren3@e-recht24.de', N'NuxGHm7KI', N'Loella McLaren', N'7971 Jay Center', N'720-219-9148', N'https://robohash.org/nemovoluptasfacere.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (5, N'type03', N'eshilvock4@yelp.com', N'H9gZfH', N'Etty Shilvock', N'3 Michigan Point', N'377-465-7703', N'https://robohash.org/quasofficiisid.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (6, N'type03', N'fpaulich5@themeforest.net', N'3rZ2FMgSr4Ni', N'Fields Paulich', N'524 Grayhawk Lane', N'637-688-3910', N'https://robohash.org/invelat.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (7, N'type03', N'eberlin6@apple.com', N'tr77l3p24', N'Evania Berlin', N'640 Stephen Road', N'152-749-2776', N'https://robohash.org/etundemaiores.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (8, N'type03', N'wcathee7@aboutads.info', N'p4c6miy8', N'Wendie Cathee', N'53 Hintze Hill', N'957-568-0587', N'https://robohash.org/consequaturdeserunttempore.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (9, N'type03', N'hallston8@usnews.com', N'mVOFZ5Adib', N'Harlan Allston', N'49994 Annamark Point', N'868-108-4405', N'https://robohash.org/atquequasiet.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (10, N'type03', N'qstockbridge9@phoca.cz', N'zC7hrVXZGU', N'Quint Stockbridge', N'075 Springview Trail', N'615-404-9795', N'https://robohash.org/commodiofficiisnecessitatibus.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (11, N'type03', N'stownbya@vimeo.com', N'quNz0Ss0Rn4F', N'Sela Townby', N'5 Daystar Crossing', N'912-275-5773', N'https://robohash.org/voluptaseadolor.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (12, N'type03', N'adudingb@barnesandnoble.com', N'bShSHEVCjb', N'Ariel Duding', N'89544 Amoth Place', N'646-583-8527', N'https://robohash.org/quiaofficiaet.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (13, N'type03', N'cwhitcombc@vk.com', N'LW7YzxX06TFM', N'Candis Whitcomb', N'7217 Rowland Point', N'115-672-7198', N'https://robohash.org/essevoluptasvoluptas.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (14, N'type03', N'jdutchd@weather.com', N'wWTK2sXQkjd', N'Jim Dutch', N'842 Golf Way', N'551-232-9577', N'https://robohash.org/teneturexercitationemofficia.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (15, N'type03', N'mdonnersberge@businesswire.com', N'cr0O57B5imo', N'Mommy Donnersberg', N'26 East Trail', N'836-545-3334', N'https://robohash.org/harumhicvoluptatum.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (16, N'type03', N'msimmsf@goodreads.com', N'ZXFKWqiClmHO', N'Merola Simms', N'85377 Bay Junction', N'454-441-0859', N'https://robohash.org/officiasintiusto.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (17, N'type03', N'agrimsdykeg@bizjournals.com', N'ZbCNNAsx2541', N'Arv Grimsdyke', N'06857 Sullivan Alley', N'702-959-9845', N'https://robohash.org/maximeutomnis.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (18, N'type03', N'hseldonh@newyorker.com', N'sIykAyW', N'Hermine Seldon', N'1568 North Street', N'923-417-4214', N'https://robohash.org/numquamasperioresvoluptatem.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (19, N'type03', N'abirchneri@gov.uk', N'xEYsWmX', N'Alasdair Birchner', N'224 Bashford Hill', N'827-522-3523', N'https://robohash.org/illumaliquidprovident.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (20, N'type03', N'gklimekj@marriott.com', N'xM6IYpRlXxPS', N'Gasper Klimek', N'482 Bunker Hill Court', N'442-135-5850', N'https://robohash.org/adipiscinequeodit.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (21, N'type03', N'edunridgek@1688.com', N'ZkQcQKrA', N'Elysee Dunridge', N'6732 Cody Point', N'341-106-6320', N'https://robohash.org/officiaquibusdamet.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (22, N'type03', N'rbuttingl@purevolume.com', N'HSYjUzF', N'Rodge Butting', N'7 Mosinee Junction', N'245-141-8993', N'https://robohash.org/quoexporro.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (23, N'type03', N'ccorlettm@artisteer.com', N'YI50XE', N'Corrie Corlett', N'92574 Leroy Lane', N'748-339-3672', N'https://robohash.org/verononnulla.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (24, N'type03', N'lwallagen@oakley.com', N'ktqAUk1tM', N'Laurice Wallage', N'16674 Esch Point', N'379-989-6637', N'https://robohash.org/recusandaenihilquam.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (25, N'type03', N'emulvihillo@ustream.tv', N'ODNO4vR6f', N'Ellis Mulvihill', N'53534 Becker Drive', N'578-431-7842', N'https://robohash.org/sequiliberoullam.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (26, N'type03', N'khoffp@elpais.com', N'KlTESy', N'Kaylil Hoff', N'9851 Continental Plaza', N'251-656-7410', N'https://robohash.org/ipsametdistinctio.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (27, N'type03', N'crealphq@va.gov', N'OO3hAEZQ52', N'Casie Realph', N'09 Blackbird Plaza', N'680-371-0139', N'https://robohash.org/voluptasquiomnis.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (28, N'type03', N'lwathallr@blog.com', N'3ola6n', N'Linc Wathall', N'3849 Hanson Lane', N'822-648-5651', N'https://robohash.org/repellatametvoluptatem.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (29, N'type03', N'ekoberas@wufoo.com', N'ZSbHgakv', N'Emmanuel Kobera', N'8875 Welch Place', N'697-283-6551', N'https://robohash.org/easintest.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (30, N'type03', N'obeglint@google.cn', N'TOlOJ4bQg', N'Olivier Beglin', N'9 Becker Circle', N'557-855-8667', N'https://robohash.org/aperiamautsoluta.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (31, N'type03', N'hjanseyu@arstechnica.com', N'H3U4MdNf', N'Hughie Jansey', N'4029 Clarendon Street', N'311-866-6820', N'https://robohash.org/velvoluptatemsaepe.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (32, N'type03', N'zbingallv@amazon.co.jp', N'udDZIB34dh', N'Zia Bingall', N'94444 Spohn Crossing', N'856-299-3767', N'https://robohash.org/hicnecessitatibussit.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (33, N'type03', N'kcettellw@answers.com', N'ejWvgRkU', N'Kizzie Cettell', N'42322 Jenna Junction', N'277-118-7236', N'https://robohash.org/repellendusundeanimi.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (34, N'type03', N'bbrookerx@unicef.org', N'020F5JNiq', N'Bear Brooker', N'5 West Junction', N'156-625-7927', N'https://robohash.org/commodihicvel.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (35, N'type03', N'sbohlensy@seattletimes.com', N'2jw6eFw', N'Shel Bohlens', N'0475 Toban Trail', N'481-453-5346', N'https://robohash.org/porroquibusdamvoluptatem.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (36, N'type03', N'smacilraithz@ft.com', N'vWyjVrBQO', N'Steffen MacIlraith', N'5128 Service Place', N'129-888-5872', N'https://robohash.org/perferendisautaccusamus.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (37, N'type03', N'cantrack10@over-blog.com', N'bkVupd4B', N'Craig Antrack', N'602 Esch Court', N'504-884-6054', N'https://robohash.org/estidodit.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (38, N'type03', N'cglozman11@blogs.com', N'Js0YeYew', N'Carin Glozman', N'5 Mesta Plaza', N'916-843-4544', N'https://robohash.org/estveritatisodio.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (39, N'type03', N'rsofe12@artisteer.com', N'lwGEoO0i', N'Rock Sofe', N'8600 Schlimgen Street', N'620-549-7507', N'https://robohash.org/nonametdolores.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (40, N'type03', N'ncourtese13@dropbox.com', N'OM00mmX', N'Nicolette Courtese', N'1128 Banding Terrace', N'201-121-7521', N'https://robohash.org/etsuntquo.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (41, N'type03', N'hmashal14@bloglines.com', N'rGIO1rja', N'Heather Mashal', N'55 Tennyson Street', N'658-193-3121', N'https://robohash.org/istedictatempora.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (42, N'type03', N'jhanbridge15@npr.org', N'rGQTIuz', N'Jimmie Hanbridge', N'7369 Mandrake Point', N'477-280-7876', N'https://robohash.org/delenitivoluptatemvelit.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (43, N'type03', N'ccaulcott16@ftc.gov', N'rDkhlE2r', N'Christen Caulcott', N'56 Sauthoff Alley', N'168-400-9472', N'https://robohash.org/etremnulla.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (44, N'type03', N'scluer17@com.com', N'bRKoXP', N'Sibeal Cluer', N'0 Vermont Lane', N'598-661-3545', N'https://robohash.org/molestiasetipsa.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (45, N'type03', N'schastel18@stumbleupon.com', N'RTAxq52IbS', N'Spence Chastel', N'182 Westridge Crossing', N'817-356-8832', N'https://robohash.org/mollitiaquiaassumenda.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (46, N'type03', N'fstorch19@xinhuanet.com', N'QNIobJw6', N'Fredi Storch', N'20352 Anhalt Terrace', N'714-973-2281', N'https://robohash.org/sintautdicta.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (47, N'type03', N'kmatussov1a@ft.com', N'ZMe7cJnyNq', N'Kettie Matussov', N'31071 Tony Point', N'245-388-4693', N'https://robohash.org/etfugitadipisci.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (48, N'type03', N'dgrevel1b@barnesandnoble.com', N'jEpirXXnyt1', N'Darb Grevel', N'6395 Declaration Crossing', N'416-794-3849', N'https://robohash.org/eaquesintipsam.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (49, N'type03', N'vahrens1c@google.com.br', N'm5zq2B6uQy', N'Velvet Ahrens', N'81 Garrison Court', N'579-735-7186', N'https://robohash.org/porrovoluptasdolorem.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (50, N'type03', N'lhurley1d@reverbnation.com', N'rpDQGh', N'Laurene Hurley', N'1354 Warner Place', N'199-978-1190', N'https://robohash.org/eavelsint.png?size=50x50&set=set1')
INSERT [dbo].[KhachHang] ([IDKH], [IDType], [Email], [Pass], [TenKH], [DiaChi], [DienThoai], [Avatar]) VALUES (51, N'type03', N'ngoctruc020100@gmail.com', N'082608', N'Trúc', N'123 Hồng Lĩnh', N'0335488465', N'/img/avt-kh1.jpg')
GO
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM0', 0)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM10', 10)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM15', 15)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM20', 20)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM25', 25)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM30', 30)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM35', 35)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM40', 40)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM45', 45)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM50', 50)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM55', 55)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM60', 60)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM65', 65)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM70', 70)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM75', 75)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM80', 80)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM85', 85)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM90', 90)
INSERT [dbo].[KhuyenMai] ([IDKM], [GiaTri]) VALUES (N'KM95', 95)
GO
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'BMW1', N'KM0', N'BMW', N'S1000RR', 949000000.0000, N'/img/S1000RR_01.png', N'/img/S1000RR_02.png', N'/img/S1000RR_03.png', 12, N'BMW S1000RR', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'BMW2', N'KM0', N'BMW', N'R9T-RACER', 659000000.0000, N'/img/R9T_01.png', N'/img/R9T_02.png', N'/img/R9T_03.png', 12, N'BMW R9T Racer 719', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'BMW3', N'KM0', N'BMW', N'R1200-GSA', 659000000.0000, N'/img/R1200GSA_01.png', N'/img/R1200GSA_02.png', N'/img/R1200GSA_03.png', 12, N'BMW R1200 GSA', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'BMW4', N'KM10', N'BMW', N'BMW-HP4', 1100000000.0000, N'/img/hp41.jpg', N'/img/hp41.jpg', N'/img/hp41.jpg', 2, N'đây là mô tả', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'DCT1', N'KM0', N'DCT', N'SUPER-SPORT', 570900000.0000, N'/img/SUPERSPORT_01.png', N'/img/SUPERSPORT_02.png', N'/img/SUPERSPORT_03.png', 12, N'Ducati Super Sport', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'DCT2', N'KM0', N'DCT', N'MONSTER-1200S', 800000000.0000, N'/img/MONSTER_01.png', N'/img/MONSTER_02.png', N'/img/MONSTER_03.png', 12, N'Ducati Monster 1200S', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'DCT3', N'KM0', N'DCT', N'MULTISTRADA-1260S', 743000000.0000, N'/img/MULTISTRADA_01.png', N'/img/MULTISTRADA_02.png', N'/img/MULTISTRADA_03.png', 12, N'Ducati Multistrada 1260S', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'DUCATI04', N'KM10', N'DCT', N'XDIEVAL', 200000000.0000, N'/img/XDiavel_01.png', N'/img/XDiavel_02.png', N'/img/XDiavel_03.png', 12, N'xe ducati xdieval', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'HD1', N'KM0', N'HD', N'CBR-1000RR', 560000000.0000, N'/img/CBR1000RR_01.png', N'/img/CBR1000RR_02.png', N'/img/CBR1000RR_03.png', 12, N'Honda CBR1000RR', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'HD2', N'KM0', N'HD', N'CB1000R', 468000000.0000, N'/img/CB1000R_01.png', N'/img/CB1000R_02.png', N'/img/CB1000R_03.png', 12, N'Honda CB1000R', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'HD3', N'KM0', N'HD', N'REBEL-500', 180000000.0000, N'/img/REBEL500_01.png', N'/img/REBEL500_02.png', N'/img/REBEL500_03.png', 12, N'Honda Rebel 500', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KTM1', N'KM0', N'KTM', N'SUPER-DUKE', 690000000.0000, N'/img/DUKE_01.png', N'/img/DUKE_02.png', N'/img/DUKE_03.png', 12, N'KTM Super Duke 1290', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KTM2', N'KM0', N'KTM', N'SUPER-ADVENTURE', 690000000.0000, N'/img/ADVENTURE_01.PNG', N'/img/ADVENTURE_02.png', N'/img/ADVENTURE_03.png', 12, N'KTM Super Adventure 1290', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KTM3', N'KM0', N'KTM', N'RC8-R', 590000000.0000, N'/img/RC8R_01.png', N'/img/RC8R_02.png', N'/img/RC8R_03.png', 12, N'KTM 1190 RC8R', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KW1', N'KM0', N'KW', N'H2-SX', 899000000.0000, N'/img/H2SX_01.png', N'/img/H2SX_02.png', N'/img/H2SX_03.png', 12, N'Kawasaki H2 SX', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KW2', N'KM0', N'KW', N'VERSYS-1000', 419000000.0000, N'/img/VERSYS_01.png', N'/img/VERSYS_02.png', N'/img/VERSYS_03.png', 12, N'Kawasaki Versys 1000', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'KW3', N'KM0', N'KW', N'Z-1000R', 459000000.0000, N'/img/Z1000RR_01.png', N'/img/Z1000RR_02.png', N'/img/Z1000RR_03.png', 12, N'Kawasaki Z1000R', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'SZ1', N'KM0', N'SZ', N'GSX-S1000', 402000000.0000, N'/img/GSXS1000_01.png', N'/img/GSXS1000_02.png', N'/img/GSXS1000_03.png', 12, N'Suzuki GSX-S1000', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'SZ2', N'KM0', N'SZ', N'GSX-R1000', 436000000.0000, N'/img/GSXR1000_01.png', N'/img/GSXR1000_02.png', N'/img/GSXR1000_03.png', 12, N'Suzuki GSX-R1000', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'SZ3', N'KM0', N'SZ', N'V-STROM1000', 369000000.0000, N'/img/VSTROM_01.png', N'/img/VSTROM_02.png', N'/img/VSTROM_03.png', 12, N'Suzuki V-STROM 1000', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'YM1', N'KM0', N'YM', N'MT-10', 557000000.0000, N'/img/MT10_01.png', N'/img/MT10_02.png', N'/img/MT10_03.png', 12, N'Yamaha MT-10', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'YM2', N'KM0', N'YM', N'XSR900', 320000000.0000, N'/img/XSR900_01.png', N'/img/XSR900_02.png', N'/img/XSR900_03.png', 12, N'Yamaha XSR900', 1)
INSERT [dbo].[MauXe] ([IDMau], [IDKM], [IDHang], [TenXe], [GiaBan], [HinhAnh1], [HinhAnh2], [HinhAnh3], [BaoHanh], [MoTa], [TrangThai]) VALUES (N'YM3', N'KM0', N'YM', N'XZF-R1', 729000000.0000, N'/img/XZFR1_01.png', N'/img/XZFR1_02.png', N'/img/XZFR1_03.png', 12, N'Yamaha XZF-R1', 1)
GO
INSERT [dbo].[NhanVien] ([IDNV], [IDType], [Email], [Pass], [TenNV], [DienThoai], [DiaChi], [CMND], [Avatar], [IDRole]) VALUES (1, N'type01', N'ad.huflit@gmail.com', N'ngoctruc', N'Ngọc Trúc', N'0335488465', N'Địa chỉ', N'CMND', N'/img/avt-kh1.jpg', N'role01')
INSERT [dbo].[NhanVien] ([IDNV], [IDType], [Email], [Pass], [TenNV], [DienThoai], [DiaChi], [CMND], [Avatar], [IDRole]) VALUES (2, N'type02', N'st.minhtam@gmail.com', N'minhtam', N'Minh Tam', N'1111111111', N'Địa chỉ', N'CMND', N'/img/NguyenMinhTam.jpg', N'role02')
INSERT [dbo].[NhanVien] ([IDNV], [IDType], [Email], [Pass], [TenNV], [DienThoai], [DiaChi], [CMND], [Avatar], [IDRole]) VALUES (3, N'type02', N'st.minhtri@gmail.com', N'minhtri', N'Minh Trí', N'1111111111', N'Địa chỉ', N'CMND', N'/img/icon.png', N'role02')
INSERT [dbo].[NhanVien] ([IDNV], [IDType], [Email], [Pass], [TenNV], [DienThoai], [DiaChi], [CMND], [Avatar], [IDRole]) VALUES (4, N'type01', N'st.huflit@gmail.com', N'giahuy', N'Gia Huy ', N'1111111111', N'Dịa chỉ ', N'23123233', N'/img/icon.png', N'role02')
INSERT [dbo].[NhanVien] ([IDNV], [IDType], [Email], [Pass], [TenNV], [DienThoai], [DiaChi], [CMND], [Avatar], [IDRole]) VALUES (5, N'type02', N'st.ngoctruc@gmail.com', N'ngoctruc', N'Ngoc Truc', N'0335488465', N'Địa chỉ', N'CMND', N'/img/avt-kh1.jpg', N'role02')
GO
INSERT [dbo].[Role] ([IDRole], [QLMau], [QLHang], [QLGia], [QLHD], [QLNV], [QLBanHang], [QLDatLich], [DSXe], [DSKH]) VALUES (N'role01', 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Role] ([IDRole], [QLMau], [QLHang], [QLGia], [QLHD], [QLNV], [QLBanHang], [QLDatLich], [DSXe], [DSKH]) VALUES (N'role02', 0, 0, 0, 0, 0, 1, 1, 1, 1)
GO
INSERT [dbo].[TypeAcc] ([IDType], [Name]) VALUES (N'type01', N'admin')
INSERT [dbo].[TypeAcc] ([IDType], [Name]) VALUES (N'type02', N'staff')
INSERT [dbo].[TypeAcc] ([IDType], [Name]) VALUES (N'type03', N'customer')
GO
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'BMW-HP4-1', N'BMW4', 1, N'BMW-HP4')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'BMW-HP4-2', N'BMW4', 1, N'BMW-HP4')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'BMW-HP4-3', N'BMW4', 1, N'BMW-HP4')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'BMW-HP4-4', N'BMW4', 1, N'BMW-HP4')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'BMW-HP4-5', N'BMW4', 1, N'BMW-HP4')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'BMW-HP4-6', N'BMW4', 0, N'BMW-HP4')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'CB1000R-1', N'HD2', 1, N'CB1000R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'CB1000R-2', N'HD2', 1, N'CB1000R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'CB1000R-3', N'HD2', 1, N'CB1000R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'CB1000R-4', N'HD2', 1, N'CB1000R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'CB1000R-5', N'HD2', 1, N'CB1000R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'CBR-1000RR-1', N'HD1', 1, N'CBR-1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'CBR-1000RR-2', N'HD1', 1, N'CBR-1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'CBR-1000RR-3', N'HD1', 1, N'CBR-1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'CBR-1000RR-4', N'HD1', 1, N'CBR-1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'CBR-1000RR-5', N'HD1', 1, N'CBR-1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'GSX-R1000-1', N'SZ2', 1, N'GSX-R1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'GSX-R1000-2', N'SZ2', 1, N'GSX-R1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'GSX-R1000-3', N'SZ2', 1, N'GSX-R1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'GSX-R1000-4', N'SZ2', 1, N'GSX-R1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'GSX-R1000-5', N'SZ2', 1, N'GSX-R1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'GSX-S1000-1', N'SZ1', 1, N'GSX-S1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'GSX-S1000-2', N'SZ1', 1, N'GSX-S1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'GSX-S1000-3', N'SZ1', 1, N'GSX-S1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'GSX-S1000-4', N'SZ1', 1, N'GSX-S1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'GSX-S1000-5', N'SZ1', 1, N'GSX-S1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'H2-SX-1', N'KW1', 1, N'H2-SX')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'H2-SX-2', N'KW1', 1, N'H2-SX')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'H2-SX-3', N'KW1', 1, N'H2-SX')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'H2-SX-4', N'KW1', 1, N'H2-SX')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'H2-SX-5', N'KW1', 1, N'H2-SX')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MONSTER-1200S-1', N'DCT2', 1, N'MONSTER-1200S')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MONSTER-1200S-2', N'DCT2', 1, N'MONSTER-1200S')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MONSTER-1200S-3', N'DCT2', 1, N'MONSTER-1200S')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MONSTER-1200S-4', N'DCT2', 1, N'MONSTER-1200S')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MONSTER-1200S-5', N'DCT2', 1, N'MONSTER-1200S')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MT-10-1', N'YM1', 0, N'MT-10')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MT-10-2', N'YM1', 0, N'MT-10')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MT-10-3', N'YM1', 1, N'MT-10')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MT-10-4', N'YM1', 1, N'MT-10')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MT-10-5', N'YM1', 1, N'MT-10')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MULTISTRADA-1260S-1', N'DCT3', 1, N'MULTISTRADA-1260S')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MULTISTRADA-1260S-2', N'DCT3', 1, N'MULTISTRADA-1260S')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MULTISTRADA-1260S-3', N'DCT3', 0, N'MULTISTRADA-1260S')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MULTISTRADA-1260S-4', N'DCT3', 1, N'MULTISTRADA-1260S')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'MULTISTRADA-1260S-5', N'DCT3', 1, N'MULTISTRADA-1260S')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R1200-GSA-1', N'BMW3', 1, N'R1200-GSA')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R1200-GSA-2', N'BMW3', 1, N'R1200-GSA')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R1200-GSA-3', N'BMW3', 0, N'R1200-GSA')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R1200-GSA-4', N'BMW3', 1, N'R1200-GSA')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R1200-GSA-5', N'BMW3', 1, N'R1200-GSA')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R9T-RACER-1', N'BMW2', 1, N'R9T-RACER')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R9T-RACER-2', N'BMW2', 1, N'R9T-RACER')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R9T-RACER-3', N'BMW2', 0, N'R9T-RACER')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R9T-RACER-4', N'BMW2', 1, N'R9T-RACER')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'R9T-RACER-5', N'BMW2', 0, N'R9T-RACER')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'RC8-R-1', N'KTM3', 1, N'RC8-R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'RC8-R-2', N'KTM3', 1, N'RC8-R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'RC8-R-3', N'KTM3', 1, N'RC8-R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'RC8-R-4', N'KTM3', 1, N'RC8-R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'RC8-R-5', N'KTM3', 1, N'RC8-R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'REBEL-500-1', N'HD3', 1, N'REBEL-500')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'REBEL-500-2', N'HD3', 1, N'REBEL-500')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'REBEL-500-3', N'HD3', 1, N'REBEL-500')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'REBEL-500-4', N'HD3', 1, N'REBEL-500')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'REBEL-500-5', N'HD3', 1, N'REBEL-500')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'S1000RR-1', N'BMW1', 0, N'S1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'S1000RR-2', N'BMW1', 0, N'S1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'S1000RR-3', N'BMW1', 0, N'S1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'S1000RR-4', N'BMW1', 0, N'S1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'S1000RR-5', N'BMW1', 1, N'S1000RR')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-ADVENTURE-1', N'KTM2', 1, N'SUPER-ADVENTURE')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-ADVENTURE-2', N'KTM2', 1, N'SUPER-ADVENTURE')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-ADVENTURE-3', N'KTM2', 1, N'SUPER-ADVENTURE')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-ADVENTURE-4', N'KTM2', 1, N'SUPER-ADVENTURE')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-ADVENTURE-5', N'KTM2', 1, N'SUPER-ADVENTURE')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-DUKE-1', N'KTM1', 1, N'SUPER-DUKE')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-DUKE-2', N'KTM1', 1, N'SUPER-DUKE')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-DUKE-3', N'KTM1', 1, N'SUPER-DUKE')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-DUKE-4', N'KTM1', 1, N'SUPER-DUKE')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-DUKE-5', N'KTM1', 1, N'SUPER-DUKE')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-SPORT-1', N'DCT1', 1, N'SUPER-SPORT')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-SPORT-2', N'DCT1', 1, N'SUPER-SPORT')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-SPORT-3', N'DCT1', 1, N'SUPER-SPORT')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-SPORT-4', N'DCT1', 1, N'SUPER-SPORT')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'SUPER-SPORT-5', N'DCT1', 1, N'SUPER-SPORT')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'V-STROM1000-1', N'SZ3', 1, N'V-STROM1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'V-STROM1000-2', N'SZ3', 1, N'V-STROM1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'V-STROM1000-3', N'SZ3', 1, N'V-STROM1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'V-STROM1000-4', N'SZ3', 1, N'V-STROM1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'V-STROM1000-5', N'SZ3', 1, N'V-STROM1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'VERSYS-1000-1', N'KW2', 1, N'VERSYS-1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'VERSYS-1000-2', N'KW2', 1, N'VERSYS-1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'VERSYS-1000-3', N'KW2', 1, N'VERSYS-1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'VERSYS-1000-4', N'KW2', 1, N'VERSYS-1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'VERSYS-1000-5', N'KW2', 1, N'VERSYS-1000')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XDIEVAL-1', N'DUCATI04', 0, N'XDIEVAL')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XSR900-1', N'YM2', 1, N'XSR900')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XSR900-2', N'YM2', 1, N'XSR900')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XSR900-3', N'YM2', 1, N'XSR900')
GO
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XSR900-4', N'YM2', 1, N'XSR900')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XSR900-5', N'YM2', 1, N'XSR900')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XZF-R1-1', N'YM3', 1, N'XZF-R1')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XZF-R1-2', N'YM3', 1, N'XZF-R1')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XZF-R1-3', N'YM3', 1, N'XZF-R1')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XZF-R1-4', N'YM3', 1, N'XZF-R1')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'XZF-R1-5', N'YM3', 0, N'XZF-R1')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'Z-1000R-1', N'KW2', 1, N'Z-1000R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'Z-1000R-2', N'KW2', 1, N'Z-1000R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'Z-1000R-3', N'KW2', 1, N'Z-1000R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'Z-1000R-4', N'KW2', 1, N'Z-1000R')
INSERT [dbo].[Xe] ([IDXe], [IDMau], [TrangThai], [TenXe]) VALUES (N'Z-1000R-5', N'KW2', 1, N'Z-1000R')
GO
ALTER TABLE [dbo].[ChiTietDG]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDG_KhachHang] FOREIGN KEY([IDKH])
REFERENCES [dbo].[KhachHang] ([IDKH])
GO
ALTER TABLE [dbo].[ChiTietDG] CHECK CONSTRAINT [FK_ChiTietDG_KhachHang]
GO
ALTER TABLE [dbo].[ChiTietDG]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDG_MauXe] FOREIGN KEY([IDMau])
REFERENCES [dbo].[MauXe] ([IDMau])
GO
ALTER TABLE [dbo].[ChiTietDG] CHECK CONSTRAINT [FK_ChiTietDG_MauXe]
GO
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHD_HoaDon] FOREIGN KEY([IDHD])
REFERENCES [dbo].[HoaDon] ([IDHD])
GO
ALTER TABLE [dbo].[ChiTietHD] CHECK CONSTRAINT [FK_ChiTietHD_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHD]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHD_Xe] FOREIGN KEY([IDXe])
REFERENCES [dbo].[Xe] ([IDXe])
GO
ALTER TABLE [dbo].[ChiTietHD] CHECK CONSTRAINT [FK_ChiTietHD_Xe]
GO
ALTER TABLE [dbo].[DatLich]  WITH CHECK ADD  CONSTRAINT [FK_DatLich_KhachHang] FOREIGN KEY([IDKH])
REFERENCES [dbo].[KhachHang] ([IDKH])
GO
ALTER TABLE [dbo].[DatLich] CHECK CONSTRAINT [FK_DatLich_KhachHang]
GO
ALTER TABLE [dbo].[DatLich]  WITH CHECK ADD  CONSTRAINT [FK_DatLich_MauXe] FOREIGN KEY([IDMau])
REFERENCES [dbo].[MauXe] ([IDMau])
GO
ALTER TABLE [dbo].[DatLich] CHECK CONSTRAINT [FK_DatLich_MauXe]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([IDKH])
REFERENCES [dbo].[KhachHang] ([IDKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_Type] FOREIGN KEY([IDType])
REFERENCES [dbo].[TypeAcc] ([IDType])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_Type]
GO
ALTER TABLE [dbo].[MauXe]  WITH CHECK ADD  CONSTRAINT [FK_MauXe_Hang] FOREIGN KEY([IDHang])
REFERENCES [dbo].[Hang] ([IDHang])
GO
ALTER TABLE [dbo].[MauXe] CHECK CONSTRAINT [FK_MauXe_Hang]
GO
ALTER TABLE [dbo].[MauXe]  WITH CHECK ADD  CONSTRAINT [FK_MauXe_KhuyenMai] FOREIGN KEY([IDKM])
REFERENCES [dbo].[KhuyenMai] ([IDKM])
GO
ALTER TABLE [dbo].[MauXe] CHECK CONSTRAINT [FK_MauXe_KhuyenMai]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_NhanVien] FOREIGN KEY([IDRole])
REFERENCES [dbo].[Role] ([IDRole])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_Type] FOREIGN KEY([IDType])
REFERENCES [dbo].[TypeAcc] ([IDType])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_Type]
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD  CONSTRAINT [FK_Xe_MauXe] FOREIGN KEY([IDMau])
REFERENCES [dbo].[MauXe] ([IDMau])
GO
ALTER TABLE [dbo].[Xe] CHECK CONSTRAINT [FK_Xe_MauXe]
GO
