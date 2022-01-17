

CREATE TABLE [dbo].[CovidSurvey](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StaffName] [varchar](100) NULL,
	[Q1] [varchar](5) NULL,
	[Q2] [varchar](5) NULL,
	[Q3] [varchar](5) NULL,
	[Q4] [varchar](5) NULL,
	[Q5] [varchar](5) NULL,
	[Q6] [varchar](5) NULL,
	[Loadtime] [datetime] NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CovidSurvey] ADD  DEFAULT (getdate()) FOR [Loadtime]
GO


