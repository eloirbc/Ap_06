USE [DB_gesAMM]
GO

/****** Object:  StoredProcedure [dbo].[prc_MedicamentParFamille]    Script Date: 10/12/2021 14:34:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_MedicamentParFamille]
@CodeFamille varchar(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM [DB_gesAMM].[dbo].[MEDICAMENT]
	WHERE [DB_gesAMM].[dbo].[MEDICAMENT].[FAM_CODE] = @CodeFamille
END
GO


