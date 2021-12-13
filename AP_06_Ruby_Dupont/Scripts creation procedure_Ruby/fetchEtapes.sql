USE [DB_gesAMM]
GO

/****** Object:  StoredProcedure [dbo].[fetchEtapes]    Script Date: 10/12/2021 13:49:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[fetchEtapes](@code varchar)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select [dbo].[ETAPE].[ETP_LIBELLE], [dbo].[SUBIR].[dateDecision], [dbo].[DECISION].[DCS_LIBELLE]
	from [dbo].[SUBIR]
	inner join [dbo].[ETAPE] on [dbo].[SUBIR].[ETP_NUM] = [dbo].[ETAPE].[ETP_NUM]
	inner join [dbo].[DECISION] on [dbo].[SUBIR].[DCS_ID] = [dbo].[DECISION].[DCS_ID]
	where [dbo].[SUBIR].[MED_DEPOTLEGAL] = @code
END
GO


