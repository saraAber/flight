CREATE TABLE [Country](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Country] [varchar](50) NULL,
	[CountryValue] [varchar](50) NULL
	)
CREATE TABLE [Matach](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Uro] [float] NULL,
	[Usa] [float] NULL,
	[Shach] [float] NULL
	)
CREATE TABLE [Coin](
//	[Id] [int] PRIMARY key IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,//
	[nameValue] [varchar](50) NOT NULL//
	)
CREATE TABLE [TypeInfo](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Type] [varchar](50) NOT NULL
	)
CREATE TABLE [User](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50),
	[Password] [varchar](10) NULL,
	[Email] [varchar](30) NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Fhon] [varchar](50) NULL,
	[LoginDate] [datetime] NULL,
	[EditDate] [datetime] NULL
	)
CREATE TABLE [LoginUser](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[UserId] [int] foreign key references [User](Id) NOT NULL,
	[LoginDate] [datetime] NOT NULL
	)
CREATE TABLE [FlightInfor](
	[Id] [int] PRIMARY KEY  IDENTITY(1,1) NOT NULL,
	[IdUser] [int] foreign key references [User](Id),
	[UserName] [varchar](50) NULL,
	[From]  int foreign key references [Country](Id) NOT NULL,
	[ToPlice] int foreign key references [Country](Id) NOT NULL,
	[TZUser] [varchar](9) NULL,
	[StartDate] [datetime] NOT NULL,
	[BackDate] [datetime] NOT NULL,
	[Dates] [int] NOT NULL
	)
CREATE TABLE [Information](
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[IdFlight] [int] foreign key references [FlightInfor](Id) NOT NULL,
	[IdType] [int]  foreign key references [TypeInfo](Id) NOT NULL,
	[WhoPay] [varchar](50) NOT NULL,
	[countryId] int foreign key references [Country](Id) NOT NULL,
	[Length] int NOT NULL,
	[Cost] [float] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Coin] [int] foreign key references [Coin](Id) NOT NULL,
	[Pya] int NOT NULL
	) 
CREATE TABLE files(
	[Id] [int] PRIMARY KEY  IDENTITY(1,1) NOT NULL,
	[intInfor] [int] FOREIGN KEY references [Flights].[dbo].[FlightInfor] ([Id]) NOT NULL,
	[FileName] [varchar](50) NOT NULL,
	[Pathname] [varchar](50) NOT NULL,
	[Type] [varchar](25) NOT NULL,
	[Size] [varchar](30) NULL,
	)
