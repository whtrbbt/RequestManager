USE [RQSTS_MNGR]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11.06.2020 10:29:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [smallint] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Admin] [bit] NOT NULL
) ON [PRIMARY]
GO
