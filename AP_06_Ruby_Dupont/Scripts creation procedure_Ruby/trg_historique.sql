USE [DB_gesAMM]
GO

/****** Object:  Trigger [dbo].[trg_historique]    Script Date: 10/12/2021 13:50:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[trg_historique] 
   ON  [dbo].[ETAPE_NORMEE]
   INSTEAD OF UPDATE
AS 

DECLARE
	@etpNum as int = (SELECT ETP_NUM FROM inserted),

	@etpBefore as varchar(20) = (SELECT ETP_NORME FROM deleted),

	@etpApres as varchar(20) = (SELECT ETP_NORME FROM inserted),

	@etpDateBefore as date = (SELECT ETP_DATE_NORME FROM deleted),

	@etpDateApres as date = (SELECT ETP_DATE_NORME FROM inserted)

BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	insert into dbo.HISTORIQUE(HIS_DATE_UPDATE, HIS_UTILISATEUR, HIS_ETP_NUM, HIS_ETP_NORME_AVANT, HIS_ETP_NORME_APRES, HIS_ETP_DATE_NORME_AVANT,  HIS_ETP_DATE_NORME_APRES)
	values( GETDATE(), 'moi', @etpNum, @etpBefore, @etpApres, @etpDateBefore, @etpDateApres);

	update dbo.ETAPE_NORMEE
	set ETP_NORME = @etpApres,
	ETP_DATE_NORME = @etpDateApres
	where ETP_NUM = @etpNum

END
GO

ALTER TABLE [dbo].[ETAPE_NORMEE] ENABLE TRIGGER [trg_historique]
GO


