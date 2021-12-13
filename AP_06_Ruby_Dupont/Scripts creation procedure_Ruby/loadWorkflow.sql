USE [DB_gesAMM]
GO

/****** Object:  StoredProcedure [dbo].[loadWorkflow]    Script Date: 10/12/2021 13:50:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[loadWorkflow] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select med_depotLegal, med_nomCommercial from [DB_gesAMM].[dbo].[MEDICAMENT]
END
GO


