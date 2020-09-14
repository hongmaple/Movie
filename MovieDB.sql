USE [movieDB]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 2020/9/15 0:08:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ClientId] [varchar](50) NULL,
	[ClientPwd] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movie]    Script Date: 2020/9/15 0:08:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie](
	[TicketId] [nvarchar](30) NOT NULL,
	[MovieName] [nvarchar](30) NOT NULL,
	[HouseID] [int] NOT NULL,
	[StartTime] [datetime] NULL,
	[EndTime] [datetime] NULL,
	[TicketPrice] [nvarchar](30) NULL,
	[number] [int] NULL,
 CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED 
(
	[TicketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovieHouse]    Script Date: 2020/9/15 0:08:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieHouse](
	[HouseID] [int] IDENTITY(1,1) NOT NULL,
	[MovieHouse] [nchar](10) NULL,
 CONSTRAINT [PK_MovieHouse] PRIMARY KEY CLUSTERED 
(
	[HouseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderInfo]    Script Date: 2020/9/15 0:08:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderInfo](
	[OrderId] [int] NOT NULL,
	[TicketId] [nvarchar](30) NOT NULL,
	[number] [int] NOT NULL,
	[State] [nchar](10) NULL,
 CONSTRAINT [PK_OrderInfo] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'手机号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Client', @level2type=N'COLUMN',@level2name=N'ClientId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Client', @level2type=N'COLUMN',@level2name=N'ClientPwd'
GO
