USE [DB_gesAMM]
GO

/****** Object:  StoredProcedure [dbo].[loadEtapesNormees]    Script Date: 10/12/2021 13:49:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[loadEtapesNormees]
AS
BEGIN
	select dbo.ETAPE_NORMEE.ETP_NUM, dbo.ETAPE.ETP_LIBELLE, dbo.ETAPE_NORMEE.ETP_NORME, dbo.ETAPE_NORMEE.ETP_DATE_NORME
	from dbo.ETAPE_NORMEE
	inner join dbo.ETAPE on ETAPE.ETP_NUM = ETAPE_NORMEE.ETP_NUM
	order by ETAPE_NORMEE.ETP_NUM
END
GO


