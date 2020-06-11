USE [RQSTS_MNGR]
GO
/****** Object:  Table [dbo].[Requests]    Script Date: 11.06.2020 10:29:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Requests](
	[ID] [int] NOT NULL,
	[CadNum] [varchar](25) NOT NULL,
	[ReqNum] [varchar](50) NULL,
	[CreateDate] [datetime] NULL,
	[UserID] [int] NOT NULL
) ON [PRIMARY]
GO
