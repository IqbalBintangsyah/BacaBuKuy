CREATE TABLE [dbo].[Member] (
    [Id]            INT           NOT NULL,
    [Nama]          NVARCHAR (50) NOT NULL,
    [Alamat]        NVARCHAR (50) NOT NULL,
    [No_Telp]       NVARCHAR (12) NOT NULL,
    [Tanggal_Lahir] NVARCHAR (10) NOT NULL,
    [Email]         NVARCHAR (50) NOT NULL,
    [K_Identitas]   NVARCHAR (20) NOT NULL,
    [N_Identitas]   NVARCHAR (12) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

