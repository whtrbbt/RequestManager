USE [RQSTS_MNGR]
GO
/****** Object:  Table [dbo].[Responses]    Script Date: 11.06.2020 10:29:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Responses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RequestNum] [varchar](11) NOT NULL,
	[DocLink] [varchar](100) NULL,
	[AuthCode] [varchar](5) NULL,
	[ResponseDate] [datetime] NULL,
	[DownloadDate] [datetime] NOT NULL
) ON [PRIMARY]
GO
