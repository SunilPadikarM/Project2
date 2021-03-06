USE [HotelDB]
GO

/****** Object:  Table [dbo].[Rooms]    Script Date: 2018-12-04 5:17:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Rooms](
	[RoomNumber] [int] IDENTITY(1,1) NOT NULL,
	[RoomType] [varchar](50) NOT NULL,
	[Price] [int] NULL,
	[RoomName] [varchar](10) NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[RoomNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Rooms] SET (LOCK_ESCALATION = DISABLE)
GO


