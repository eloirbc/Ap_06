USE [DB_gesAMM]
GO

/****** Object:  StoredProcedure [dbo].[prc_getEtape]    Script Date: 10/12/2021 14:33:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[prc_getEtape] (@numEtape int)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM [DB_gesAMM].[dbo].[ETAPE]
	WHERE [DB_gesAMM].[dbo].[ETAPE].[ETP_NUM] = @numEtape
END
GO


