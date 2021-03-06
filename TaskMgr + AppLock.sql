USE [OOP]
GO
/****** Object:  Table [dbo].[Focus]    Script Date: 26-05-19 11:13:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Focus](
	[F_Id] [int] IDENTITY(1,1) NOT NULL,
	[F_Name] [varchar](50) NULL,
	[F_CountLive] [int] NULL,
	[F_CountTimer] [int] NULL,
	[F_Date] [varchar](50) NULL,
	[F_Active] [bit] NULL,
	[F_User] [varchar](50) NULL,
 CONSTRAINT [PK__Focus__2C6EC723B0A359B8] PRIMARY KEY CLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lock]    Script Date: 26-05-19 11:13:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lock](
	[L_Id] [int] IDENTITY(1,1) NOT NULL,
	[L_Name] [varchar](50) NULL,
	[L_Locked] [bit] NULL,
	[L_User] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[L_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Stats]    Script Date: 26-05-19 11:13:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Stats](
	[Stats_ID] [int] IDENTITY(1,1) NOT NULL,
	[Stats_AppName] [varchar](50) NULL,
	[Stats_Time] [int] NULL,
	[Stats_Date] [varchar](50) NULL,
	[Stats_Day] [nchar](10) NULL,
	[Stats_Month] [varchar](50) NULL,
	[Stats_User] [varchar](50) NULL,
 CONSTRAINT [PK__tmp_ms_x__8139888008ECFD8C] PRIMARY KEY CLUSTERED 
(
	[Stats_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 26-05-19 11:13:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserInfo](
	[UIN_Id] [int] IDENTITY(1,1) NOT NULL,
	[UIN_Username] [nvarchar](50) NULL,
	[UIN_Email] [varchar](50) NULL,
	[UIN_Password] [nvarchar](50) NULL,
	[UIN_CPassword] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UIN_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
