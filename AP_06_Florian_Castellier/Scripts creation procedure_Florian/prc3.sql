USE [DB_gesAMM]
GO

/****** Object:  StoredProcedure [dbo].[prc_ChangeEtapeMedicament]    Script Date: 10/12/2021 14:32:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_ChangeEtapeMedicament] (@unDepot varchar(255), @unNumEtape int, @uneDecision int, @uneDate DATETIME)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE dbo.SUBIR
	SET ETP_NUM = @unNumEtape, DCS_ID = @uneDecision, dateDecision = @uneDate
	WHERE MED_DEPOTLEGAL = @unDepot
END
GO


