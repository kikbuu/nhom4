USE [master]
GO
/****** Object:  Database [ShopBanGiayPro]    Script Date: 10/12/2015 05:49:38 AM ******/
CREATE DATABASE [ShopBanGiayPro]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShopBanGiayPro', FILENAME = N'C:\code\Microsoft SQL Server Data\ShopBanGiayPro.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ShopBanGiayPro_log', FILENAME = N'C:\code\Microsoft SQL Server Data\ShopBanGiayPro_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ShopBanGiayPro] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShopBanGiayPro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShopBanGiayPro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShopBanGiayPro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShopBanGiayPro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShopBanGiayPro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShopBanGiayPro] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShopBanGiayPro] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ShopBanGiayPro] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ShopBanGiayPro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShopBanGiayPro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShopBanGiayPro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShopBanGiayPro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShopBanGiayPro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShopBanGiayPro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShopBanGiayPro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShopBanGiayPro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShopBanGiayPro] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ShopBanGiayPro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShopBanGiayPro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShopBanGiayPro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShopBanGiayPro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShopBanGiayPro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShopBanGiayPro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShopBanGiayPro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShopBanGiayPro] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ShopBanGiayPro] SET  MULTI_USER 
GO
ALTER DATABASE [ShopBanGiayPro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShopBanGiayPro] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShopBanGiayPro] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShopBanGiayPro] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [ShopBanGiayPro]
GO
/****** Object:  Table [dbo].[ct_hoadon]    Script Date: 10/12/2015 05:49:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ct_hoadon](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[mahd] [char](8) NOT NULL,
	[masp] [char](8) NOT NULL,
	[soluong] [int] NULL,
	[thanhtien] [float] NULL,
 CONSTRAINT [PK_ct_hoadon] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ct_phieunhap]    Script Date: 10/12/2015 05:49:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ct_phieunhap](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[mapn] [char](8) NOT NULL,
	[masp] [char](8) NOT NULL,
	[soluong] [int] NULL,
	[gia] [float] NULL,
	[thanhtien] [float] NULL,
 CONSTRAINT [PK_ct_phieunhap] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ct_sanpham]    Script Date: 10/12/2015 05:49:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ct_sanpham](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[masp] [char](8) NOT NULL,
	[xuatxu] [nvarchar](max) NULL,
	[mausac] [nvarchar](max) NULL,
	[kieudang] [nvarchar](max) NULL,
	[chatlieu] [nvarchar](max) NULL,
	[mota] [nvarchar](max) NULL,
 CONSTRAINT [PK_ct_sanpham] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 10/12/2015 05:49:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[hoadon](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[mahd] [char](8) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[ngaymua] [date] NULL,
	[hoanthanh] [bit] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_hoadon] PRIMARY KEY CLUSTERED 
(
	[mahd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[loai]    Script Date: 10/12/2015 05:49:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[loai](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[maloai] [char](8) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_loai] PRIMARY KEY CLUSTERED 
(
	[maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[nhasx]    Script Date: 10/12/2015 05:49:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nhasx](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[mansx] [char](8) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[diachi] [nvarchar](max) NULL,
	[hinh] [nvarchar](max) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_nhasx] PRIMARY KEY CLUSTERED 
(
	[mansx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[phieunhap]    Script Date: 10/12/2015 05:49:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[phieunhap](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[mapn] [char](8) NOT NULL,
	[ngaynhap] [date] NULL,
	[trangthai] [bit] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_phieunhap] PRIMARY KEY CLUSTERED 
(
	[mapn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sanpham]    Script Date: 10/12/2015 05:49:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sanpham](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[masp] [char](8) NOT NULL,
	[maloai] [char](8) NOT NULL,
	[mansx] [char](8) NOT NULL,
	[tensp] [nvarchar](50) NULL,
	[soluong] [int] NULL,
	[gia] [float] NULL,
	[ngaynhap] [date] NULL,
	[hinh] [nvarchar](max) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_sanpham] PRIMARY KEY CLUSTERED 
(
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tonkho]    Script Date: 10/12/2015 05:49:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tonkho](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[masp] [char](8) NOT NULL,
	[ngaycapnhat] [date] NULL,
	[soluongton] [int] NULL,
 CONSTRAINT [PK_tonkho] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[user]    Script Date: 10/12/2015 05:49:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[gioitinhnam] [bit] NULL,
	[ngaysinh] [date] NULL,
	[diachi] [nvarchar](max) NULL,
	[sdt] [char](11) NULL,
	[hinh] [nvarchar](max) NULL,
	[email] [varchar](50) NULL,
	[quyenhang] [varchar](50) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ct_hoadon] ON 

INSERT [dbo].[ct_hoadon] ([id], [mahd], [masp], [soluong], [thanhtien]) VALUES (1070, N'HD000001', N'SP000009', 2, 16000000)
INSERT [dbo].[ct_hoadon] ([id], [mahd], [masp], [soluong], [thanhtien]) VALUES (1071, N'HD000001', N'SP000008', 3, 27000000)
INSERT [dbo].[ct_hoadon] ([id], [mahd], [masp], [soluong], [thanhtien]) VALUES (1072, N'ML000002', N'SP000006', 4, 3600000)
INSERT [dbo].[ct_hoadon] ([id], [mahd], [masp], [soluong], [thanhtien]) VALUES (1073, N'ML000002', N'SP000007', 5, 7500000)
INSERT [dbo].[ct_hoadon] ([id], [mahd], [masp], [soluong], [thanhtien]) VALUES (2070, N'ML000003', N'SP000009', 1, 8000000)
SET IDENTITY_INSERT [dbo].[ct_hoadon] OFF
SET IDENTITY_INSERT [dbo].[ct_phieunhap] ON 

INSERT [dbo].[ct_phieunhap] ([id], [mapn], [masp], [soluong], [gia], [thanhtien]) VALUES (1012, N'PN000001', N'SP000001', 9, 2000000, 18000000)
INSERT [dbo].[ct_phieunhap] ([id], [mapn], [masp], [soluong], [gia], [thanhtien]) VALUES (1013, N'PN000001', N'SP000003', 8, 1500000, 12000000)
INSERT [dbo].[ct_phieunhap] ([id], [mapn], [masp], [soluong], [gia], [thanhtien]) VALUES (1014, N'PN000002', N'SP000006', 8, 2300000, 18400000)
SET IDENTITY_INSERT [dbo].[ct_phieunhap] OFF
SET IDENTITY_INSERT [dbo].[ct_sanpham] ON 

INSERT [dbo].[ct_sanpham] ([id], [masp], [xuatxu], [mausac], [kieudang], [chatlieu], [mota]) VALUES (1038, N'SP000001', N'Việt Nam', N'Thể thao, mạnh mẽ, .....', N'Vàng, Xanh, Đỏ, Đen, ...', N'Vải, da, ...', N'Hàng xuất khẩu của Việt Nam và chính hãng Adidas nên rất chất lượng. Khẳng định đẳng cấp của vận động viên thể thao chuyên nghiệp...........')
INSERT [dbo].[ct_sanpham] ([id], [masp], [xuatxu], [mausac], [kieudang], [chatlieu], [mota]) VALUES (1039, N'SP000002', N'Đài Loan', N'Đỏ, xanh, ...', N'Thể thao', N'Da bò', N'Giày chính hãng Nike')
INSERT [dbo].[ct_sanpham] ([id], [masp], [xuatxu], [mausac], [kieudang], [chatlieu], [mota]) VALUES (1040, N'SP000003', N'Việt Nam', N'Vàng, Xanh, Đỏ, Đen, ...', N'Thể thao, mạnh mẽ, .....', N'Vải, da, ...', N'Hàng xuất khẩu của Việt Nam và chính hãng Adidas nên rất chất lượng. Khẳng định đẳng cấp của vận động viên thể thao chuyên nghiệp...........')
INSERT [dbo].[ct_sanpham] ([id], [masp], [xuatxu], [mausac], [kieudang], [chatlieu], [mota]) VALUES (1041, N'SP000004', N'Việt Nam', N'Vàng, Xanh, Đỏ, Đen, ...', N'Thể thao, mạnh mẽ, .....', N'Vải, da, ...', N'Hàng xuất khẩu của Việt Nam và chính hãng Adidas nên rất chất lượng. Khẳng định đẳng cấp của vận động viên thể thao chuyên nghiệp...........')
INSERT [dbo].[ct_sanpham] ([id], [masp], [xuatxu], [mausac], [kieudang], [chatlieu], [mota]) VALUES (1042, N'SP000006', N'Việt Nam', N'Vàng, Xanh, Đỏ, Đen, ...', N'Thể thao, mạnh mẽ, .....', N'Vải, da, ...', N'Hàng xuất khẩu của Việt Nam và chính hãng Adidas nên rất chất lượng. Khẳng định đẳng cấp của vận động viên thể thao chuyên nghiệp...........')
INSERT [dbo].[ct_sanpham] ([id], [masp], [xuatxu], [mausac], [kieudang], [chatlieu], [mota]) VALUES (1044, N'SP000007', N'Việt Nam', N'Vàng, Xanh, Đỏ, Đen, ...', N'Thể thao, mạnh mẽ, .....', N'Vải, da, ...', N'Hàng xuất khẩu của Việt Nam và chính hãng Adidas nên rất chất lượng. Khẳng định đẳng cấp của vận động viên thể thao chuyên nghiệp...........')
INSERT [dbo].[ct_sanpham] ([id], [masp], [xuatxu], [mausac], [kieudang], [chatlieu], [mota]) VALUES (1045, N'SP000008', N'Việt Nam', N'Vàng, Xanh, Đỏ, Đen, ...', N'Thể thao, mạnh mẽ, .....', N'Vải, da, ...', N'Hàng xuất khẩu của Việt Nam và chính hãng Adidas nên rất chất lượng. Khẳng định đẳng cấp của vận động viên thể thao chuyên nghiệp...........')
INSERT [dbo].[ct_sanpham] ([id], [masp], [xuatxu], [mausac], [kieudang], [chatlieu], [mota]) VALUES (1046, N'SP000009', N'Việt Nam', N'Vàng, Xanh, Đỏ, Đen, ...', N'Thể thao, mạnh mẽ, .....', N'Vải, da, ...', N'Hàng xuất khẩu của Việt Nam và chính hãng Adidas nên rất chất lượng. Khẳng định đẳng cấp của vận động viên thể thao chuyên nghiệp...........')
SET IDENTITY_INSERT [dbo].[ct_sanpham] OFF
SET IDENTITY_INSERT [dbo].[hoadon] ON 

INSERT [dbo].[hoadon] ([id], [mahd], [username], [ngaymua], [hoanthanh], [Active]) VALUES (54, N'HD000001', N'user', CAST(0x3D390B00 AS Date), 1, 1)
INSERT [dbo].[hoadon] ([id], [mahd], [username], [ngaymua], [hoanthanh], [Active]) VALUES (55, N'ML000002', N'user', CAST(0x3D390B00 AS Date), 0, 1)
INSERT [dbo].[hoadon] ([id], [mahd], [username], [ngaymua], [hoanthanh], [Active]) VALUES (1054, N'ML000003', N'vi', CAST(0xC23A0B00 AS Date), 0, 1)
SET IDENTITY_INSERT [dbo].[hoadon] OFF
SET IDENTITY_INSERT [dbo].[loai] ON 

INSERT [dbo].[loai] ([id], [maloai], [ten], [Active]) VALUES (1, N'ML000001', N'Giày Nike', 1)
INSERT [dbo].[loai] ([id], [maloai], [ten], [Active]) VALUES (2, N'ML000002', N'Giày Adidas', 1)
INSERT [dbo].[loai] ([id], [maloai], [ten], [Active]) VALUES (3, N'ML000003', N'Giày Rebook', 1)
INSERT [dbo].[loai] ([id], [maloai], [ten], [Active]) VALUES (4, N'ML000004', N'Giày Kappa', 1)
INSERT [dbo].[loai] ([id], [maloai], [ten], [Active]) VALUES (5, N'ML000005', N'Giày Convert', 1)
INSERT [dbo].[loai] ([id], [maloai], [ten], [Active]) VALUES (10, N'ML000006', N'Giày Lười', 1)
INSERT [dbo].[loai] ([id], [maloai], [ten], [Active]) VALUES (11, N'ML000007', N'Giày Mọi', 1)
INSERT [dbo].[loai] ([id], [maloai], [ten], [Active]) VALUES (12, N'ML000008', N'Giày Casual', 0)
INSERT [dbo].[loai] ([id], [maloai], [ten], [Active]) VALUES (13, N'ML000009', N'Giày Không Tên', 0)
SET IDENTITY_INSERT [dbo].[loai] OFF
SET IDENTITY_INSERT [dbo].[nhasx] ON 

INSERT [dbo].[nhasx] ([id], [mansx], [ten], [diachi], [hinh], [Active]) VALUES (1, N'SX000001', N'CTy Sông Vân NB', N'273 An Dương Vương, P3, Q5', N'\Images\NhaSanXuat\5_12_1304651802_12_Burberry-10.jpg', 1)
INSERT [dbo].[nhasx] ([id], [mansx], [ten], [diachi], [hinh], [Active]) VALUES (2, N'SX000002', N'CTy Hiep Shoes', N'19 Thành Thái, Q10', N'\Images\NhaSanXuat\1953a2818a741fee209e5fefcb5c5e97.jpg', 1)
INSERT [dbo].[nhasx] ([id], [mansx], [ten], [diachi], [hinh], [Active]) VALUES (3, N'SX000003', N'Cty Phú Hưng', N'25 Hồng Bàng, Q5', N'\Images\NhaSanXuat\4-giay-to-can-thiet-trong-qua-trinh-van-chuyen.jpg', 1)
INSERT [dbo].[nhasx] ([id], [mansx], [ten], [diachi], [hinh], [Active]) VALUES (4, N'SX000004', N'Cty Thái Sơn', N'98 Lũy Bán Bích, Q3', N'\Images\NhaSanXuat\10043_1_large_10_2012_9c697c12f46402acca622609fa36ca88_gif.jpg', 1)
INSERT [dbo].[nhasx] ([id], [mansx], [ten], [diachi], [hinh], [Active]) VALUES (5, N'SX000005', N'CTy Metronic', N'999 Nguyễn Trãi, Q1', N'\Images\NhaSanXuat\1342920328-nu-doanh-nhan-20125.jpg', 1)
INSERT [dbo].[nhasx] ([id], [mansx], [ten], [diachi], [hinh], [Active]) VALUES (6, N'SX000006', N'CTy QN', N'273 An Dương Vương, P3, Q5', N'\Images\NhaSanXuat\1355823913_1342686852_1.jpg', 1)
INSERT [dbo].[nhasx] ([id], [mansx], [ten], [diachi], [hinh], [Active]) VALUES (7, N'SX000007', N'CTy T&D', N'273 An Dương Vương, P3, Q5', N'/ckfinder/userfiles/images/User/690f220a-0c0a-426c-a3f7-f4de24137613.png', 0)
SET IDENTITY_INSERT [dbo].[nhasx] OFF
SET IDENTITY_INSERT [dbo].[phieunhap] ON 

INSERT [dbo].[phieunhap] ([id], [mapn], [ngaynhap], [trangthai], [Active]) VALUES (1, N'PN000001', CAST(0x1E390B00 AS Date), 1, 1)
INSERT [dbo].[phieunhap] ([id], [mapn], [ngaynhap], [trangthai], [Active]) VALUES (2, N'PN000002', CAST(0x3D390B00 AS Date), 0, 1)
SET IDENTITY_INSERT [dbo].[phieunhap] OFF
SET IDENTITY_INSERT [dbo].[sanpham] ON 

INSERT [dbo].[sanpham] ([id], [masp], [maloai], [mansx], [tensp], [soluong], [gia], [ngaynhap], [hinh], [Active]) VALUES (1037, N'SP000001', N'ML000002', N'SX000002', N'Adidas XK2014', 100, 2200000, CAST(0x3C390B00 AS Date), N'\Images\SanPham\The thao 19.jpg', 1)
INSERT [dbo].[sanpham] ([id], [masp], [maloai], [mansx], [tensp], [soluong], [gia], [ngaynhap], [hinh], [Active]) VALUES (1038, N'SP000002', N'ML000001', N'SX000003', N'Nike VN', 100, 1600000, CAST(0x3C390B00 AS Date), N'\Images\SanPham\The thao 3.jpg', 1)
INSERT [dbo].[sanpham] ([id], [masp], [maloai], [mansx], [tensp], [soluong], [gia], [ngaynhap], [hinh], [Active]) VALUES (1039, N'SP000003', N'ML000002', N'SX000004', N'Adidas QN Pro', 100, 2200000, CAST(0x3C390B00 AS Date), N'\Images\SanPham\The thao 4.jpg', 1)
INSERT [dbo].[sanpham] ([id], [masp], [maloai], [mansx], [tensp], [soluong], [gia], [ngaynhap], [hinh], [Active]) VALUES (1040, N'SP000004', N'ML000002', N'SX000006', N'Adidas Pro2015', 100, 3000000, CAST(0x3C390B00 AS Date), N'\Images\SanPham\The thao 11.jpg', 1)
INSERT [dbo].[sanpham] ([id], [masp], [maloai], [mansx], [tensp], [soluong], [gia], [ngaynhap], [hinh], [Active]) VALUES (1041, N'SP000005', N'ML000001', N'SX000006', N'Nike Pro2015', 100, 2000000, CAST(0x3C390B00 AS Date), N'\Images\SanPham\The thao 17.jpg', 1)
INSERT [dbo].[sanpham] ([id], [masp], [maloai], [mansx], [tensp], [soluong], [gia], [ngaynhap], [hinh], [Active]) VALUES (1042, N'SP000006', N'ML000004', N'SX000003', N'Kappa Pro 2014', 100, 900000, CAST(0x3D390B00 AS Date), N'\Images\SanPham\The thao 8.jpg', 1)
INSERT [dbo].[sanpham] ([id], [masp], [maloai], [mansx], [tensp], [soluong], [gia], [ngaynhap], [hinh], [Active]) VALUES (1043, N'SP000007', N'ML000003', N'SX000006', N'Rebook Pro 2014', 100, 1500000, CAST(0x3D390B00 AS Date), N'\Images\SanPham\The thao 5.jpg', 1)
INSERT [dbo].[sanpham] ([id], [masp], [maloai], [mansx], [tensp], [soluong], [gia], [ngaynhap], [hinh], [Active]) VALUES (1044, N'SP000008', N'ML000005', N'SX000005', N'Convert Pro 2014', 97, 9000000, CAST(0x3D390B00 AS Date), N'\Images\SanPham\The thao 20.jpg', 1)
INSERT [dbo].[sanpham] ([id], [masp], [maloai], [mansx], [tensp], [soluong], [gia], [ngaynhap], [hinh], [Active]) VALUES (1045, N'SP000009', N'ML000004', N'SX000002', N'Kappa Pro 2013', 98, 8000000, CAST(0x3D390B00 AS Date), N'\Images\SanPham\The thao 7.jpg', 1)
INSERT [dbo].[sanpham] ([id], [masp], [maloai], [mansx], [tensp], [soluong], [gia], [ngaynhap], [hinh], [Active]) VALUES (1046, N'SP000010', N'ML000001', N'SX000002', N'Adidas XK2014', 0, 2200000, CAST(0x3C390B00 AS Date), N'\Images\SanPham\The thao 19.jpg', 0)
INSERT [dbo].[sanpham] ([id], [masp], [maloai], [mansx], [tensp], [soluong], [gia], [ngaynhap], [hinh], [Active]) VALUES (1047, N'SP000011', N'ML000001', N'SX000002', N'Adidas XK2014', 0, 2200000, CAST(0x3C390B00 AS Date), N'\Images\SanPham\The thao 19.jpg', 0)
SET IDENTITY_INSERT [dbo].[sanpham] OFF
SET IDENTITY_INSERT [dbo].[tonkho] ON 

INSERT [dbo].[tonkho] ([id], [masp], [ngaycapnhat], [soluongton]) VALUES (1016, N'SP000001', CAST(0x12390B00 AS Date), 100)
INSERT [dbo].[tonkho] ([id], [masp], [ngaycapnhat], [soluongton]) VALUES (1017, N'SP000002', CAST(0x12390B00 AS Date), 100)
INSERT [dbo].[tonkho] ([id], [masp], [ngaycapnhat], [soluongton]) VALUES (1018, N'SP000003', CAST(0x12390B00 AS Date), 100)
INSERT [dbo].[tonkho] ([id], [masp], [ngaycapnhat], [soluongton]) VALUES (1019, N'SP000004', CAST(0x12390B00 AS Date), 100)
INSERT [dbo].[tonkho] ([id], [masp], [ngaycapnhat], [soluongton]) VALUES (1020, N'SP000005', CAST(0x12390B00 AS Date), 100)
INSERT [dbo].[tonkho] ([id], [masp], [ngaycapnhat], [soluongton]) VALUES (1021, N'SP000006', CAST(0x12390B00 AS Date), 100)
INSERT [dbo].[tonkho] ([id], [masp], [ngaycapnhat], [soluongton]) VALUES (1022, N'SP000007', CAST(0x12390B00 AS Date), 100)
INSERT [dbo].[tonkho] ([id], [masp], [ngaycapnhat], [soluongton]) VALUES (1024, N'SP000008', CAST(0x12390B00 AS Date), 100)
INSERT [dbo].[tonkho] ([id], [masp], [ngaycapnhat], [soluongton]) VALUES (1025, N'SP000009', CAST(0x12390B00 AS Date), 100)
INSERT [dbo].[tonkho] ([id], [masp], [ngaycapnhat], [soluongton]) VALUES (1034, N'SP000001', CAST(0x1E390B00 AS Date), 109)
INSERT [dbo].[tonkho] ([id], [masp], [ngaycapnhat], [soluongton]) VALUES (1035, N'SP000003', CAST(0x1E390B00 AS Date), 108)
INSERT [dbo].[tonkho] ([id], [masp], [ngaycapnhat], [soluongton]) VALUES (1038, N'SP000009', CAST(0x3D390B00 AS Date), 98)
INSERT [dbo].[tonkho] ([id], [masp], [ngaycapnhat], [soluongton]) VALUES (1039, N'SP000008', CAST(0x3D390B00 AS Date), 97)
SET IDENTITY_INSERT [dbo].[tonkho] OFF
SET IDENTITY_INSERT [dbo].[user] ON 

INSERT [dbo].[user] ([id], [username], [password], [hoten], [gioitinhnam], [ngaysinh], [diachi], [sdt], [hinh], [email], [quyenhang], [Active]) VALUES (1, N'admin', N'123456', N'Phan Thiên Phúc', 1, CAST(0x801A0B00 AS Date), N'18A Nguyễn Kim, P12, Q5', N'0976656454 ', N'/ckfinder/userfiles/images/User/WMP118af8ed-835a-449b-a247-9e01bce04f07.jpg', N'dangcapgiayhieu@gmail.com', N'admin', 1)
INSERT [dbo].[user] ([id], [username], [password], [hoten], [gioitinhnam], [ngaysinh], [diachi], [sdt], [hinh], [email], [quyenhang], [Active]) VALUES (8, N'khai', N'123456', N'hoangkhai', 1, CAST(0xCA1A0B00 AS Date), N'P1, Q5', N'0976523145 ', N'/ckfinder/userfiles/images/User/WMP1b7c9fb8-cfc0-4761-ae29-1c9b4adfe456.jpg', N'hoabgkimkhai510@gmail.com', N'user', 1)
INSERT [dbo].[user] ([id], [username], [password], [hoten], [gioitinhnam], [ngaysinh], [diachi], [sdt], [hinh], [email], [quyenhang], [Active]) VALUES (2, N'phuc', N'123456', N'Phan Thiên Phúc', 1, CAST(0x801A0B00 AS Date), N'18A Nguyễn Kim, P12, Q5', N'0976656454 ', N'/ckfinder/userfiles/images/User/WMP118af8ed-835a-449b-a247-9e01bce04f07.jpg', N'phanthienphuc@gmail.com', N'user', 1)
INSERT [dbo].[user] ([id], [username], [password], [hoten], [gioitinhnam], [ngaysinh], [diachi], [sdt], [hinh], [email], [quyenhang], [Active]) VALUES (4, N'si', N'123456', N'Huỳnh Lưu Phú Sĩ', 1, CAST(0xEF1A0B00 AS Date), N'Bình Định', N'0976123456 ', N'/ckfinder/userfiles/images/User/WMP08feefa5-5ccb-47ff-aab5-a0ccc3193a7c.jpg', N'phusi.huynhluu@gmail.com', N'user', 1)
INSERT [dbo].[user] ([id], [username], [password], [hoten], [gioitinhnam], [ngaysinh], [diachi], [sdt], [hinh], [email], [quyenhang], [Active]) VALUES (3, N'user', N'123456', N'Nguyễn Văn A', 1, CAST(0x2D1D0B00 AS Date), N'18A Nguyễn Kim, P12, Q5', N'0976656454 ', N'/ckfinder/userfiles/images/User/WMP13c5a2cb-4fa4-4e30-9ff7-672fc513ec5d.jpg', N'nguyenvana@gmail.com', N'user', 1)
INSERT [dbo].[user] ([id], [username], [password], [hoten], [gioitinhnam], [ngaysinh], [diachi], [sdt], [hinh], [email], [quyenhang], [Active]) VALUES (5, N'user2', N'123456', N'Nguyễn Văn B', 1, CAST(0xCA1F0B00 AS Date), N'18A Nguyễn Kim, P12, Q5', N'0976656454 ', N'/ckfinder/userfiles/images/User/WMP120b4fde-afc8-4436-a68b-8dbd2e17f528.jpg', N'nguyenvanb@gmail.com', N'user', 0)
INSERT [dbo].[user] ([id], [username], [password], [hoten], [gioitinhnam], [ngaysinh], [diachi], [sdt], [hinh], [email], [quyenhang], [Active]) VALUES (9, N'vi', N'123456', N'Nguyen Vi', 0, CAST(0x041C0B00 AS Date), N'123 P2', N'           ', N'/ckfinder/userfiles/images/User/WMP6a0b391c-35a2-4d48-be6e-092771501e80.jpg', N'', N'user', 1)
SET IDENTITY_INSERT [dbo].[user] OFF
ALTER TABLE [dbo].[ct_hoadon]  WITH CHECK ADD  CONSTRAINT [FK_ct_hoadon_hoadon] FOREIGN KEY([mahd])
REFERENCES [dbo].[hoadon] ([mahd])
GO
ALTER TABLE [dbo].[ct_hoadon] CHECK CONSTRAINT [FK_ct_hoadon_hoadon]
GO
ALTER TABLE [dbo].[ct_hoadon]  WITH CHECK ADD  CONSTRAINT [FK_ct_hoadon_sanpham] FOREIGN KEY([masp])
REFERENCES [dbo].[sanpham] ([masp])
GO
ALTER TABLE [dbo].[ct_hoadon] CHECK CONSTRAINT [FK_ct_hoadon_sanpham]
GO
ALTER TABLE [dbo].[ct_phieunhap]  WITH CHECK ADD  CONSTRAINT [FK_ct_phieunhap_phieunhap] FOREIGN KEY([mapn])
REFERENCES [dbo].[phieunhap] ([mapn])
GO
ALTER TABLE [dbo].[ct_phieunhap] CHECK CONSTRAINT [FK_ct_phieunhap_phieunhap]
GO
ALTER TABLE [dbo].[ct_phieunhap]  WITH CHECK ADD  CONSTRAINT [FK_ct_phieunhap_sanpham] FOREIGN KEY([masp])
REFERENCES [dbo].[sanpham] ([masp])
GO
ALTER TABLE [dbo].[ct_phieunhap] CHECK CONSTRAINT [FK_ct_phieunhap_sanpham]
GO
ALTER TABLE [dbo].[ct_sanpham]  WITH CHECK ADD  CONSTRAINT [FK_ct_sanpham_sanpham] FOREIGN KEY([masp])
REFERENCES [dbo].[sanpham] ([masp])
GO
ALTER TABLE [dbo].[ct_sanpham] CHECK CONSTRAINT [FK_ct_sanpham_sanpham]
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_user] FOREIGN KEY([username])
REFERENCES [dbo].[user] ([username])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_user]
GO
ALTER TABLE [dbo].[sanpham]  WITH CHECK ADD  CONSTRAINT [FK_sanpham_loai] FOREIGN KEY([maloai])
REFERENCES [dbo].[loai] ([maloai])
GO
ALTER TABLE [dbo].[sanpham] CHECK CONSTRAINT [FK_sanpham_loai]
GO
ALTER TABLE [dbo].[sanpham]  WITH CHECK ADD  CONSTRAINT [FK_sanpham_nhasx] FOREIGN KEY([mansx])
REFERENCES [dbo].[nhasx] ([mansx])
GO
ALTER TABLE [dbo].[sanpham] CHECK CONSTRAINT [FK_sanpham_nhasx]
GO
ALTER TABLE [dbo].[tonkho]  WITH CHECK ADD  CONSTRAINT [FK_tonkho_sanpham] FOREIGN KEY([masp])
REFERENCES [dbo].[sanpham] ([masp])
GO
ALTER TABLE [dbo].[tonkho] CHECK CONSTRAINT [FK_tonkho_sanpham]
GO
USE [master]
GO
ALTER DATABASE [ShopBanGiayPro] SET  READ_WRITE 
GO
