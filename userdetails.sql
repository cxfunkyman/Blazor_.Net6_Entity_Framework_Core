CREATE TABLE [dbo].[userdetails](
    [userid] [int] IDENTITY(1,1) NOT NULL,
    [username] [nvarchar](100) NULL,
    [address] [nvarchar](500) NULL,
    [telephone] [nvarchar](50) NULL,
    [email] [nvarchar](50) NULL,
    CONSTRAINT [PK_userdetails] PRIMARY KEY CLUSTERED
    (
        [userid] ASC
    )
)