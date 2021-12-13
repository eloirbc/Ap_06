USE [DB_gesAMM]
GO

/****** Object:  StoredProcedure [dbo].[prc_creationSubir]    Script Date: 10/12/2021 14:33:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_creationSubir] (@med_depotlegal varchar(250), @etp_num int,@dcs_id int,@dateDecision date)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.SUBIR
	VALUES (@med_depotlegal, @etp_num, @dcs_id, @dateDecision)
END
GO


