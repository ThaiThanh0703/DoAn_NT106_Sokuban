USE CSDLPlayer_DoAn
GO

CREATE PROCEDURE proc_checkacc
@user VARCHAR(20),
@pass VARCHAR(30)
AS
BEGIN
	SELECT * FROM PLAYER 
	WHERE sUsername=@user AND sPassword=@pass

END
