USE [DB_gesAMM]
GO

/****** Object:  StoredProcedure [dbo].[prc_AllMedicament]    Script Date: 10/12/2021 14:32:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_AllMedicament]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [DB_gesAMM].[dbo].[MEDICAMENT]
END
GO


