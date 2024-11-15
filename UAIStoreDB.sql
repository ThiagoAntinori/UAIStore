USE [UAIStore]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 08/11/2024 22:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aplicaciones]    Script Date: 08/11/2024 22:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aplicaciones](
	[IdAplicacion] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [nvarchar](max) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Desarrolladora] [nvarchar](max) NOT NULL,
	[Precio] [float] NOT NULL,
	[IdCategoria] [int] NOT NULL,
 CONSTRAINT [PK_Aplicaciones] PRIMARY KEY CLUSTERED 
(
	[IdAplicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 08/11/2024 22:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241108230650_InitialCreate', N'8.0.10')
GO
SET IDENTITY_INSERT [dbo].[Aplicaciones] ON 

INSERT [dbo].[Aplicaciones] ([IdAplicacion], [Titulo], [Descripcion], [Desarrolladora], [Precio], [IdCategoria]) VALUES (13, N'ouncoaenau', N'nocuanocnaofunaripofnmaou', N'noaeincaoenc', 200, 5)
INSERT [dbo].[Aplicaciones] ([IdAplicacion], [Titulo], [Descripcion], [Desarrolladora], [Precio], [IdCategoria]) VALUES (15, N'rtbatdbasd', N'atbadbadhadbvadhad', N'batdadthadth', 35, 3)
SET IDENTITY_INSERT [dbo].[Aplicaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([IdCategoria], [Descripcion]) VALUES (1, N'Juegos')
INSERT [dbo].[Categorias] ([IdCategoria], [Descripcion]) VALUES (2, N'Finanzas')
INSERT [dbo].[Categorias] ([IdCategoria], [Descripcion]) VALUES (3, N'Comida')
INSERT [dbo].[Categorias] ([IdCategoria], [Descripcion]) VALUES (4, N'Educativa')
INSERT [dbo].[Categorias] ([IdCategoria], [Descripcion]) VALUES (5, N'Entretenimiento')
INSERT [dbo].[Categorias] ([IdCategoria], [Descripcion]) VALUES (6, N'Utilidad')
SET IDENTITY_INSERT [dbo].[Categorias] OFF
GO
ALTER TABLE [dbo].[Aplicaciones]  WITH CHECK ADD  CONSTRAINT [FK_Aplicaciones_Categorias_IdCategoria] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categorias] ([IdCategoria])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Aplicaciones] CHECK CONSTRAINT [FK_Aplicaciones_Categorias_IdCategoria]
GO
