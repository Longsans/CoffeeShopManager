/****** Object:  Database [ONEDB]    Script Date: 12/28/2020 1:56:28 AM ******/
CREATE DATABASE [ONEDB]
GO

USE [ONEDB]
GO
/****** Object:  UserDefinedTableType [dbo].[Varchar10CollectionType]    Script Date: 12/28/2020 1:51:27 AM ******/
CREATE TYPE [dbo].[Varchar10CollectionType] AS TABLE(
	[VarcharValue] [varchar](10) NULL
)
GO
/****** Object:  UserDefinedFunction [dbo].[GetAllValidDates]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetAllValidDates] (@month tinyint, @year smallint, @shopId int)
	RETURNS @dates TABLE (DateValue date)
BEGIN
	DECLARE @currentdate date = GETDATE()
	DECLARE @creationdate date = (
		select CreationDate
		from SHOP
		where Id = @shopId
	)

	INSERT INTO @dates
	select DateId
	from CALENDAR
	where MonthValue = @month AND YearValue = @year

	DELETE FROM @dates
	WHERE DateValue > @currentdate OR DateValue < @creationdate

	--IF @month = CAST(month(@currentdate) AS tinyint) AND @year = CAST(year(@currentdate) AS smallint)
	--BEGIN
	--	DELETE FROM @dates 
	--	WHERE day(DateValue) > day(@currentdate)
	--END

	--IF @month = CAST(month(@creationdate) AS tinyint) AND @year = CAST(year(@creationdate) AS smallint)
	--BEGIN
	--	DELETE FROM @dates
	--	WHERE day(DateValue) < day(@creationdate)
	--END
	RETURN
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetAllValidMonths]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetAllValidMonths](@year smallint, @shopId int)
	RETURNS @months TABLE(MonthValue tinyint, YearValue smallint)
BEGIN
	DECLARE @currentdate date = GETDATE()
	DECLARE @creationdate date = (
		select CreationDate
		from SHOP
		where Id = @shopId
	)
	DECLARE @monthcount tinyint = 1

	IF (@year >= year(@creationdate) AND @year <= year(@currentdate))
	BEGIN
		WHILE @monthcount <= 12
		BEGIN
			INSERT INTO @months
			VALUES (@monthcount, @year)
			SET @monthcount = @monthcount + 1;
		END
	END

	IF year(@creationdate) = @year
	BEGIN
		DELETE FROM @months
		WHERE MonthValue < month(@creationdate)
	END
	IF year(@currentdate) = @year
	BEGIN
		DELETE FROM @months
		WHERE MonthValue > month(@currentdate)
	END
	RETURN
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetAllValidQuarters]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetAllValidQuarters](@year smallint, @shopId int)
	RETURNS @quarters TABLE(QuarterValue tinyint, YearValue smallint)
BEGIN
	DECLARE @currentdate date = GETDATE()
	DECLARE @creationdate date = (
		select CreationDate
		from SHOP
		where Id = @shopId
	)

	IF (@year >= year(@creationdate) AND @year <= year(@currentdate))
	BEGIN
		INSERT INTO @quarters 
		VALUES (1, @year), (2, @year), (3, @year), (4, @year)
	END

	IF (@year = year(@currentdate))
	BEGIN
		DELETE FROM @quarters
		WHERE QuarterValue > datepart(quarter, @currentdate)
	END

	IF (@year = year(@creationdate))
	BEGIN
		DELETE FROM @quarters
		WHERE QuarterValue < datepart(quarter, @creationdate)
	END
	RETURN
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetAllValidYears]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetAllValidYears](@shopId int)
	RETURNS @years TABLE(YearValue smallint)
BEGIN
	DECLARE @currentdate date = GETDATE()
	DECLARE @creationdate date = (
		select CreationDate
		from SHOP
		where Id = @shopId
	)
	DECLARE @startyear smallint = year(@currentdate)

	WHILE @startyear <= year(@currentdate)
	BEGIN
		INSERT INTO @years
		VALUES (@startyear)
		SET @startyear = @startyear + 1;
	END
	RETURN
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetAnnualIncome]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetAnnualIncome](@shopId int)
	RETURNS @income TABLE(YearVal smallint, Income money)
BEGIN
	DECLARE @years AS TABLE(
		YearValue smallint
	)

	INSERT INTO @years
	select * 
	from GetAllValidYears(@shopId)

	INSERT INTO @income
	select y.YearValue YearVal, sum(ISNULL(Total, 0)) Income
	from @years y
	left join (
		select *
		from RECEIPTS
		where ShopId = @shopId
	) r
	on y.YearValue = CAST(year(r.DateOfPayment) AS smallint)
	group by y.YearValue
	order by y.YearValue
	RETURN
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetDailyIncome]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetDailyIncome] (@month tinyint, @year smallint, @shopId int)
	RETURNS @income TABLE (DateVal varchar(5), Income money)
BEGIN
	DECLARE @dates AS TABLE (
		DateValue date
	)

	INSERT INTO @dates
	select *
	from GetAllValidDates(@month, @year, @shopId)

	INSERT INTO @income
	select CAST(day(d.DateValue) AS varchar(2)) + '/' + CAST(month(d.DateValue) AS varchar(2)) DateVal, sum(ISNULL(Total, 0)) Income
	from @dates d
	left join (
		select *
		from RECEIPTS
		where ShopId = @shopId
	) r
	on d.DateValue = CAST(r.DateOfPayment AS date)
	group by d.DateValue
	order by d.DateValue asc
	RETURN
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetLastNDays]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetLastNDays](@daynum smallint, @shopId int)
	RETURNS @days TABLE(DateValue date)
BEGIN
	DECLARE @currentdate date = GETDATE()
	DECLARE @creationdate date = (
		select CreationDate
		from SHOP
		where Id = @shopId
	)
	DECLARE @startdate date = @currentdate
	
	WHILE @startdate >= DATEADD(day, -@daynum + 1, @currentdate)
	BEGIN
		IF (@startdate >= @creationdate)
		BEGIN
			INSERT INTO @days
			VALUES (@startdate)
			SET @startdate = DATEADD(day, -1, @startdate)
		END
		ELSE
			BREAK;
	END
	RETURN
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetLastNDaysIncome]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetLastNDaysIncome](@daynum smallint, @shopId int)
	RETURNS @income TABLE(DateVal varchar(5), Income money)
BEGIN
	DECLARE @days AS TABLE (
		DateValue date
	)

	INSERT INTO @days
	select *
	from GetLastNDays(@daynum, @shopId)

	INSERT INTO @income
	select CAST(day(d.DateValue) AS varchar(2)) + '/' + CAST(month(d.DateValue) AS varchar(2)), sum(ISNULL(Total, 0)) Income
	from @days d
	left join (
		select *
		from RECEIPTS
		where ShopId = @shopId
	) r
	on d.DateValue = CAST(r.DateOfPayment AS date)
	group by d.DateValue
	order by d.DateValue asc
	RETURN
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetMonthlyIncome]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetMonthlyIncome](@year smallint, @shopId int)
	RETURNS @income TABLE (MonthVal varchar(8), Income money)
BEGIN
	DECLARE @months AS TABLE(
		MonthValue tinyint,
		YearValue smallint
	)

	INSERT INTO @months
	select * 
	from GetAllValidMonths(@year, @shopId)

	INSERT INTO @income
	select CAST(m.MonthValue AS varchar(8)) + '/' + CAST(@year AS varchar(8)) MonthVal, sum(ISNULL(Total, 0)) Income
	from @months m
	left join (
		select *
		from RECEIPTS
		where ShopId = @shopId
	) r
	on m.MonthValue = CAST(month(r.DateOfPayment) AS tinyint)
	and m.YearValue = CAST(year(r.DateOfPayment) AS smallint)
	group by m.MonthValue
	order by m.MonthValue asc
	RETURN
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetQuarterlyIncome]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetQuarterlyIncome](@year smallint, @shopId int)
	RETURNS @income TABLE(QuarterVal tinyint, Income money)
BEGIN
	DECLARE @quarters AS TABLE (
		QuarterValue tinyint,
		YearValue smallint
	)

	INSERT INTO @quarters
	select *
	from GetAllValidQuarters(@year, @shopId)

	INSERT INTO @income
	select q.QuarterValue QuarterVal, sum(ISNULL(Total, 0)) Income
	from @quarters q
	left join (
		select *
		from RECEIPTS
		where ShopId = @shopId
	) r
	on q.QuarterValue = datepart(quarter, r.DateOfPayment)
	and q.YearValue = year(r.DateOfPayment)
	group by q.QuarterValue
	order by q.QuarterValue asc
	RETURN
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetTotalAllTimeProductSales]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetTotalAllTimeProductSales](@shopId int)
	RETURNS @sales TABLE(ProductId varchar(15), ProductName varchar(50), Sales int)
BEGIN
	DECLARE @years AS TABLE (
		YearValue smallint
	)

	INSERT INTO @years
	select * 
	from GetAllValidYears(@shopId)

	INSERT INTO @sales
	select p.Id, p.[Name], sum(ISNULL(Quantity, 0))
	from PRODUCTS p
	left join (RECEIPT_DETAILS rd
	inner join RECEIPTS r
	on rd.ReceiptId = r.Id and rd.ShopId = r.ShopId
	inner join @years y
	on year(r.DateOfPayment) = y.YearValue)
	on p.Id = rd.ProductId and p.ShopId = rd.ShopId
	where p.ShopId = @shopId
	group by p.Id, p.[Name]
	RETURN
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetTotalAnnualProductSales]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetTotalAnnualProductSales](@year smallint, @shopId int)
	RETURNS @sales TABLE(ProductId varchar(15), ProductName varchar(50), Sales int)
BEGIN
	DECLARE @months AS TABLE (
		MonthValue tinyint,
		YearValue smallint
	)

	INSERT INTO @months
	select *
	from GetAllValidMonths(@year, @shopId)

	INSERT INTO @sales
	select p.Id, p.[Name], sum(ISNULL(Quantity, 0))
	from PRODUCTS p
	left join (RECEIPT_DETAILS rd
	inner join RECEIPTS r
	on rd.ReceiptId = r.Id and rd.ShopId = r.ShopId
	inner join @months m
	on month(r.DateOfPayment) = m.MonthValue and year(r.DateOfPayment) = m.YearValue)
	on p.Id = rd.ProductId and p.ShopId = rd.ShopId
	where p.ShopId = @shopId
	group by p.Id, p.[Name]
	RETURN
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetTotalLastNDaysProductSales]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetTotalLastNDaysProductSales](@daynum smallint, @shopId int)
	RETURNS @sales TABLE(ProductId varchar(15), ProductName varchar(50), Sales int)
BEGIN
	DECLARE @days AS TABLE (
		DateValue date
	)

	INSERT INTO @days
	select *
	from GetLastNDays(@daynum, @shopId)

	INSERT INTO @sales
	select p.Id, p.[Name], sum(ISNULL(Quantity, 0))
	from PRODUCTS p
	left join (RECEIPT_DETAILS rd
	inner join RECEIPTS r
	on rd.ReceiptId = r.Id and rd.ShopId = r.ShopId
	inner join @days d
	on CAST(r.DateOfPayment AS date) = d.DateValue)
	on p.Id = rd.ProductId and p.ShopId = rd.ShopId
	where p.ShopId = @shopId
	group by p.Id, p.[Name]
	RETURN
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetTotalMonthlyProductSales]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetTotalMonthlyProductSales](@month tinyint, @year smallint, @shopId int)
	RETURNS @sales TABLE(ProductId varchar(15), ProductName varchar(50), Sales int)
BEGIN
	DECLARE @dates AS TABLE (
		DateValue date
	)

	INSERT INTO @dates
	select *
	from GetAllValidDates(@month, @year, @shopId)

	INSERT INTO @sales
	select p.Id, p.[Name], sum(ISNULL(Quantity, 0))
	from PRODUCTS p
	left join (RECEIPT_DETAILS rd
	inner join RECEIPTS r
	on rd.ReceiptId = r.Id and rd.ShopId = r.ShopId
	inner join @dates d
	on CAST(r.DateOfPayment AS date) = d.DateValue)
	on p.Id = rd.ProductId and p.ShopId = rd.ShopId
	where p.ShopId = @shopId
	group by p.Id, p.[Name]
	RETURN
END
GO
/****** Object:  UserDefinedFunction [dbo].[GetTotalQuarterlyProductSales]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetTotalQuarterlyProductSales](@quarter tinyint, @year smallint, @shopId int)
	RETURNS @sales TABLE(ProductId varchar(15), ProductName varchar(50), Sales int)
BEGIN
	DECLARE @quarterdates AS TABLE (
		StartDate date,
		EndDate date
	)

	INSERT INTO @quarterdates
	select min(DateId), max(DateId)
	from CALENDAR
	where QuarterId = @quarter and YearValue = @year

	INSERT INTO @sales
	select p.Id, p.[Name], sum(ISNULL(Quantity, 0))
	from PRODUCTS p
	left join (RECEIPT_DETAILS rd
	inner join RECEIPTS r
	on rd.ReceiptId = r.Id and rd.ShopId = r.ShopId
	inner join @quarterdates q
	on r.DateOfPayment >= q.StartDate and r.DateOfPayment <= q.EndDate)
	on p.Id = rd.ProductId and p.ShopId = rd.ShopId
	where p.ShopId = @shopId
	group by p.Id, p.[Name]
	RETURN
END
GO
/****** Object:  Table [dbo].[CALENDAR]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CALENDAR](
	[DateId] [date] NOT NULL,
	[DayValue] [tinyint] NULL,
	[MonthValue] [tinyint] NULL,
	[YearValue] [smallint] NULL,
	[QuarterId] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[DateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CUSTOMERS]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUSTOMERS](
	[Id] [int] NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[EmailAddress] [varchar](60) NULL,
	[Birthdate] [smalldatetime] NULL,
	[ShopId] [int] NOT NULL,
 CONSTRAINT [PK_CUSTOMERID_SHOPID] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[ShopId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_CUSTOMER_EMAIL_EACH_SHOP] UNIQUE NONCLUSTERED 
(
	[EmailAddress] ASC,
	[ShopId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLOYEES]    Script Date: 12/28/2020 1:51:27 AM ******/
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
	[Deleted] [bit] NULL,
 CONSTRAINT [PK_EMPLOYEES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[ShopId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MANAGERS]    Script Date: 12/28/2020 1:51:27 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTS]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTS](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Type] [varchar](20) NOT NULL,
	[Image] [varbinary](max) NULL,
	[Price] [money] NOT NULL,
	[Details] [nvarchar](100) NULL,
	[ShopId] [int] NOT NULL,
	[Deleted] [bit] NULL,
 CONSTRAINT [PK_PRODUCTS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[ShopId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RECEIPT_DETAILS]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RECEIPT_DETAILS](
	[ReceiptId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[ShopId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[TotalPrice] [money] NULL,
 CONSTRAINT [PK_RECEIPT_DETAILS] PRIMARY KEY CLUSTERED 
(
	[ReceiptId] ASC,
	[ProductId] ASC,
	[ShopId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RECEIPTS]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RECEIPTS](
	[Id] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[EmployeeId] [varchar](15) NULL,
	[DateOfPayment] [smalldatetime] NULL,
	[Discount] [decimal](5, 4) NULL,
	[Total] [money] NULL,
	[Cash] [money] NULL,
	[Change] [money] NULL,
	[Details] [nvarchar](100) NULL,
	[ShopId] [int] NOT NULL,
 CONSTRAINT [PK_RECEIPTID_SHOPID] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[ShopId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SHOP]    Script Date: 12/28/2020 1:51:27 AM ******/
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
	[CreationDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STOCK_ITEMS]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STOCK_ITEMS](
	[Id] [int] NOT NULL,
	[ItemName] [varchar](20) NOT NULL,
	[SupplierId] [varchar](10) NULL,
	[ShopId] [int] NOT NULL,
 CONSTRAINT [PK_STOCKID_SHOPID] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[ShopId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STOCK_ITEMS_FOR_PRODUCTS]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STOCK_ITEMS_FOR_PRODUCTS](
	[ProductId] [int] NOT NULL,
	[ItemId] [int] NOT NULL,
	[ShopId] [int] NOT NULL,
 CONSTRAINT [PK_STOCKID_PROID_SHOPID] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC,
	[ItemId] ASC,
	[ShopId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUPPLIERS]    Script Date: 12/28/2020 1:51:27 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_SUPPLIER_EMAIL] UNIQUE NONCLUSTERED 
(
	[EmailAddress] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLE_SITTING]    Script Date: 12/28/2020 1:51:27 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLES]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLES](
	[Id] [int] NOT NULL,
	[TableStatus] [varchar](25) NULL,
	[ShopId] [int] NOT NULL,
	[Deleted] [bit] NULL,
 CONSTRAINT [PK_TABLE] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[ShopId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](30) NULL,
	[Password] [varchar](64) NOT NULL,
	[Deleted] [bit] NULL,
 CONSTRAINT [PK__USERS__3214EC07D8C19AF0] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_USERNAME] UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WORKERS]    Script Date: 12/28/2020 1:51:27 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__WORKERS__349DA5A7450EDE4B] UNIQUE NONCLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_EMAIL_IN_EACH_SHOP] UNIQUE NONCLUSTERED 
(
	[EmailAddress] ASC,
	[ShopId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[CUSTOMERS]  WITH CHECK ADD  CONSTRAINT [FK_CUSTOMERS_SHOPID] FOREIGN KEY([ShopId])
REFERENCES [dbo].[SHOP] ([Id])
GO
ALTER TABLE [dbo].[CUSTOMERS] CHECK CONSTRAINT [FK_CUSTOMERS_SHOPID]
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
ALTER TABLE [dbo].[RECEIPT_DETAILS]  WITH CHECK ADD  CONSTRAINT [FK_RECEIPT_DETAILS_PRODUCT] FOREIGN KEY([ProductId], [ShopId])
REFERENCES [dbo].[PRODUCTS] ([Id], [ShopId])
GO
ALTER TABLE [dbo].[RECEIPT_DETAILS] CHECK CONSTRAINT [FK_RECEIPT_DETAILS_PRODUCT]
GO
ALTER TABLE [dbo].[RECEIPT_DETAILS]  WITH CHECK ADD  CONSTRAINT [FK_RECEIPT_DETAILS_RECEIPT] FOREIGN KEY([ReceiptId], [ShopId])
REFERENCES [dbo].[RECEIPTS] ([Id], [ShopId])
GO
ALTER TABLE [dbo].[RECEIPT_DETAILS] CHECK CONSTRAINT [FK_RECEIPT_DETAILS_RECEIPT]
GO
ALTER TABLE [dbo].[RECEIPTS]  WITH CHECK ADD  CONSTRAINT [FK_EMPID] FOREIGN KEY([EmployeeId], [ShopId])
REFERENCES [dbo].[EMPLOYEES] ([Id], [ShopId])
GO
ALTER TABLE [dbo].[RECEIPTS] CHECK CONSTRAINT [FK_EMPID]
GO
ALTER TABLE [dbo].[RECEIPTS]  WITH CHECK ADD  CONSTRAINT [FK_RECEIPTS_CUSTOMER] FOREIGN KEY([CustomerId], [ShopId])
REFERENCES [dbo].[CUSTOMERS] ([Id], [ShopId])
GO
ALTER TABLE [dbo].[RECEIPTS] CHECK CONSTRAINT [FK_RECEIPTS_CUSTOMER]
GO
ALTER TABLE [dbo].[RECEIPTS]  WITH CHECK ADD  CONSTRAINT [FK_RECEIPTS_SHOPID] FOREIGN KEY([ShopId])
REFERENCES [dbo].[SHOP] ([Id])
GO
ALTER TABLE [dbo].[RECEIPTS] CHECK CONSTRAINT [FK_RECEIPTS_SHOPID]
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
ALTER TABLE [dbo].[TABLE_SITTING]  WITH CHECK ADD  CONSTRAINT [FK_TABLE_RECEIPT] FOREIGN KEY([ReceiptId], [ShopId])
REFERENCES [dbo].[RECEIPTS] ([Id], [ShopId])
GO
ALTER TABLE [dbo].[TABLE_SITTING] CHECK CONSTRAINT [FK_TABLE_RECEIPT]
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
ALTER TABLE [dbo].[RECEIPTS]  WITH CHECK ADD  CONSTRAINT [CHECK_DISCOUNT_PERCENTAGE] CHECK  (([Discount]>=(0) AND [Discount]<=(1)))
GO
ALTER TABLE [dbo].[RECEIPTS] CHECK CONSTRAINT [CHECK_DISCOUNT_PERCENTAGE]
GO
ALTER TABLE [dbo].[TABLES]  WITH CHECK ADD  CONSTRAINT [TABLE_STATUS] CHECK  (([TableStatus]='Available' OR [TableStatus]='Occupied' OR [TableStatus]='Unavailable'))
GO
ALTER TABLE [dbo].[TABLES] CHECK CONSTRAINT [TABLE_STATUS]
GO
ALTER TABLE [dbo].[WORKERS]  WITH CHECK ADD  CONSTRAINT [GENDER_WORKERS] CHECK  (([Gender]='Female' OR [Gender]='Male'))
GO
ALTER TABLE [dbo].[WORKERS] CHECK CONSTRAINT [GENDER_WORKERS]
GO
/****** Object:  StoredProcedure [dbo].[GetAllValidDatesMonthYearShop]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllValidDatesMonthYearShop] @month tinyint, @year smallint, @shopId int
AS
	SET NOCOUNT ON
	DECLARE @dates AS TABLE (
		DateValue date
	)
	DECLARE @currentdate date = GETDATE()
	DECLARE @creationdate date = (
		select CreationDate
		from SHOP
		where Id = @shopId
	)

	INSERT INTO @dates
	select DateId
	from CALENDAR
	where MonthValue = @month AND YearValue = @year

	IF @month = CAST(month(@currentdate) AS tinyint) AND @year = CAST(year(@currentdate) AS smallint)
	BEGIN
		DELETE FROM @dates 
		WHERE day(DateValue) > day(@currentdate)
	END

	IF @month = CAST(month(@creationdate) AS tinyint) AND @year = CAST(year(@creationdate) AS smallint)
	BEGIN
		DELETE FROM @dates
		WHERE day(DateValue) < day(@creationdate)
	END

	select * from @dates

RETURN
GO
/****** Object:  StoredProcedure [dbo].[GetIncomeMonths]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetIncomeMonths] @month tinyint, @year smallint, @shopId int
AS
	DECLARE @dates AS TABLE (
		DateValue date
	)

	INSERT INTO @dates
	EXEC GetAllValidDatesMonthYearShop @month = @month, @year = @year, @shopId = @shopId;

	select CAST(day(d.DateValue) AS varchar(2)) + '/' + CAST(month(d.DateValue) AS varchar(2)) DateVal, sum(ISNULL(Total, 0)) Income
	from @dates d
	left join (
		select *
		from RECEIPTS
		where ShopId = @shopId
	) r
	on d.DateValue = CAST(r.DateOfPayment AS date)
	group by d.DateValue
	order by d.DateValue asc

RETURN
GO
/****** Object:  Trigger [dbo].[IOINS_Customers]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[IOINS_Customers] ON [dbo].[CUSTOMERS]
INSTEAD OF INSERT
AS
BEGIN
  SET NOCOUNT ON;

  -- Acquire the lock so that no one else can generate a key at the same time.
  -- If the transaction fails then the lock will automatically be released.
  -- If the acquisition takes longer than 15 seconds an error is raised.
  DECLARE @res INT;
  EXEC @res = sp_getapplock @Resource = 'IOINS_Customers', 
    @LockMode = 'Exclusive', @LockOwner = 'Transaction', @LockTimeout = '15000',
    @DbPrincipal = 'public'
  IF (@res < 0)
  BEGIN
    RAISERROR('Unable to acquire lock to update Customers table.', 16, 1);
  END

  -- Work out what the current maximum Ids are for each tenant that is being
  -- inserted in this operation.
  DECLARE @baseId TABLE(BaseId int, ShopId int);
  INSERT INTO @baseId
  SELECT max(ISNULL(C.Id, 0)) AS BaseId, I.ShopId
  FROM INSERTED I
  LEFT OUTER JOIN CUSTOMERS C
  ON I.ShopId = C.ShopId
  GROUP BY I.ShopId

  -- The replacement insert operation
  INSERT INTO CUSTOMERS
  SELECT 
    ROW_NUMBER() OVER(PARTITION BY i.ShopId ORDER BY i.ShopId) + b.BaseId 
      AS Id, I.FirstName, I.LastName, I.EmailAddress, I.Birthdate, I.ShopId
    Name
  FROM inserted I
  INNER JOIN @baseId B ON B.ShopId = I.ShopId

  -- Release the lock.
  EXEC @res = sp_releaseapplock @Resource = 'IOINS_Customers', 
    @DbPrincipal = 'public', @LockOwner = 'Transaction'
END
GO
ALTER TABLE [dbo].[CUSTOMERS] ENABLE TRIGGER [IOINS_Customers]
GO
/****** Object:  Trigger [dbo].[IOINS_Products]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[IOINS_Products] ON [dbo].[PRODUCTS]
INSTEAD OF INSERT
AS
BEGIN
  SET NOCOUNT ON;

  -- Acquire the lock so that no one else can generate a key at the same time.
  -- If the transaction fails then the lock will automatically be released.
  -- If the acquisition takes longer than 15 seconds an error is raised.
  DECLARE @res INT;
  EXEC @res = sp_getapplock @Resource = 'IOINS_Products', 
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
  SELECT max(ISNULL(p.Id, 0)) AS BaseId, I.ShopId
  FROM INSERTED I
  LEFT OUTER JOIN PRODUCTS p
  ON I.ShopId = p.ShopId
  GROUP BY I.ShopId

  -- The replacement insert operation
  INSERT INTO PRODUCTS (Id, [Name], [Type], [Image], Price, Details, ShopId, Deleted)
  SELECT 
    ROW_NUMBER() OVER(PARTITION BY i.ShopId ORDER BY i.ShopId) + b.BaseId 
      AS Id, i.[Name], i.[Type], i.[Image], i.Price, i.Details, i.ShopId, i.Deleted
    Name
  FROM inserted i
  INNER JOIN @baseId B ON B.ShopId = I.ShopId

  -- Release the lock.
  EXEC @res = sp_releaseapplock @Resource = 'IOINS_Products', 
    @DbPrincipal = 'public', @LockOwner = 'Transaction'
END
GO
ALTER TABLE [dbo].[PRODUCTS] ENABLE TRIGGER [IOINS_Products]
GO
/****** Object:  Trigger [dbo].[IOINS_Receipts]    Script Date: 12/28/2020 1:51:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[IOINS_Receipts] ON [dbo].[RECEIPTS]
INSTEAD OF INSERT
AS
BEGIN
  SET NOCOUNT ON;

  -- Acquire the lock so that no one else can generate a key at the same time.
  -- If the transaction fails then the lock will automatically be released.
  -- If the acquisition takes longer than 15 seconds an error is raised.
  DECLARE @res INT;
  EXEC @res = sp_getapplock @Resource = 'IOINS_Receipts', 
    @LockMode = 'Exclusive', @LockOwner = 'Transaction', @LockTimeout = '15000',
    @DbPrincipal = 'public'
  IF (@res < 0)
  BEGIN
    RAISERROR('Unable to acquire lock to update Receipts table.', 16, 1);
  END

  -- Work out what the current maximum Ids are for each tenant that is being
  -- inserted in this operation.
  DECLARE @baseId TABLE(BaseId int, ShopId int);
  INSERT INTO @baseId
  SELECT max(ISNULL(R.Id, 0)) AS BaseId, I.ShopId
  FROM INSERTED I
  LEFT OUTER JOIN RECEIPTS R
  ON I.ShopId = R.ShopId
  GROUP BY I.ShopId

  -- The replacement insert operation
  INSERT INTO RECEIPTS (Id, CustomerId, EmployeeId, DateOfPayment, Discount, Total, Cash, Change, Details, ShopId)
  SELECT 
    ROW_NUMBER() OVER(PARTITION BY i.ShopId ORDER BY i.ShopId) + b.BaseId 
      AS Id, I.CustomerId, I.EmployeeId, I.DateOfPayment, I.Discount, I.Total, I.Cash, I.Change, I.Details, I.ShopId
    Name
  FROM inserted I
  INNER JOIN @baseId B ON B.ShopId = I.ShopId

  -- Release the lock.
  EXEC @res = sp_releaseapplock @Resource = 'IOINS_Receipts', 
    @DbPrincipal = 'public', @LockOwner = 'Transaction'
END
GO
ALTER TABLE [dbo].[RECEIPTS] ENABLE TRIGGER [IOINS_Receipts]
GO
/****** Object:  Trigger [dbo].[IOINS_Stock_Items]    Script Date: 12/28/2020 1:51:27 AM ******/
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
    RAISERROR('Unable to acquire lock to update Stock_Items table.', 16, 1);
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
