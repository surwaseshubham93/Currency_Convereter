USE [CurrencyConverter]
GO
/****** Object:  Table [dbo].[RatescomparedtoINR]    Script Date: 17-Jan-24 14:11:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RatescomparedtoINR](
	[Country_Name] [varchar](max) NOT NULL,
	[Currency] [varchar](max) NOT NULL,
	[International_Rate] [float] NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[RatescomparedtoINR] ON 

INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Argentina', N'Argentine Peso', 0.23159, 1)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Australia', N'Australian Dollar', 55.322866, 2)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Bahrain', N'Bahraini Dinar', 221.719676, 3)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Botswana', N'Botswana Pula', 6.165633, 4)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Brazil', N'Brazilian Real', 16.997675, 5)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'United Kingdom', N'British Pound', 105.887287, 6)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Sultanate of Brunei', N'Bruneian Dollar', 62.525689, 7)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Bulgaria', N'Bulgarian Lev', 46.687794, 8)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Canada', N'Canadian Dollar', 61.379559, 9)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Chile', N'Chilean Peso', 0.095938, 10)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'China', N'Chinese Yuan Renminbi', 11.716204, 11)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Colombia', N'Colombian Peso', 0.020829, 12)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Czech Republic', N'Czech Koruna', 3.764779, 13)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Denmark, Greenland and the Faroe Islands', N'Danish Krone', 12.247259, 14)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'United Arab Emirates', N'Emirati Dirham', 22.700231, 15)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Eurozone', N'Euro', 91.313387, 16)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Hong Kong', N'Hong Kong Dollar', 10.677279, 17)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Hungeria', N'Hungarian Forint', 0.241471, 18)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Iceland', N'Icelandic Krona', 0.606709, 19)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Indonesia', N'Indonesian Rupiah', 0.005373, 20)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Iran', N'Iranian Rial', 0.001987, 21)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Israel', N'Israeli Shekel', 22.600949, 22)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Japan', N'Japanese Yen', 0.566937, 23)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Kazakhstan', N'Kazakhstani Tenge', 0.181949, 24)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Kuwait', N'Kuwaiti Dinar', 270.237727, 25)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Libya', N'Libyan Dinar', 17.371678, 26)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Malaysia', N'Malaysian Ringgit', 17.890238, 27)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Mauritius', N'Mauritian Rupee', 1.879307, 28)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Mexico', N'Mexican Peso', 4.822388, 29)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Nepal', N'Nepalese Rupee', 0.624707, 30)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'New Zealand', N'New Zealand Dollar', 51.465508, 31)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Norway', N'Norwegian Krone', 7.816937, 32)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Oman', N'Omani Rial', 216.532625, 33)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Pakistan', N'Pakistani Rupee', 0.292405, 34)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Philippines', N'Philippine Peso', 1.503588, 35)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Poland', N'Polish Zloty', 20.973046, 36)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Qatar', N'Qatari Riyal', 22.906579, 37)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Romania', N'Romanian New Leu', 18.335692, 38)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Russia', N'Russian Ruble', 0.941415, 39)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Saudi Arabia', N'Saudi Arabian Riyal', 22.234653, 40)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Singapore', N'Singapore Dollar', 62.474923, 41)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'South Africa', N'South African Rand', 4.43441, 42)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'South Korea', N'South Korean Won', 0.064333, 43)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Sri Lanka', N'Sri Lankan Rupee', 0.254368, 44)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Sweden', N'Swedish Krona', 7.993558, 45)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Switzerland and Liechtenstein', N'Swiss Franc', 95.328568, 46)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Taiwan', N'Taiwan New Dollar', 2.663449, 47)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Thailand', N'Thai Baht', 2.372515, 48)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Trinidad and Tobago', N'Trinidadian Dollar', 12.292547, 49)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'Turkey', N'Turkish Lira', 2.888931, 50)
INSERT [dbo].[RatescomparedtoINR] ([Country_Name], [Currency], [International_Rate], [ID]) VALUES (N'United States', N'US Dollar', 83.377906, 51)
SET IDENTITY_INSERT [dbo].[RatescomparedtoINR] OFF
GO
