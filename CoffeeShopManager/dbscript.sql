/****** Object:  UserDefinedTableType [dbo].[Varchar10CollectionType]    Script Date: 12/4/2020 1:15:05 AM ******/
CREATE TYPE [dbo].[Varchar10CollectionType] AS TABLE(
	[VarcharValue] [varchar](10) NULL
)
GO
/****** Object:  Table [dbo].[CUSTOMERS]    Script Date: 12/4/2020 1:15:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUSTOMERS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[EmailAddress] [nvarchar](60) NOT NULL,
	[Birthdate] [smalldatetime] NULL,
	[ShopId] [int] NULL,
 CONSTRAINT [PK__CUSTOMER__3214EC07040DFF64] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_CUSTOMERS_EMAIL_SHOPID] UNIQUE NONCLUSTERED 
(
	[EmailAddress] ASC,
	[ShopId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLOYEES]    Script Date: 12/4/2020 1:15:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLOYEES](
	[Id] [varchar](15) NOT NULL,
	[Address] [nvarchar](60) NOT NULL,
	[DateOfJoin] [smalldatetime] NOT NULL,
	[Salary] [money] NOT NULL,
	[ManagerId] [varchar](15) NOT NULL,
	[ShopId] [int] NOT NULL,
 CONSTRAINT [PK_EMPLOYEES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[ShopId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MANAGERS]    Script Date: 12/4/2020 1:15:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MANAGERS](
	[Id] [varchar](15) NOT NULL,
	[ShopId] [int] NOT NULL,
 CONSTRAINT [PK_MANAGERS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[ShopId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTS]    Script Date: 12/4/2020 1:15:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTS](
	[Id] [varchar](15) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Type] [varchar](20) NOT NULL,
	[Image] [varbinary](max) NULL,
	[Price] [money] NOT NULL,
	[Details] [nvarchar](100) NULL,
	[ShopId] [int] NOT NULL,
 CONSTRAINT [PK_PRODUCTS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[ShopId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RECEIPT_DETAILS]    Script Date: 12/4/2020 1:15:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RECEIPT_DETAILS](
	[ReceiptId] [int] NOT NULL,
	[ProductId] [varchar](15) NOT NULL,
	[ShopId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[TotalPrice] [money] NULL,
 CONSTRAINT [PK_RECID_PROID_SHOPID] PRIMARY KEY CLUSTERED 
(
	[ReceiptId] ASC,
	[ProductId] ASC,
	[ShopId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RECEIPTS]    Script Date: 12/4/2020 1:15:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RECEIPTS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[DateOfPayment] [smalldatetime] NULL,
	[Total] [money] NULL,
	[Details] [nvarchar](100) NULL,
	[ShopId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SHOP]    Script Date: 12/4/2020 1:15:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SHOP](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ShopName] [nvarchar](60) NULL,
	[ShopAddress] [nvarchar](100) NULL,
	[PhoneNumber] [varchar](20) NULL,
	[ShopAuthCode] [varchar](64) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STOCK_ITEMS]    Script Date: 12/4/2020 1:15:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STOCK_ITEMS](
	[Id] [int] NOT NULL,
	[ItemName] [varchar](20) NULL,
	[SupplierId] [varchar](10) NULL,
	[ShopId] [int] NOT NULL,
 CONSTRAINT [PK_STOCKID_SHOPID] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[ShopId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_ITEMNAME_EACH_SHOP] UNIQUE NONCLUSTERED 
(
	[ItemName] ASC,
	[SupplierId] ASC,
	[ShopId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STOCK_ITEMS_FOR_PRODUCTS]    Script Date: 12/4/2020 1:15:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STOCK_ITEMS_FOR_PRODUCTS](
	[ProductId] [varchar](15) NOT NULL,
	[ItemId] [int] NOT NULL,
	[ShopId] [int] NOT NULL,
 CONSTRAINT [PK_STOCKID_PROID_SHOPID] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC,
	[ItemId] ASC,
	[ShopId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUPPLIERS]    Script Date: 12/4/2020 1:15:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUPPLIERS](
	[Id] [varchar](10) NOT NULL,
	[SupplierName] [varchar](20) NULL,
	[ShopId] [int] NOT NULL,
	[EmailAddress] [nvarchar](50) NULL,
	[PhoneNumber] [varchar](20) NULL,
 CONSTRAINT [PK_SUPPLIERS_ID_SHOPID] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[ShopId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_SUPPLIER_EMAIL] UNIQUE NONCLUSTERED 
(
	[EmailAddress] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sysdiagrams]    Script Date: 12/4/2020 1:15:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sysdiagrams](
	[name] [sysname] NOT NULL,
	[principal_id] [int] NOT NULL,
	[diagram_id] [int] IDENTITY(1,1) NOT NULL,
	[version] [int] NULL,
	[definition] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[diagram_id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_principal_name] UNIQUE NONCLUSTERED 
(
	[principal_id] ASC,
	[name] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLE_SITTING]    Script Date: 12/4/2020 1:15:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLE_SITTING](
	[ReceiptId] [int] NOT NULL,
	[TableId] [int] NOT NULL,
	[ShopId] [int] NOT NULL,
	[Sitting] [bit] NULL,
 CONSTRAINT [PK_SITTING] PRIMARY KEY CLUSTERED 
(
	[ReceiptId] ASC,
	[TableId] ASC,
	[ShopId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLES]    Script Date: 12/4/2020 1:15:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLES](
	[Id] [int] NOT NULL,
	[TableStatus] [varchar](25) NULL,
	[ShopId] [int] NOT NULL,
 CONSTRAINT [PK_TABLE] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[ShopId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 12/4/2020 1:15:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](30) NULL,
	[Password] [varchar](64) NOT NULL,
 CONSTRAINT [PK__USERS__3214EC07D8C19AF0] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_USERNAME] UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WORKERS]    Script Date: 12/4/2020 1:15:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WORKERS](
	[Id] [varchar](15) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Gender] [varchar](6) NOT NULL,
	[Position] [varchar](20) NOT NULL,
	[PhoneNumber] [varchar](20) NOT NULL,
	[EmailAddress] [nvarchar](50) NULL,
	[Birthdate] [smalldatetime] NOT NULL,
	[AccountId] [int] NULL,
	[Image] [varbinary](max) NULL,
	[ShopId] [int] NOT NULL,
 CONSTRAINT [PK_WORKERS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[ShopId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__WORKERS__349DA5A7450EDE4B] UNIQUE NONCLUSTERED 
(
	[AccountId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_EMAIL_IN_EACH_SHOP] UNIQUE NONCLUSTERED 
(
	[EmailAddress] ASC,
	[ShopId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[CUSTOMERS]  WITH CHECK ADD FOREIGN KEY([ShopId])
REFERENCES [dbo].[SHOP] ([Id])
GO
ALTER TABLE [dbo].[EMPLOYEES]  WITH CHECK ADD  CONSTRAINT [FK_EMPLOYEES_MANAGERID] FOREIGN KEY([ManagerId], [ShopId])
REFERENCES [dbo].[WORKERS] ([Id], [ShopId])
GO
ALTER TABLE [dbo].[EMPLOYEES] CHECK CONSTRAINT [FK_EMPLOYEES_MANAGERID]
GO
ALTER TABLE [dbo].[EMPLOYEES]  WITH CHECK ADD  CONSTRAINT [FK_EMPLOYEES_WORKERS] FOREIGN KEY([Id], [ShopId])
REFERENCES [dbo].[WORKERS] ([Id], [ShopId])
GO
ALTER TABLE [dbo].[EMPLOYEES] CHECK CONSTRAINT [FK_EMPLOYEES_WORKERS]
GO
ALTER TABLE [dbo].[MANAGERS]  WITH CHECK ADD  CONSTRAINT [FK_MANAGERS_WORKERS] FOREIGN KEY([Id], [ShopId])
REFERENCES [dbo].[WORKERS] ([Id], [ShopId])
GO
ALTER TABLE [dbo].[MANAGERS] CHECK CONSTRAINT [FK_MANAGERS_WORKERS]
GO
ALTER TABLE [dbo].[PRODUCTS]  WITH CHECK ADD  CONSTRAINT [FK_SHOPID] FOREIGN KEY([ShopId])
REFERENCES [dbo].[SHOP] ([Id])
GO
ALTER TABLE [dbo].[PRODUCTS] CHECK CONSTRAINT [FK_SHOPID]
GO
ALTER TABLE [dbo].[RECEIPTS]  WITH CHECK ADD FOREIGN KEY([ShopId])
REFERENCES [dbo].[SHOP] ([Id])
GO
ALTER TABLE [dbo].[RECEIPTS]  WITH CHECK ADD  CONSTRAINT [FK_RECEIPT_CUSTOMER] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[CUSTOMERS] ([Id])
GO
ALTER TABLE [dbo].[RECEIPTS] CHECK CONSTRAINT [FK_RECEIPT_CUSTOMER]
GO
ALTER TABLE [dbo].[STOCK_ITEMS]  WITH CHECK ADD  CONSTRAINT [FK_SupplierId] FOREIGN KEY([SupplierId], [ShopId])
REFERENCES [dbo].[SUPPLIERS] ([Id], [ShopId])
GO
ALTER TABLE [dbo].[STOCK_ITEMS] CHECK CONSTRAINT [FK_SupplierId]
GO
ALTER TABLE [dbo].[STOCK_ITEMS_FOR_PRODUCTS]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCTID] FOREIGN KEY([ProductId], [ShopId])
REFERENCES [dbo].[PRODUCTS] ([Id], [ShopId])
GO
ALTER TABLE [dbo].[STOCK_ITEMS_FOR_PRODUCTS] CHECK CONSTRAINT [FK_PRODUCTID]
GO
ALTER TABLE [dbo].[STOCK_ITEMS_FOR_PRODUCTS]  WITH CHECK ADD  CONSTRAINT [FK_STOCKID] FOREIGN KEY([ItemId], [ShopId])
REFERENCES [dbo].[STOCK_ITEMS] ([Id], [ShopId])
GO
ALTER TABLE [dbo].[STOCK_ITEMS_FOR_PRODUCTS] CHECK CONSTRAINT [FK_STOCKID]
GO
ALTER TABLE [dbo].[TABLE_SITTING]  WITH CHECK ADD FOREIGN KEY([ReceiptId])
REFERENCES [dbo].[RECEIPTS] ([Id])
GO
ALTER TABLE [dbo].[TABLE_SITTING]  WITH CHECK ADD  CONSTRAINT [FK_TABLE_SHOP] FOREIGN KEY([TableId], [ShopId])
REFERENCES [dbo].[TABLES] ([Id], [ShopId])
GO
ALTER TABLE [dbo].[TABLE_SITTING] CHECK CONSTRAINT [FK_TABLE_SHOP]
GO
ALTER TABLE [dbo].[TABLES]  WITH CHECK ADD FOREIGN KEY([ShopId])
REFERENCES [dbo].[SHOP] ([Id])
GO
ALTER TABLE [dbo].[WORKERS]  WITH CHECK ADD  CONSTRAINT [FK__WORKERS__ShopId__395884C4] FOREIGN KEY([ShopId])
REFERENCES [dbo].[SHOP] ([Id])
GO
ALTER TABLE [dbo].[WORKERS] CHECK CONSTRAINT [FK__WORKERS__ShopId__395884C4]
GO
ALTER TABLE [dbo].[WORKERS]  WITH CHECK ADD  CONSTRAINT [FK_ACCOUNTID] FOREIGN KEY([AccountId])
REFERENCES [dbo].[USERS] ([Id])
GO
ALTER TABLE [dbo].[WORKERS] CHECK CONSTRAINT [FK_ACCOUNTID]
GO
ALTER TABLE [dbo].[TABLES]  WITH CHECK ADD  CONSTRAINT [TABLE_STATUS] CHECK  (([TableStatus]='Available' OR [TableStatus]='Occupied' OR [TableStatus]='Unavailable'))
GO
ALTER TABLE [dbo].[TABLES] CHECK CONSTRAINT [TABLE_STATUS]
GO
ALTER TABLE [dbo].[WORKERS]  WITH CHECK ADD  CONSTRAINT [GENDER_WORKERS] CHECK  (([Gender]='Female' OR [Gender]='Male'))
GO
ALTER TABLE [dbo].[WORKERS] CHECK CONSTRAINT [GENDER_WORKERS]
GO
/****** Object:  Trigger [dbo].[IOINS_Stock_Items]    Script Date: 12/4/2020 1:15:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[IOINS_Stock_Items]
   ON  [dbo].[STOCK_ITEMS]
   INSTEAD OF INSERT
AS 
BEGIN
  SET NOCOUNT ON;

  -- Acquire the lock so that no one else can generate a key at the same time.
  -- If the transaction fails then the lock will automatically be released.
  -- If the acquisition takes longer than 15 seconds an error is raised.
  DECLARE @res INT;
  EXEC @res = sp_getapplock @Resource = 'IOINS_Stock_Items', 
    @LockMode = 'Exclusive', @LockOwner = 'Transaction', @LockTimeout = '15000',
    @DbPrincipal = 'public'
  IF (@res < 0)
  BEGIN
    RAISERROR('Unable to acquire lock to update Products table.', 16, 1);
  END

  -- Work out what the current maximum Ids are for each tenant that is being
  -- inserted in this operation.
  DECLARE @baseId TABLE(BaseId int, ShopId int);
  INSERT INTO @baseId
  SELECT max(ISNULL(S.Id, 0)) AS BaseId, I.ShopId
  FROM INSERTED I
  LEFT OUTER JOIN STOCK_ITEMS S
  ON I.ShopId = S.ShopId
  GROUP BY I.ShopId

  -- The replacement insert operation
  INSERT INTO STOCK_ITEMS
  SELECT 
    ROW_NUMBER() OVER(PARTITION BY i.ShopId ORDER BY i.ShopId) + b.BaseId 
      AS Id, I.ItemName, I.SupplierId, I.ShopId
    Name
  FROM inserted I
  INNER JOIN @baseId B ON B.ShopId = I.ShopId

  -- Release the lock.
  EXEC @res = sp_releaseapplock @Resource = 'IOINS_Stock_Items', 
    @DbPrincipal = 'public', @LockOwner = 'Transaction'
END
GO
ALTER TABLE [dbo].[STOCK_ITEMS] ENABLE TRIGGER [IOINS_Stock_Items]
GO
EXEC sys.sp_addextendedproperty @name=N'microsoft_database_tools_support', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'sysdiagrams'
GO
