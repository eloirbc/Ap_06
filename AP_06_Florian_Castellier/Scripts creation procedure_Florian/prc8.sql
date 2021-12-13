USE [DB_gesAMM]
GO

/****** Object:  StoredProcedure [dbo].[prc_getSubir]    Script Date: 10/12/2021 14:33:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_getSubir] (@depotLegal varchar(255))
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM dbo.SUBIR
	WHERE MED_DEPOTLEGAL = @depotLegal
END
GO


