CREATE TABLE [dbo].[Product] (
    [ProductID]      BIGINT          IDENTITY (1, 1) NOT NULL,
    [ProductName]    NVARCHAR (50)   NOT NULL,
    [Price]          DECIMAL (15, 2) NOT NULL,
    [Description]   NVARCHAR(MAX)    NULL,
    [CateloryID]     BIGINT          NULL,
    [BrandID]        BIGINT          NULL,
    [Size]         INT              NOT NULL,
    [Image ] NVARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([ProductID] ASC),
    FOREIGN KEY ([CateloryID]) REFERENCES [dbo].[Categories] ([CateloryID]) ON DELETE SET NULL,
    FOREIGN KEY ([BrandID]) REFERENCES [dbo].[Brands] ([BrandID]) ON DELETE SET NULL
);

