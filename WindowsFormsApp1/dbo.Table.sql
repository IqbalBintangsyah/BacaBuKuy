CREATE TABLE [dbo].[Pinjaman]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Nama] NVARCHAR (50) NOT NULL,
	[Kode_Buku] NVARCHAR (16) NOT NULL,
	[Nama_Buku] NVARCHAR (50) NOT NULL,
	[Batas_Waktu] DATETIME NOT NULL,
	[Denda] INT,
)
