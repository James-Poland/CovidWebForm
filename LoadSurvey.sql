USE [UploadForm]
GO
/****** Object:  StoredProcedure [dbo].[LoadSurvey]    Script Date: 17/01/2022 11:59:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER proc [dbo].[LoadSurvey]
@Username varchar(100),
@Q1 varchar(5),
@Q2 varchar(5),
@Q3 varchar(5),
@Q4 varchar(5),
@Q5 varchar(5),
@Q6 varchar(5)
as 
Begin
Set NoCount on;

Insert into dbo.CovidSurvey
(StaffName,Q1,Q2,Q3,Q4,Q5,Q6)
values 
(@Username,@Q1,@Q2,@Q3,@Q4,@Q5,@Q6)

End

