﻿CREATE PROCEDURE [dbo].[CSP_DeleteTache]
	@Id int
AS
BEGIN
	DELETE FROM Tache WHERE Id = @Id
	RETURN 0
END
