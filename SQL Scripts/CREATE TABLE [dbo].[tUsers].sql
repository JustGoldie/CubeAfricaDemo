USE [CubeAfricaDemo]
GO

/****** Object:  Table [dbo].[tUsers]    Script Date: 2018/06/13 10:06:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tUsers](
	[pkUserId] [varchar](40) NOT NULL,
	[sFirstName] [varchar](100) NOT NULL,
	[sLastName] [varchar](100) NOT NULL,
	[sCompany] [varchar](100) NOT NULL,
	[sEmailAddress] [varchar](100) NOT NULL,
	[sPassword] [varchar](250) NOT NULL,
	[sCellNo] [varchar](20) NOT NULL,
	[sWorkNo] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tUsers] PRIMARY KEY CLUSTERED 
(
	[pkUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tUsers] ADD  DEFAULT (newid()) FOR [pkUserId]
GO


