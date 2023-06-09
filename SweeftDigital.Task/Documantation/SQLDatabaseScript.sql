USE [SweeftDigitalTask]
GO
/****** Object:  Table [dbo].[Pupils]    Script Date: 20.03.2023 02:48:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pupils](
	[PupilId] [int] IDENTITY(1,1) NOT NULL,
	[Class] [nvarchar](20) NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[LastName] [nvarchar](30) NOT NULL,
	[Gender] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Pupils] PRIMARY KEY CLUSTERED 
(
	[PupilId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PupilTeacher]    Script Date: 20.03.2023 02:48:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PupilTeacher](
	[PupilsPupilId] [int] NOT NULL,
	[TeachersTeacherId] [int] NOT NULL,
 CONSTRAINT [PK_PupilTeacher] PRIMARY KEY CLUSTERED 
(
	[PupilsPupilId] ASC,
	[TeachersTeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 20.03.2023 02:48:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[TeacherId] [int] IDENTITY(1,1) NOT NULL,
	[Subject] [nvarchar](20) NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[LastName] [nvarchar](30) NOT NULL,
	[Gender] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PupilTeacher]  WITH CHECK ADD  CONSTRAINT [FK_PupilTeacher_Pupils_PupilsPupilId] FOREIGN KEY([PupilsPupilId])
REFERENCES [dbo].[Pupils] ([PupilId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PupilTeacher] CHECK CONSTRAINT [FK_PupilTeacher_Pupils_PupilsPupilId]
GO
ALTER TABLE [dbo].[PupilTeacher]  WITH CHECK ADD  CONSTRAINT [FK_PupilTeacher_Teachers_TeachersTeacherId] FOREIGN KEY([TeachersTeacherId])
REFERENCES [dbo].[Teachers] ([TeacherId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PupilTeacher] CHECK CONSTRAINT [FK_PupilTeacher_Teachers_TeachersTeacherId]
GO
