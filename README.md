


// creation de la base de donnee

CREATE DATABASE [db_calendar]




// la creation de la table rendezvous


USE [db_calendar]
GO

/****** Object:  Table [dbo].[tbl_calendar]    Script Date: 2023-04-17 19:05:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_calendar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[event] [varchar](255) NOT NULL,
	[date] [date] NOT NULL,
	[startevent] [time](7) NOT NULL,
	[endevent] [time](7) NOT NULL,
	[workers] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO







// la creation de la table employee
USE [db_calendar]
GO

/****** Object:  Table [dbo].[Workers]    Script Date: 2023-04-17 19:04:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Workers](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[JobTitle] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO




//insertion des employee

INSERT INTO Workers (Id, Name, JobTitle) VALUES (13, 'Chris Evans', 'Software Engineer');
INSERT INTO Workers (Id, Name, JobTitle) VALUES (14, 'Linda Wang', 'Product Manager');
INSERT INTO Workers (Id, Name, JobTitle) VALUES (15, 'Jason Park', 'Graphic Designer');
INSERT INTO Workers (Id, Name, JobTitle) VALUES (16, 'Mary Johnson', 'Financial Analyst');
INSERT INTO Workers (Id, Name, JobTitle) VALUES (17, 'Kevin Lee', 'Operations Manager');
INSERT INTO Workers (Id, Name, JobTitle) VALUES (18, 'Maggie Kim', 'Technical Writer');
INSERT INTO Workers (Id, Name, JobTitle) VALUES (19, 'Tom Smith', 'Customer Service Representative');
INSERT INTO Workers (Id, Name, JobTitle) VALUES (20, 'Alice Kim', 'Web Developer');
INSERT INTO Workers (Id, Name, JobTitle) VALUES (21, 'Erica Lee', 'Product Designer');
INSERT INTO Workers (Id, Name, JobTitle) VALUES (22, 'Nick Johnson', 'Quality Control Specialist');
INSERT INTO Workers (Id, Name, JobTitle) VALUES (23, 'Sophie Park', 'Social Media Specialist');


