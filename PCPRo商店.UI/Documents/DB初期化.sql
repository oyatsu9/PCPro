USE [PCPRO商店]
GO
ALTER TABLE [dbo].[WK_受注] DROP CONSTRAINT [FK_WK_受注_M_納品先]
GO
ALTER TABLE [dbo].[WK_受注] DROP CONSTRAINT [FK_WK_受注_M_商品]
GO
ALTER TABLE [dbo].[T_受注] DROP CONSTRAINT [FK_T_受注_M_納品先]
GO
ALTER TABLE [dbo].[T_受注] DROP CONSTRAINT [FK_T_受注_M_商品]
GO
/****** Object:  Table [dbo].[WK_受注]    Script Date: 2017/03/11 18:56:48 ******/
DROP TABLE [dbo].[WK_受注]
GO
/****** Object:  Table [dbo].[T_受注]    Script Date: 2017/03/11 18:56:48 ******/
DROP TABLE [dbo].[T_受注]
GO
/****** Object:  Table [dbo].[M_納品先]    Script Date: 2017/03/11 18:56:48 ******/
DROP TABLE [dbo].[M_納品先]
GO
/****** Object:  Table [dbo].[M_商品]    Script Date: 2017/03/11 18:56:48 ******/
DROP TABLE [dbo].[M_商品]
GO
/****** Object:  Table [dbo].[M_仕入先]    Script Date: 2017/03/11 18:56:48 ******/
DROP TABLE [dbo].[M_仕入先]
GO
/****** Object:  Table [dbo].[M_仕入先]    Script Date: 2017/03/11 18:56:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[M_仕入先](
	[仕入先コード] [char](5) NOT NULL,
	[仕入先名] [nvarchar](50) NOT NULL,
	[住所] [nvarchar](50) NOT NULL,
	[削除フラグ] [bit] NOT NULL,
 CONSTRAINT [PK_M_仕入先] PRIMARY KEY CLUSTERED 
(
	[仕入先コード] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[M_商品]    Script Date: 2017/03/11 18:56:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[M_商品](
	[商品コード] [char](5) NOT NULL,
	[商品名] [nvarchar](50) NOT NULL,
	[単価] [int] NOT NULL,
	[仕入先コード] [char](5) NOT NULL,
	[削除フラグ] [bit] NOT NULL,
 CONSTRAINT [PK_M_商品] PRIMARY KEY CLUSTERED 
(
	[商品コード] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[M_納品先]    Script Date: 2017/03/11 18:56:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[M_納品先](
	[納品先コード] [char](5) NOT NULL,
	[納品先名] [nvarchar](50) NOT NULL,
	[住所] [nvarchar](50) NOT NULL,
	[削除フラグ] [bit] NOT NULL,
 CONSTRAINT [PK_M_納品先] PRIMARY KEY CLUSTERED 
(
	[納品先コード] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_受注]    Script Date: 2017/03/11 18:56:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_受注](
	[受注番号] [int] NOT NULL,
	[受注年月日] [char](10) NOT NULL,
	[納品先コード] [char](5) NOT NULL,
	[商品コード] [char](5) NOT NULL,
	[数量] [int] NOT NULL,
 CONSTRAINT [PK_T_受注] PRIMARY KEY CLUSTERED 
(
	[受注番号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[WK_受注]    Script Date: 2017/03/11 18:56:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[WK_受注](
	[納品先コード] [char](5) NOT NULL,
	[商品コード] [char](5) NOT NULL,
	[数量] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[M_仕入先] ([仕入先コード], [仕入先名], [住所], [削除フラグ]) VALUES (N'S0001', N'群馬農園', N'群馬県', 0)
INSERT [dbo].[M_仕入先] ([仕入先コード], [仕入先名], [住所], [削除フラグ]) VALUES (N'S0002', N'千葉農場', N'千葉県', 0)
INSERT [dbo].[M_仕入先] ([仕入先コード], [仕入先名], [住所], [削除フラグ]) VALUES (N'S0003', N'埼玉農業', N'埼玉県', 0)
INSERT [dbo].[M_仕入先] ([仕入先コード], [仕入先名], [住所], [削除フラグ]) VALUES (N'S0004', N'栃木市場', N'栃木県', 0)
INSERT [dbo].[M_仕入先] ([仕入先コード], [仕入先名], [住所], [削除フラグ]) VALUES (N'S0005', N'北海道農園', N'北海道', 0)
INSERT [dbo].[M_商品] ([商品コード], [商品名], [単価], [仕入先コード], [削除フラグ]) VALUES (N'G0001', N'きゅうり', 88, N'S0003', 1)
INSERT [dbo].[M_商品] ([商品コード], [商品名], [単価], [仕入先コード], [削除フラグ]) VALUES (N'G0002', N'なす', 50, N'S0001', 0)
INSERT [dbo].[M_商品] ([商品コード], [商品名], [単価], [仕入先コード], [削除フラグ]) VALUES (N'G0003', N'なし', 60, N'S0005', 0)
INSERT [dbo].[M_商品] ([商品コード], [商品名], [単価], [仕入先コード], [削除フラグ]) VALUES (N'G0004', N'りんご', 100, N'S0002', 0)
INSERT [dbo].[M_商品] ([商品コード], [商品名], [単価], [仕入先コード], [削除フラグ]) VALUES (N'G0005', N'かぼちゃ', 60, N'S0001', 1)
INSERT [dbo].[M_商品] ([商品コード], [商品名], [単価], [仕入先コード], [削除フラグ]) VALUES (N'G0006', N'しいたけ', 20, N'S0004', 0)
INSERT [dbo].[M_商品] ([商品コード], [商品名], [単価], [仕入先コード], [削除フラグ]) VALUES (N'G0007', N'すいか', 32, N'S0002', 0)
INSERT [dbo].[M_商品] ([商品コード], [商品名], [単価], [仕入先コード], [削除フラグ]) VALUES (N'G0008', N'えのき', 60, N'S0005', 0)
INSERT [dbo].[M_商品] ([商品コード], [商品名], [単価], [仕入先コード], [削除フラグ]) VALUES (N'G0009', N'だいこん', 30, N'S0001', 0)
INSERT [dbo].[M_商品] ([商品コード], [商品名], [単価], [仕入先コード], [削除フラグ]) VALUES (N'G0010', N'松茸', 60, N'S0004', 1)
INSERT [dbo].[M_納品先] ([納品先コード], [納品先名], [住所], [削除フラグ]) VALUES (N'N0001', N'六本木レストラン', N'東京都', 0)
INSERT [dbo].[M_納品先] ([納品先コード], [納品先名], [住所], [削除フラグ]) VALUES (N'N0002', N'横浜中華店', N'神奈川県', 0)
INSERT [dbo].[M_納品先] ([納品先コード], [納品先名], [住所], [削除フラグ]) VALUES (N'N0003', N'所沢飯店', N'埼玉県', 0)
INSERT [dbo].[M_納品先] ([納品先コード], [納品先名], [住所], [削除フラグ]) VALUES (N'N0004', N'デニーズ', N'東京都', 0)
INSERT [dbo].[M_納品先] ([納品先コード], [納品先名], [住所], [削除フラグ]) VALUES (N'N0005', N'浦安インドカレー', N'千葉県', 0)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (1, N'20051120  ', N'N0004', N'G0003', 200)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (2, N'20051225  ', N'N0005', N'G0009', 80)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (3, N'20060123  ', N'N0001', N'G0008', 100)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (4, N'20060123  ', N'N0001', N'G0010', 30)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (5, N'20060303  ', N'N0003', N'G0001', 80)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (6, N'20060303  ', N'N0003', N'G0003', 100)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (7, N'20060505  ', N'N0002', N'G0006', 150)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (8, N'20060530  ', N'N0004', N'G0002', 10)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (9, N'20060613  ', N'N0001', N'G0010', 30)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (10, N'20060707  ', N'N0005', N'G0004', 100)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (11, N'20061022  ', N'N0002', N'G0002', 10)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (12, N'20061022  ', N'N0002', N'G0003', 10)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (13, N'20061022  ', N'N0003', N'G0001', 10)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (14, N'20061022  ', N'N0003', N'G0002', 550)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (15, N'20061027  ', N'N0002', N'G0003', 440)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (16, N'20061027  ', N'N0002', N'G0004', 440)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (17, N'20061104  ', N'N0002', N'G0005', 10)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (18, N'20061104  ', N'N0002', N'G0007', 50)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (19, N'20061118  ', N'N0003', N'G0003', 450)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (20, N'20071103  ', N'N0001', N'G0006', 20)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (21, N'20071103  ', N'N0001', N'G0009', 10)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (22, N'20071103  ', N'N0001', N'G0010', 5)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (23, N'20100403  ', N'N0001', N'G0006', 3)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (24, N'20100403  ', N'N0001', N'G0006', 3)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (25, N'20110604  ', N'N0001', N'G0003', 10)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (26, N'20110604  ', N'N0001', N'G0004', 20)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (27, N'20110604  ', N'N0001', N'G0007', 2)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (28, N'20110611  ', N'N0001', N'G0004', 60)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (29, N'20160409  ', N'N0001', N'G0002', 10)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (30, N'20160409  ', N'N0001', N'G0005', 10)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (31, N'20160409  ', N'N0001', N'G0009', 10)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (32, N'20160507  ', N'N0001', N'G0004', 10)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (33, N'20160507  ', N'N0001', N'G0008', 10)
INSERT [dbo].[T_受注] ([受注番号], [受注年月日], [納品先コード], [商品コード], [数量]) VALUES (34, N'20160507  ', N'N0001', N'G0009', 10)
INSERT [dbo].[WK_受注] ([納品先コード], [商品コード], [数量]) VALUES (N'N0001', N'G0002', 12)
INSERT [dbo].[WK_受注] ([納品先コード], [商品コード], [数量]) VALUES (N'N0001', N'G0002', 0)
ALTER TABLE [dbo].[T_受注]  WITH CHECK ADD  CONSTRAINT [FK_T_受注_M_商品] FOREIGN KEY([商品コード])
REFERENCES [dbo].[M_商品] ([商品コード])
GO
ALTER TABLE [dbo].[T_受注] CHECK CONSTRAINT [FK_T_受注_M_商品]
GO
ALTER TABLE [dbo].[T_受注]  WITH CHECK ADD  CONSTRAINT [FK_T_受注_M_納品先] FOREIGN KEY([納品先コード])
REFERENCES [dbo].[M_納品先] ([納品先コード])
GO
ALTER TABLE [dbo].[T_受注] CHECK CONSTRAINT [FK_T_受注_M_納品先]
GO
ALTER TABLE [dbo].[WK_受注]  WITH CHECK ADD  CONSTRAINT [FK_WK_受注_M_商品] FOREIGN KEY([商品コード])
REFERENCES [dbo].[M_商品] ([商品コード])
GO
ALTER TABLE [dbo].[WK_受注] CHECK CONSTRAINT [FK_WK_受注_M_商品]
GO
ALTER TABLE [dbo].[WK_受注]  WITH CHECK ADD  CONSTRAINT [FK_WK_受注_M_納品先] FOREIGN KEY([納品先コード])
REFERENCES [dbo].[M_納品先] ([納品先コード])
GO
ALTER TABLE [dbo].[WK_受注] CHECK CONSTRAINT [FK_WK_受注_M_納品先]
GO
