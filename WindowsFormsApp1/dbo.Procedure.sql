CREATE PROCEDURE sp_insert
(
	@Nama        NVARCHAR (50) NOT NULL,
    @Alamat        NVARCHAR (50) NOT NULL,
    @No_Telp       NVARCHAR (12) NOT NULL,
    @Tanggal_Lahir NVARCHAR (10)      NOT NULL,
    @Email         NVARCHAR (50) NOT NULL,
    @K_Identitas   NVARCHAR (20) NOT NULL,
    @N_Identitas   NVARCHAR (12) NOT NULL
)
AS
	insert into dbo.Member values(@Nama, @Alamat, @No_Telp, @Tanggal_Lahir, @Email, @K_Identitas, @N_Identitas)
RETURN