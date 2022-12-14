USE [DB_Chat]
GO
/****** Object:  Schema [hr]    Script Date: 12/4/2022 5:46:43 PM ******/
CREATE SCHEMA [hr]
GO
/****** Object:  Table [dbo].[C_user]    Script Date: 12/4/2022 5:46:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[C_user](
	[Username] [nvarchar](50) NULL,
	[Fullname] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[CPassword] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 12/4/2022 5:46:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[TaiKhoan] [nvarchar](20) NOT NULL,
	[matkhau] [nvarchar](20) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
