USE [DB_gesAMM]
GO

/****** Object:  StoredProcedure [dbo].[updateEtapeNormee]    Script Date: 10/12/2021 13:50:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updateEtapeNormee] (@norme varchar(20), @dateNorme date, @numEtape int)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE dbo.ETAPE_NORMEE SET ETP_NORME = @norme, ETP_DATE_NORME = @dateNorme WHERE dbo.ETAPE_NORMEE.ETP_NUM = @numEtape;
END
GO


