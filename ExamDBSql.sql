USE [ExamSystemDB]
GO
/****** Object:  Table [dbo].[ChoiceQuestion]    Script Date: 2021/10/2 20:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChoiceQuestion](
	[questionType] [varchar](50) NULL,
	[questionStem] [varchar](50) NULL,
	[questionOptionA] [varchar](50) NULL,
	[questionOptionB] [varchar](50) NULL,
	[questionOptionC] [varchar](50) NULL,
	[questionOptionD] [varchar](50) NULL,
	[questionAnswer] [varchar](50) NULL,
	[questionId] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_ChoiceQuestion_1] PRIMARY KEY CLUSTERED 
(
	[questionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paper]    Script Date: 2021/10/2 20:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paper](
	[paperId] [int] IDENTITY(1,1) NOT NULL,
	[paperClass] [varchar](50) NULL,
	[paperChoiceContext] [nchar](500) NULL,
	[paperStatus] [nvarchar](max) NULL,
	[paperTxtContext] [varchar](50) NULL,
	[paperName] [varchar](500) NULL,
 CONSTRAINT [PK__Paper__3213E83F1AFD5AC8] PRIMARY KEY CLUSTERED 
(
	[paperId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[paperAnswer]    Script Date: 2021/10/2 20:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paperAnswer](
	[questionId] [int] NOT NULL,
	[paperAnswer] [nvarchar](500) NULL,
	[paperId] [int] NOT NULL,
	[stuId] [nchar](10) NOT NULL,
 CONSTRAINT [PK_paperAnswer] PRIMARY KEY CLUSTERED 
(
	[questionId] ASC,
	[stuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[paperScore]    Script Date: 2021/10/2 20:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paperScore](
	[stuId] [varchar](50) NULL,
	[paperId] [varchar](50) NULL,
	[paperChoiceNum] [varchar](50) NULL,
	[paperTxtNum] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stuScore]    Script Date: 2021/10/2 20:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stuScore](
	[stuId] [varchar](50) NOT NULL,
	[stuClass] [varchar](50) NULL,
	[paperId] [int] NULL,
	[paperScore] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TxtQuestion]    Script Date: 2021/10/2 20:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TxtQuestion](
	[questionType] [varchar](50) NULL,
	[questionStem] [nchar](500) NULL,
	[questionAnswer] [nchar](500) NULL,
	[questionId] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_TxtQuestion] PRIMARY KEY CLUSTERED 
(
	[questionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 2021/10/2 20:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[userNum] [varchar](50) NOT NULL,
	[userName] [varchar](50) NOT NULL,
	[userPwd] [varchar](50) NOT NULL,
	[userGender] [varchar](50) NOT NULL,
	[userTel] [varchar](50) NOT NULL,
	[userClass] [varchar](50) NOT NULL,
	[userRole] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChoiceQuestion] ON 

INSERT [dbo].[ChoiceQuestion] ([questionType], [questionStem], [questionOptionA], [questionOptionB], [questionOptionC], [questionOptionD], [questionAnswer], [questionId]) VALUES (N'choice    ', N'1+2=?     ', N'2         ', N'3         ', N'4         ', N'5         ', N'B         ', 9)
INSERT [dbo].[ChoiceQuestion] ([questionType], [questionStem], [questionOptionA], [questionOptionB], [questionOptionC], [questionOptionD], [questionAnswer], [questionId]) VALUES (N'choice    ', N'1+3=?     ', N'2         ', N'3         ', N'4         ', N'5         ', N'C         ', 10)
SET IDENTITY_INSERT [dbo].[ChoiceQuestion] OFF
GO
SET IDENTITY_INSERT [dbo].[Paper] ON 

INSERT [dbo].[Paper] ([paperId], [paperClass], [paperChoiceContext], [paperStatus], [paperTxtContext], [paperName]) VALUES (23, N'2020级计算机  ', N'9 10                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ', N'T         ', N'8 9                                               ', N'2020级期末考试')
SET IDENTITY_INSERT [dbo].[Paper] OFF
GO
SET IDENTITY_INSERT [dbo].[TxtQuestion] ON 

INSERT [dbo].[TxtQuestion] ([questionType], [questionStem], [questionAnswer], [questionId]) VALUES (N'txt       ', N'1+3=?                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               ', N'3                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   ', 8)
INSERT [dbo].[TxtQuestion] ([questionType], [questionStem], [questionAnswer], [questionId]) VALUES (N'txt       ', N'1+3                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 ', N'4                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   ', 9)
SET IDENTITY_INSERT [dbo].[TxtQuestion] OFF
GO
INSERT [dbo].[User] ([userNum], [userName], [userPwd], [userGender], [userTel], [userClass], [userRole]) VALUES (N'admin', N'admin', N'admin', N'男', N'admin', N'admin', N'管理员')
INSERT [dbo].[User] ([userNum], [userName], [userPwd], [userGender], [userTel], [userClass], [userRole]) VALUES (N'stu', N'stu', N'stu', N'女', N'133333333333', N'2020级计算机', N'学生')
INSERT [dbo].[User] ([userNum], [userName], [userPwd], [userGender], [userTel], [userClass], [userRole]) VALUES (N'teach', N'teach', N'teach', N'女', N'13333', N'无', N'教师')
GO
ALTER TABLE [dbo].[paperAnswer]  WITH CHECK ADD  CONSTRAINT [paperAnswer_FK] FOREIGN KEY([paperId])
REFERENCES [dbo].[Paper] ([paperId])
GO
ALTER TABLE [dbo].[paperAnswer] CHECK CONSTRAINT [paperAnswer_FK]
GO
ALTER TABLE [dbo].[stuScore]  WITH CHECK ADD  CONSTRAINT [Paper_FK] FOREIGN KEY([paperId])
REFERENCES [dbo].[Paper] ([paperId])
GO
ALTER TABLE [dbo].[stuScore] CHECK CONSTRAINT [Paper_FK]
GO
