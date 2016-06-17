USE [master]
GO
/****** Object:  Database [db_question]    Script Date: 17/06/2016 7:07:49 CH ******/
CREATE DATABASE [db_question]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_question', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\db_question.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_question_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\db_question_log.ldf' , SIZE = 4224KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_question] SET COMPATIBILITY_LEVEL = 90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_question].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_question] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_question] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_question] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_question] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_question] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_question] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_question] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [db_question] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_question] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_question] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_question] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_question] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_question] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_question] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_question] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_question] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_question] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_question] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_question] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_question] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_question] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_question] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_question] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_question] SET RECOVERY FULL 
GO
ALTER DATABASE [db_question] SET  MULTI_USER 
GO
ALTER DATABASE [db_question] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_question] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_question] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_question] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_question', N'ON'
GO
USE [db_question]
GO
/****** Object:  Table [dbo].[t_answer]    Script Date: 17/06/2016 7:07:49 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_answer](
	[id_ans] [int] NOT NULL,
	[content_ans] [ntext] NOT NULL,
	[id_quest] [int] NOT NULL,
	[true_ans] [int] NOT NULL,
 CONSTRAINT [PK_t_answer] PRIMARY KEY CLUSTERED 
(
	[id_ans] ASC,
	[id_quest] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[t_mark]    Script Date: 17/06/2016 7:07:49 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_mark](
	[msv] [varchar](50) NOT NULL,
	[id_subject] [varchar](50) NOT NULL,
	[mark] [float] NOT NULL,
 CONSTRAINT [PK_t_mark] PRIMARY KEY CLUSTERED 
(
	[msv] ASC,
	[id_subject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_question]    Script Date: 17/06/2016 7:07:49 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_question](
	[id_quest] [int] IDENTITY(1,1) NOT NULL,
	[content_quest] [ntext] NOT NULL,
	[id_subject] [varchar](50) NOT NULL,
 CONSTRAINT [PK_t_question_1] PRIMARY KEY CLUSTERED 
(
	[id_quest] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_subject]    Script Date: 17/06/2016 7:07:49 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_subject](
	[id_subject] [varchar](50) NOT NULL,
	[content_subject] [nvarchar](50) NOT NULL,
	[number_quest] [int] NULL,
	[timer] [int] NULL,
	[date_test] [datetime] NULL,
 CONSTRAINT [PK_t_subject] PRIMARY KEY CLUSTERED 
(
	[id_subject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_user]    Script Date: 17/06/2016 7:07:49 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_user](
	[msv] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[class] [varchar](10) NOT NULL,
 CONSTRAINT [PK_t_user] PRIMARY KEY CLUSTERED 
(
	[msv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1059, N'Transistor lưỡng cực', 4794, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1060, N'Transistor trường', 4794, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1061, N'Đèn điện tử ', 4794, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1062, N'IC bán dẫn', 4794, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1063, N'Phần cứng của máy tính bao gồm các đối tượng vật lý như bản mạch chính, bộ nhớ RAM, ROM, đĩa cứng, màn hình ', 4795, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1064, N'Phần cứng của máy tính bao gồm các đối tượng như bản mạch chính, bộ nhớ RAM, bộ nhớ ROM, đĩa cứng, màn hình và chương trình được cài đặt trong ROM', 4795, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1065, N'Phần cứng của máy tính là chương trình được cài đặt trong bộ nhớ ROM', 4795, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1066, N'Phần cứng của máy tính chính là bộ xử lý trung tâm', 4795, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1067, N'Bộ nhớ trong, CPU và khối phối ghép vào ra', 4796, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1068, N'Bộ nhớ trong, CPU và thiết bị ngoại vi', 4796, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1069, N'Bộ nhớ trong, CPU, khối phối ghép vào ra và thiết bị ngoại vi', 4796, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1070, N'Bộ nhớ trong, CPU, bộ nhớ ngoài, bộ phối ghép vào ra và thiết bị ngoại vi ', 4796, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1071, N'Phần mềm được đặt vào bên trong các mạch điện tử trong quá trình sản xuất ', 4797, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1072, N'Hệ điều hành', 4797, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1073, N'Các Driver cho các thiết bị phần cứng và các mạch hỗ trợ phối ghép vào ra cho máy tính', 4797, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1074, N'Phần mềm hệ thống', 4797, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1075, N'Hệ điều hành MS DOS', 4798, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1076, N'Chương trình điều khiển trong ROM BIOS ', 4798, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1077, N'Chương trình Driver cho Card màn hình của máy tính', 4798, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1078, N'Phần mềm ứng dụng của người dùng', 4798, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1079, N'Một thanh ghi điều khiển', 4799, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1080, N'Một cổng ', 4799, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1081, N'Thanh ghi AX', 4799, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1082, N'Thanh ghi cờ', 4799, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1083, N'Các bộ điều phối thiết bị giúp cho việc ghép nối và ra được thực hiện một cách linh hoạt.', 4800, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1084, N'Cơ cấu trao đổi dữ liệu giữa các thiết bị phần cứng trong máy tính', 4800, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1085, N'Chương trình được cài đặt trong bộ nhớ ROM ', 4800, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1086, N'Bộ vi xử lý và các vi mạch hỗ trợ cho nó', 4800, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1087, N'Đơn vị phối ghép vào ra ', 4801, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1088, N'Khối số học và logic', 4801, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1089, N'Tập các thanh ghi đa năng', 4801, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1090, N'Khối điều khiển', 4801, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1091, N'Bộ nhớ trong ', 4802, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1092, N'Khối số học và logic', 4802, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1093, N'Tập các thanh ghi đa năng', 4802, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1094, N'Khối điều khiển để thi hành lệnh một cách tuần tự và tác động lên các mạch chức năng nhằm thi hành lệnh.', 4802, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1095, N'Bộ nhớ trong', 4803, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1096, N'Đơn vị phối ghép vào ra', 4803, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1097, N'Tập các thanh ghi đa năng ', 4803, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1098, N'Khối điều khiển Bus hệ thống', 4803, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1099, N'Giá trị các ô nhớ là ngẫu nhiên', 4804, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1100, N'Thời gian truy cập vào một ô nhớ bất kỳ là như nhau ', 4804, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1101, N'Bộ nhớ gồm các module có thứ tự sắp xếp ngẫu nhiên', 4804, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1102, N'Thời gian truy cập vào một ô nhớ bất kỳ là ngẫu nhiên', 4804, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1103, N'Bits', 4805, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1104, N'Baud', 4805, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1105, N'Byte', 4805, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1106, N'Hz ', 4805, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1107, N'Tốc độ tính toán của máy tính', 4806, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1108, N'Mức độ tích hợp của các vi mạch điện tử trong máy tính', 4806, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1109, N'Chức năng của máy tính', 4806, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1110, N'Cả 3 tiêu chí trên ', 4806, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1111, N'Máy Turing gồm một băng ghi (tape) và một bộ xử lý trung tâm', 4807, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1112, N'Máy Turing gồm một bộ điều khiển trạng thái hữu hạn, một băng ghi, và một đầu đọc ghi ', 4807, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1113, N'Máy Turing gồm một bộ xử lý trung tâm và một cơ cấu lưu trữ gồm các IC nhớ', 4807, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1114, N'Máy Turing gồm một đầu đọc ghi, một bộ xử lý trung tâm, và một băng ghi', 4807, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1115, N'Máy tính có thể hoạt động theo một chương trình đã được lưu trữ ', 4808, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1116, N'Máy tính có thể điều khiển mọi hoạt động bằng một chương trình duy nhất', 4808, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1117, N'Bộ nhớ máy tính không thể địa chỉ hóa được', 4808, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1118, N'Mỗi  lệnh phải có một vùng nhớ chứa địa chỉ lệnh tiếp theo', 4808, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1119, N'Máy tính có thể hoạt động theo một chương trình đã được lưu trữ', 4809, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1120, N'Máy tính sử dụng một bộ đếm chương trình để chỉ ra vị trí  lệnh kế tiếp', 4809, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1121, N'Bộ nhớ của máy tính được địa chỉ hóa', 4809, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1122, N'Mỗi  lệnh phải có một vùng nhớ chứa địa chỉ lệnh tiếp theo ', 4809, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1123, N'Máy tính sử dụng một bộ đếm chương trình để chỉ ra vị trí  lệnh kế tiếp ', 4810, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1124, N'Máy tính có thể điều khiển mọi hoạt động bằng một chương trình duy nhất', 4810, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1125, N'Bộ nhớ máy tính không thể địa chỉ hóa được', 4810, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1126, N'Mỗi  lệnh phải có một vùng nhớ chứa địa chỉ lệnh tiếp theo', 4810, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1127, N'Các chương trình chỉ được nạp khi thực hiện', 4811, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1128, N'Máy tính có thể điều khiển mọi hoạt động bằng một chương trình duy nhất', 4811, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1129, N'Bộ nhớ máy tính không thể địa chỉ hóa được', 4811, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1130, N'Bộ nhớ của máy tính được địa chỉ hóa ', 4811, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1131, N'Thay đổi nội dung thanh ghi con trỏ lệnh bằng địa chỉ lệnh cần thực hiện tiếp ', 4812, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1132, N'Thay đổi nội dung trong vùng nhớ chứa địa chỉ chương trình đang thực hiện', 4812, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1133, N'Thay đổi nội dung thanh ghi mảng mã lệnh', 4812, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1134, N'Thay đổi nội dung thanh ghi mảng dữ liệu', 4812, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1135, N'Xác định địa chỉ và trạng thái của khối dữ liệu', 4813, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1136, N'Xác định địa chỉ của khối dữ liệu ', 4813, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1137, N'Xác định trạng thái của khối dữ liệu', 4813, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1138, N'Xác định nội dung của khối dữ liệu', 4813, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1139, N'Nhị phân ', 4814, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1140, N'Mã ASSCII', 4814, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1141, N'Thập phân', 4814, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1142, N'Kết hợp chữ cái và chữ số', 4814, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1143, N'Đục lỗ trên băng giấy', 4815, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1144, N'Đục lỗ trên bìa và đưa vào bằng tay', 4815, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1145, N'Xung điện ', 4815, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1146, N'Xung điện từ', 4815, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1147, N'Hệ đếm là tập hợp các ký hiệu và qui tắc sử dụng tập ký hiệu đó để biểu diễn và xác định giá trị các số', 4816, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1148, N'Tổng số ký số của mỗi hệ đếm được gọi là cơ số', 4816, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1149, N'Mỗi hệ đếm được xây dựng trên một tập ký số vô hạn ', 4816, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1150, N'Hệ đếm La mã là hệ đếm không có trọng số', 4816, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1151, N'Hệ thống các kí hiệu để biểu diễn các số', 4817, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1152, N'Hệ thống các qui tắc và phép tính để biểu biểu diễn các số', 4817, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1153, N'Tập hợp các ký hiệu và qui tắc sử dụng nó để biểu diễn và xác định giá trị các số ', 4817, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1154, N'Tập hợp các ký hiệu để biểu diễn các qui tắc đếm', 4817, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1155, N'Bản thân chữ số đó', 4818, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1156, N'Vị trí của nó', 4818, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1157, N'Bản thân chữ số đó và vị trí của nó ', 4818, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1158, N'Mối quan hệ với các chữ số trước và sau nó', 4818, 0)
GO
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1159, N'Bản thân chữ số đó ', 4819, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1160, N'Vị trí của nó', 4819, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1161, N'Bản thân chữ số đó và vị trí của nó', 4819, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1162, N'Mối quan hệ với các chữ số trước và sau nó', 4819, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1163, N'Mối quan hệ với các chữ số trước và sau nó', 4820, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1164, N'Bản thân chữ số đó', 4820, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1165, N'Vị trí của nó', 4820, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1166, N'Bản thân chữ số đó và vị trí của nó ', 4820, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1167, N'16 bit', 4821, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1168, N'18 bit', 4821, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1169, N'24  bit', 4821, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1170, N'32bit ', 4821, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1171, N'1 bit ', 4822, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1172, N'2bit', 4822, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1173, N'3 bit', 4822, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1174, N'5 bit', 4822, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1175, N'6 bit', 4823, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1176, N'7 bit ', 4823, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1177, N'8 bit', 4823, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1178, N'9 bit', 4823, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1179, N'50 ', 4824, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1180, N'100', 4824, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1181, N'500', 4824, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1182, N'1000', 4824, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1183, N'300', 4825, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1184, N'100 ', 4825, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1185, N'200', 4825, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1186, N'500', 4825, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1187, N'100', 4826, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1188, N'200', 4826, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1189, N'500 ', 4826, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1190, N'1000', 4826, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1191, N'50', 4827, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1192, N'100', 4827, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1193, N'500', 4827, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1194, N'1000 ', 4827, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1195, N'600', 4828, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1196, N'400 ', 4828, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1197, N'600 ', 4829, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1198, N'400', 4829, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1199, N'500', 4829, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1200, N'200', 4829, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1201, N'350', 4830, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1202, N'450 ', 4830, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1203, N'550', 4830, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1204, N'650', 4830, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1205, N'1400', 4831, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1206, N'1500 ', 4831, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1207, N'1600', 4831, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1208, N'1700', 4831, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1209, N'1600', 4832, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1210, N'1500', 4832, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1211, N'1100', 4832, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1212, N'900 ', 4832, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1213, N'1150 ', 4833, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1214, N'1050', 4833, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1215, N'950', 4833, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1216, N'650', 4833, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1217, N'600', 4834, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1218, N'700', 4834, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1219, N'1100', 4834, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1220, N'1200 ', 4834, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1221, N'1150', 4835, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1222, N'1050', 4835, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1223, N'1450 ', 4835, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1224, N'1650', 4835, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1225, N'400', 4836, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1226, N'600 ', 4836, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1227, N'800', 4836, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1228, N'1200', 4836, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1229, N'1400 ', 4837, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1230, N'1450', 4837, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1231, N'1600', 4837, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1232, N'1650', 4837, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1233, N'1846', 4838, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1234, N'2756', 4838, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1235, N'2866', 4838, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1236, N'2976 ', 4838, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1237, N'26,75', 4839, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1238, N'29,75 ', 4839, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1239, N'29,65', 4839, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1240, N'26,65', 4839, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1241, N'18125 ', 4840, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1242, N'18125', 4840, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1243, N'1825', 4840, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1244, N'1825', 4840, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1245, N'18125', 4841, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1246, N'18125 ', 4841, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1247, N'1825', 4841, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1248, N'10625', 4842, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1249, N'18125', 4842, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1250, N'10625 ', 4842, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1251, N'18125', 4842, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1252, N'10125', 4843, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1253, N'10125', 4843, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1254, N'10625', 4843, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1255, N'10625 ', 4843, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1256, N'10625', 4844, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1257, N'18125', 4844, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1258, N'10625 ', 4844, 1)
GO
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1259, N'18125', 4844, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1260, N'13557 ', 4845, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1261, N'15775', 4845, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1262, N'15459', 4845, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1263, N'13267', 4845, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1264, N'15577', 4846, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1265, N'15875', 4846, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1266, N'18459', 4846, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1267, N'17505 ', 4846, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1268, N'13557', 4847, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1269, N'13407 ', 4847, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1270, N'15459', 4847, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1271, N'13267', 4847, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1272, N'13537', 4848, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1273, N'15725', 4848, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1274, N'15605 ', 4848, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1275, N'13287', 4848, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1276, N'100001011(2) ', 4849, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1277, N'101001011(2)', 4849, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1278, N'100101011(2)', 4849, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1279, N'100101011(2)', 4849, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1280, N'10001011(2)', 4850, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1281, N'11100111(2)', 4850, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1282, N'11110111(2) ', 4850, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1283, N'11010111(2)', 4850, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1284, N'100001011(2)', 4851, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1285, N'100011101(2) ', 4851, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1286, N'100101011(2)', 4851, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1287, N'100101001(2)', 4851, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1288, N'100001001(2)', 4852, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1289, N'100011011(2)', 4852, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1290, N'100101011(2)', 4852, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1291, N'100010101(2) ', 4852, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1292, N'1505(8)', 4853, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1293, N'1603(8) ', 4853, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1294, N'1607(8)', 4853, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1295, N'1705(8)', 4853, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1296, N'1533(8) ', 4854, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1297, N'1633(8)', 4854, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1298, N'1637(8)', 4854, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1299, N'1733(8)', 4854, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1300, N'1545(8)', 4855, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1301, N'1403(8)', 4855, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1302, N'1437(8) ', 4855, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1303, N'1565(8)', 4855, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1304, N'1471(8)', 4856, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1305, N'1461(8)', 4856, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1306, N'1451(8)', 4856, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1307, N'1421(8) ', 4856, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1308, N'1541(8) ', 4857, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1309, N'1551(8)', 4857, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1310, N'1561(8)', 4857, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1311, N'1571(8)', 4857, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1312, N'1505(8)', 4858, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1313, N'1511(8) ', 4858, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1314, N'1531(8)', 4858, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1315, N'1551(8)', 4858, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1316, N'11000000(2) ', 4859, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1317, N'10100000(2)', 4859, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1318, N'10010000(2)', 4859, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1319, N'10001000(2)', 4859, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1320, N'11000000(2)', 4860, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1321, N'10111000(2) ', 4860, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1322, N'10011000(2)', 4860, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1323, N'10001000(2)', 4860, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1324, N'10011000(2)', 4861, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1325, N'10101000(2)', 4861, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1326, N'10111110(2) ', 4861, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1327, N'10111010(2)', 4861, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1328, N'10011000(2)', 4862, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1329, N'11100000(2)', 4862, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1330, N'11010000(2)', 4862, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1331, N'11001000(2) ', 4862, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1332, N'10011000(2)', 4863, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1333, N'11000010(2) ', 4863, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1334, N'10010000(2)', 4863, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1335, N'10001000(2)', 4863, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1336, N'10010010(2)', 4864, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1337, N'10100000(2)', 4864, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1338, N'10110110(2) ', 4864, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1339, N'10001000(2)', 4864, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1340, N'1000010(2) ', 4865, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1341, N'1010000(2)', 4865, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1342, N'1010110(2)', 4865, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1343, N'1001000(2)', 4865, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1344, N'10000110(2)', 4866, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1345, N'10011010(2) ', 4866, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1346, N'10101010(2)', 4866, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1347, N'10010010(2)', 4866, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1348, N'10000111(2)', 4867, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1349, N'10100111(2)', 4867, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1350, N'10001111(2) ', 4867, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1351, N'10010111(2)', 4867, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1352, N'10000100(2)', 4868, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1353, N'10100100(2)', 4868, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1354, N'10101100(2)', 4868, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1355, N'10001100(2) ', 4868, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1356, N'10000110(2)', 4869, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1357, N'10000010(2) ', 4869, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1358, N'10100110(2)', 4869, 0)
GO
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1359, N'10010010(2)', 4869, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1360, N'– 1101000111101 x 29 ', 4870, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1361, N'1101000111101 x 29', 4870, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1362, N'– 1101000111101 x 27', 4870, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1363, N'1101000111101 x 27', 4870, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1364, N'– 1101000111101 x 29', 4871, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1365, N'– 1101000111101 x 28 ', 4871, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1366, N'– 1101000111101 x 27', 4871, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1367, N'– 1101000111101 x 26', 4871, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1368, N'– 1101000111101 x 26', 4872, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1369, N'– 1101000111101 x 28', 4872, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1370, N'1101000111101 x 28 ', 4872, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1371, N'1101000111101 x 27', 4872, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1372, N'– 1101000111101 x 27', 4873, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1373, N'1101000101101 x 28', 4873, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1374, N'– 1101000111101 x 27', 4873, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1375, N'1101000101101 x 28 ', 4873, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1376, N'– 1101000111101 x 211 ', 4874, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1377, N'– 1101000110101 x 210', 4874, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1378, N'1101000111101 x 29', 4874, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1379, N'1101000111101 x 28', 4874, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1380, N'– 1101000111101 x 211', 4875, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1381, N'– 1101000110101 x 210 ', 4875, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1382, N'1101000111101 x 29', 4875, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1383, N'1101000111101 x 28', 4875, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1384, N'– 1101000111101 x 212', 4876, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1385, N'– 1101000110101 x 213', 4876, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1386, N'1101000111101 x 214 ', 4876, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1387, N'1101000110101 x 215', 4876, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1388, N'Bus dữ liệu', 4877, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1389, N'Bus dữ liệu và Bus địa chỉ', 4877, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1390, N'Bus dữ liệu và Bus điều khiển', 4877, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1391, N'Bus dữ liệu, Bus địa chỉ và Bus điều khiển ', 4877, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1392, N'Mở rộng chức năng giao tiếp của máy tính', 4878, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1393, N'Liên kết các thành phần trong máy tính ', 4878, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1394, N'Điều khiển các thiết bị ngoại vi', 4878, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1395, N'Biến đổi dạng tín hiệu trong máy tính', 4878, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1396, N'Bus trong bộ vi xử lý', 4879, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1397, N'Bus bộ vi xử lý ', 4879, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1398, N'Bus ngoại vi', 4879, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1399, N'Bus hệ thống', 4879, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1400, N'Bus trong bộ vi xử lý ', 4880, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1401, N'Bus bộ vi xử lý', 4880, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1402, N'Bus ngoại vi', 4880, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1403, N'Bus hệ thống', 4880, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1404, N'Bus trong bộ vi xử lý', 4881, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1405, N'Bus bộ vi xử lý', 4881, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1406, N'Bus ngoại vi', 4881, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1407, N'Bus hệ thống ', 4881, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1408, N'Là đường truyền dẫn giữa các khối của bộ vi xử lý', 4882, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1409, N'Kết nối bộ vi xử lý với bộ nhớ chính, bộ nhớ Cache và các bộ điều khiển ghép nối vào ra ', 4882, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1410, N'Kết nối hệ thống vào ra với bộ vi xử lý', 4882, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1411, N'Đường truyền dẫn giữa CPU và các chip hỗ trợ trung gian', 4882, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1412, N'Chu kỳ Bus thay đổi với từng cặp thiết bị trao đổi dữ liệu', 4883, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1413, N'Dữ liệu được truyền liên tục trong mọi chu kỳ Bus', 4883, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1414, N'Mọi thao tác được thực hiện trong những khoảng thời gian là bội số của chu kỳ Bus ', 4883, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1415, N'Tần số tín hiệu đồng hồ chung thay đổi tùy theo điều kiện của hệ thống', 4883, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1416, N'Dữ liệu được truyền không đồng thời', 4884, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1417, N'Có tín hiệu đồng hồ chung điều khiển hoạt động', 4884, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1418, N'Không có tín hiệu đồng hồ chung điều khiển hoạt động ', 4884, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1419, N'Dữ liệu được truyền đồng thời', 4884, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1420, N'Chu kỳ Bus không thay đổi với mọi cặp thiết bị trao đổi dữ liệu', 4885, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1421, N'Hệ thống được định thời một cách gián đoạn', 4885, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1422, N'Mọi thao tác được thực hiện trong những khoảng thời gian là bội số của chu kỳ Bus', 4885, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1423, N'Việc trao đổi dữ liệu giữa các thiết bị cần có tín hiệu handshake ', 4885, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1424, N'Tận dụng tốt thời gian xử lý của CPU', 4886, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1425, N'Việc điều khiển hoạt động của máy tính dễ dàng hơn ', 4886, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1426, N'Dễ tận dụng các tiến bộ của công nghệ', 4886, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1427, N'Cho phép thay đổi chu kỳ Bus một cách mềm dẻo', 4886, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1428, N'Khi hệ thống có nhiều thiết bị với tốc độ chênh lệch nhau rất lớn ', 4887, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1429, N'Khi hệ thống có nhiều thiết bị với tốc độ chênh lệch nhau rất nhỏ', 4887, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1430, N'Mọi thao tác hầu hết có thời gian xử lý bằng bội số của chu kỳ Bus', 4887, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1431, N'Yêu cầu dễ dàng trong việc điều khiển hoạt động của máy tính', 4887, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1432, N'Khi hệ thống có nhiều thiết bị với tốc độ chênh lệch nhau rất lớn', 4888, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1433, N'Yêu cầu chu kỳ Bus có thể thay đổi với từng cặp thiết bị trao đổi dữ liệu', 4888, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1434, N'Mọi thao tác hầu hết có thời gian xử lý bằng bội số của chu kỳ Bus ', 4888, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1435, N'Yêu cầu tận dụng tốt thời gian xử lý của CPU', 4888, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1436, N'Bus trong bộ vi xử lý', 4889, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1437, N'Bus bộ vi xử lý', 4889, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1438, N'Bus ngoại vi ', 4889, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1439, N'Bus hệ thống', 4889, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1440, N'Là đường truyền dẫn giữa các khối của bộ vi xử lý', 4890, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1441, N'Kết nối bộ vi xử lý với bộ nhớ chính và bộ nhớ Cache', 4890, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1442, N'Kết nối hệ thống vào ra với bộ vi xử lý ', 4890, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1443, N'Đường truyền dẫn giữa CPU và các chip hỗ trợ trung gian', 4890, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1444, N'Là đường truyền dẫn giữa các khối của bộ vi xử lý', 4891, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1445, N'Kết nối bộ vi xử lý với bộ nhớ chính và bộ nhớ Cache', 4891, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1446, N'Kết nối hệ thống vào ra với bộ vi xử lý', 4891, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1447, N'Đường truyền dẫn giữa CPU và các vi mạch hỗ trợ ', 4891, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1448, N'Là đường truyền dẫn giữa các khối của bộ vi xử lý ', 4892, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1449, N'Kết nối bộ vi xử lý với bộ nhớ chính và bộ nhớ Cache', 4892, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1450, N'Kết nối hệ thống vào ra với bộ vi xử lý', 4892, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1451, N'Đường truyền dẫn giữa CPU và các chip hỗ trợ trung gian', 4892, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1452, N'Việc điều khiển hoạt động của máy tính khó khăn hơn', 4893, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1453, N'Việc điều khiển hoạt động của máy tính dễ dàng hơn ', 4893, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1454, N'Thiết kế hệ thống Bus khó khăn hơn', 4893, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1455, N'Dễ tận dụng tiến bộ của công nghệ chế tạo trong chế tạo Bus', 4893, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1456, N'Việc điều khiển hoạt động của máy tínhkhó khăn hơn', 4894, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1457, N'Việc điều khiển hoạt động của máy tính dễ dàng hơn ', 4894, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1458, N'Thiết kế hệ thống Bus dễ dàng hơn', 4894, 0)
GO
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1459, N'Khó tận dụng tiến bộ của công nghệ chế tạo trong chế tạo hệ thống Bus', 4894, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1460, N'3', 4895, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1461, N'3,2', 4895, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1462, N'4 ', 4895, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1463, N'4,2', 4895, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1464, N'3', 4896, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1465, N'3,2 ', 4896, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1466, N'4', 4896, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1467, N'4,2', 4896, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1468, N'Số đường dây dữ liệu của Bus ', 4897, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1469, N'Số thành phần được kết nối tới Bus', 4897, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1470, N'Số Byte dữ liệu được truyền trong một đơn vị thời gian', 4897, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1471, N'Số Bit dữ liệu được truyền trong một đơn vị thời gian', 4897, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1472, N'Tốc độ điều khiển các thành phần của máy tính', 4898, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1473, N'Tốc độ truyền dữ liệu trên Bus ', 4898, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1474, N'Tốc độ phân phối tài nguyên trong máy tính', 4898, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1475, N'Tốc độ cấp phát bộ nhớ cho các thành phần trong máy tính', 4898, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1476, N'Số lượng Byte chuyển qua Bus trong một chu kỳ xung nhịp', 4899, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1477, N'Số lượng Bit chuyển qua Bus trong một chu kỳ xung nhịp', 4899, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1478, N'Số lượng Byte chuyển qua Bus trong một đơn vị thời gian ', 4899, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1479, N'Số lượng Bit chuyển qua Bus trong một đơn vị thời gian', 4899, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1480, N'Dải thông của Bus', 4900, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1481, N'Tần số của Bus ', 4900, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1482, N'Độ rộng của Bus', 4900, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1483, N'Cả ba tham số trên', 4900, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1484, N'Dải thông của Bus ', 4901, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1485, N'Tần số của Bus', 4901, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1486, N'Độ rộng của Bus', 4901, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1487, N'Cả ba tham số trên', 4901, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1488, N'Dải thông của Bus', 4902, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1489, N'Tần số của Bus', 4902, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1490, N'Độ rộng của Bus ', 4902, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1491, N'Cả ba tham số trên', 4902, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1492, N'Bus dữ liệu bên trong bộ vi xử lý', 4903, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1493, N'Bus dữ liệu giữa bộ vi xử lý và bộ nhớ', 4903, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1494, N'Bus địa chỉ ', 4903, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1495, N'Bus điều khiển', 4903, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1496, N'Bus một chiều', 4904, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1497, N'Bus hai chiều với từng đường dây ', 4904, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1498, N'Bus một chiều với từng đường dây nhưng là hai chiều với toàn bộ Bus', 4904, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1499, N'Bus có độ rộng thay đổi', 4904, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1500, N'Bus một chiều ', 4905, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1501, N'Bus hai chiều với từng đường dây', 4905, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1502, N'Bus một chiều với từng đường dây nhưng là hai chiều với toàn bộ Bus', 4905, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1503, N'Bus có độ rộng thay đổi', 4905, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1504, N'Bus một chiều', 4906, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1505, N'Bus hai chiều với từng đường dây', 4906, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1506, N'Bus một chiều với từng đường dây, là hai chiều với toàn bộ Bus ', 4906, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1507, N'Bus có độ rộng thay đổi', 4906, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1508, N'Bus dữ liệu ', 4907, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1509, N'Bus địa chỉ cho bộ nhớ', 4907, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1510, N'Bus địa chỉ cho ngoại vi', 4907, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1511, N'Bus điều khiển', 4907, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1512, N'4 MBs', 4908, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1513, N'8 MBs ', 4908, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1514, N'16 MBs', 4908, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1515, N'32 MBs', 4908, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1516, N'8 MBs', 4909, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1517, N'16 MBs', 4909, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1518, N'33 MBs', 4909, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1519, N'66 MBs ', 4909, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1520, N'Giải quyết vấn đề tranh chấp làm chủ Bus ', 4910, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1521, N'Giải quyết vấn đề cấp phát bộ vi xử lý cho các thao tác', 4910, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1522, N'Giải quyết điều khiển bộ vi xử lý thực hiện các thao tác trao đổi với các thiết bị ngoại vi nối tới Bus', 4910, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1523, N'Giải quyết vấn đề cấp phát bộ nhớ cho các thao tác của các thiết bị ngoại vi nối tới Bus', 4910, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1524, N'Việc phân chia quyền sử dụng Bus do một đơn vị trọng tài Bus duy nhất đảm nhiệm ', 4911, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1525, N'Việc phân chia quyền sử dụng Bus do các thiết bị ngoại vi tự thực hiện', 4911, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1526, N'Đơn vị trọng tài Bus đồng thời làm chủ Bus', 4911, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1527, N'Đơn vị trọng tài Bus nằm ở vị trí trung tâm của máy tính', 4911, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1528, N'Việc phân chia quyền sử dụng Bus do các thiết bị ngoại vi tự thực hiện', 4912, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1529, N'Việc phân chia quyền sử dụng Bus không cần một đơn vị trọng tài Bus riêng biệt ', 4912, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1530, N'Đơn vị trọng tài Bus đồng thời làm chủ Bus', 4912, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1531, N'Đơn vị trọng tài Bus không nằm ở vị trí trung tâm của máy tính', 4912, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1532, N'Các thiết bị nối với đơn vị trọng tài Bus bằng một dây duy nhất', 4913, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1533, N'Các thiết bị ngoại vi dùng chung một đường dây yêu cầu Bus ', 4913, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1534, N'Các thiết bị ngoại vi dùng chung một đường dây cho phép sử dụng Bus', 4913, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1535, N'Mỗi thiết bị ngoại vi có một đường dây yêu cầu Bus riêng', 4913, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1536, N'Các thiết bị nối với đơn vị trọng tài Bus bằng một dây duy nhất', 4914, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1537, N'Các thiết bị ngoại vi được nối tới các đường dây yêu cầu Bus khác nhau ', 4914, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1538, N'Các thiết bị ngoại vi được nối tới tất cả các đường dây yêu cầu Bus', 4914, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1539, N'Mỗi thiết bị ngoại vi có một đường dây yêu cầu Bus riêng', 4914, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1540, N'Trọng tài Bus không tập trung', 4915, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1541, N'Trọng tài Bus tập trung ', 4915, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1542, N'Cả hai kiểu trên', 4915, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1543, N'Không có kiểu nào trong hai kiểu trên', 4915, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1544, N'Trọng tài Bus không tập trung ', 4916, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1545, N'Trọng tài Bus tập trung', 4916, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1546, N'Trọng tài Bus tập trung một mức', 4916, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1547, N'Trọng tài Bus tập trung nhiều mức', 4916, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1548, N'Trọng tài Bus không tập trung', 4917, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1549, N'Trọng tài Bus tập trung', 4917, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1550, N'Trọng tài Bus tập trung một mức ', 4917, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1551, N'Trọng tài Bus tập trung nhiều mức', 4917, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1552, N'Trọng tài Bus không tập trung', 4918, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1553, N'Trọng tài Bus tập trung', 4918, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1554, N'Trọng tài Bus tập trung một mức', 4918, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1555, N'Trọng tài Bus tập trung nhiều mức ', 4918, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1556, N'Chỉ CPU có thể đóng vai trò chủ Bus', 4919, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1557, N'Chỉ các chip vào ra IO có thể đóng vai trò chủ Bus', 4919, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1558, N'CPU hoặc các chip vào ra IO đều có thể đóng vai trò chủ Bus ', 4919, 1)
GO
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1559, N'Chỉ một chip vào ra IO duy nhất được chỉ định đóng vai trò chủ Bus', 4919, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1560, N'8 đường ', 4920, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1561, N'16 đường', 4920, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1562, N'20 đường', 4920, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1563, N'24 đường', 4920, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1564, N'Bus bộ vi xử lý', 4921, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1565, N'Bus địa chỉ', 4921, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1566, N'Bus dữ liệu', 4921, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1567, N'Bus điều khiển ', 4921, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1568, N'Bus địa chỉ', 4922, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1569, N'Bus dữ liệu ', 4922, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1570, N'Bus điều khiển', 4922, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1571, N'Bus bộ vi xử lý', 4922, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1572, N'Bus địa chỉ', 4923, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1573, N'Bus dữ liệu', 4923, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1574, N'Bus điều khiển ', 4923, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1575, N'Bus bộ vi xử lý', 4923, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1576, N'Bus địa chỉ ', 4924, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1577, N'Bus dữ liệu', 4924, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1578, N'Bus điều khiển', 4924, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1579, N'Bus bộ vi xử lý', 4924, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1580, N'Bus địa chỉ', 4925, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1581, N'Bus dữ liệu', 4925, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1582, N'Bus điều khiển ', 4925, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1583, N'Bus bộ vi xử lý', 4925, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1584, N'Chốt dữ liệu', 4926, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1585, N'Chốt địa chỉ ', 4926, 1)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1586, N'Chốt tín hiệu điều khiển', 4926, 0)
INSERT [dbo].[t_answer] ([id_ans], [content_ans], [id_quest], [true_ans]) VALUES (1587, N'Chốt tín hiệu yêu cầu ngắt', 4926, 0)
SET IDENTITY_INSERT [dbo].[t_question] ON 

INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4794, N'  Máy tính đầu tiên ENIAC sử dụng linh kiện nào trong số các linh kiện sau?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4795, N'  Trong các phát biểu sau, phát biểu nào đúng?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4796, N'  Các thành phần cơ bản của một máy tính gồm?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4797, N'  Phần dẻo (Firmware) trong máy tính là gì?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4798, N'  Một ví dụ về phần dẻo (Firmware) trong máy tính là?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4799, N'  Việc trao đổi dữ liệu giữa thiết bị ngoại vi và máy tính được thực hiện qua?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4800, N'  Phần mềm của máy tính là?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4801, N'  Trong các bộ phận sau, bộ phận nào không thuộc bộ xử lý trung tâm?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4802, N'  Trong các bộ phận sau, bộ phận nào không thuộc bộ xử lý trung tâm?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4803, N'  Trong các bộ phận sau, bộ phận nào thuộc bộ xử lý trung tâm?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4804, N'  Tại sao bộ nhớ trong của máy tính được gọi là bộ nhớ truy cập ngẫu nhiên?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4805, N'  Tốc độ đồng hồ hệ thống được đo bằng đơn vị gì?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4806, N'  Người ta đánh giá sự phát triển của máy tính điện tử số qua các giai đoạn dựa vào tiêu chí nào trong các tiêu chí sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4807, N'  Chọn một phương án đúng trong các phương án sau?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4808, N'  Một trong các nội dung của nguyên lý Von Newmann là?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4809, N'  Trong các phát biểu sau, phát biểu nào không thuộc nội dung của nguyên lý Von Newmann?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4810, N'  Trong các phát biểu sau, phát biểu nào thuộc nội dung của nguyên lý Von Newmann?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4811, N'  Phát biểu sau đây thuộc nội dung của nguyên lý Von Newmann?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4812, N'  Theo nguyên lý Von Newmann, để thay đổi thứ tự các lệnh được thực hiện, ta chỉ cần?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4813, N'  Theo nguyên lý Von Newmann, để truy cập một khối dữ liệu, ta cần?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4814, N'  Thông tin được lưu trữ và truyền bên trong máy tính dưới dạng?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4815, N'  Theo nguyên lý Von Newmann, việc cài đặt dữ liệu vào máy tính được thực hiện bằng?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4816, N'  Hãy chỉ ra khẳng định sai trong các khẳng định sau?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4817, N'  Hệ đếm là gì?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4818, N'  Trong hệ đếm thập phân, giá trị của mỗi con số phụ thuộc vào?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4819, N'  Trong hệ đếm La Mã, giá trị của mỗi chữ số phụ thuộc vào?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4820, N'  Trong hệ đếm nhị phân, giá trị của mỗi con số phụ thuộc vào?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4821, N'  Trong số dấu chấm động biểu diễn dạng 3@bit trong máy tính, thành phần định trị có độ dài bao nhiêu bit?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4822, N'  Trong số dấu chấm động biểu diễn dạng 3@bit trong máy tính, thành phần định trị có độ dài bao nhiêu bit?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4823, N'  Trong số dấu chấm động biểu diễn dạng 3@bit trong máy tính, thành phần số mũ có độ dài bao nhiêu bit?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4824, N'  Chữ số L trong hệ đếm La mã tương ứng với giá trị nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4825, N'  Chữ số C trong hệ đếm La mã tương ứng với giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4826, N'  Chữ số D trong hệ đếm La mã tương ứng với giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4827, N'  Chữ số M trong hệ đếm La mã tương ứng với giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4828, N'  Trong hệ La mã số CD nhận giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4829, N'  Trong hệ La mã số DC nhận giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4830, N'  Trong hệ La mã số LD nhận giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4831, N'  Trong hệ La mã số MD nhận giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4832, N'  Trong hệ La mã số CM nhận giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4833, N'  Trong hệ La mã số MCL nhận giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4834, N'  Trong hệ La mã số MCC nhận giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4835, N'  Trong hệ La mã số MLD nhận giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4836, N'  Trong hệ La mã số DLL nhận giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4837, N'  Trong hệ La mã số MCD nhận giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4838, N'  Trong hệ La mã số MMCMLXXVI nhận giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4839, N'  Trong hệ nhị phân số 111011(2) tương ứng với giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4840, N'  Trong hệ đếm bát phân, số 264(8) tương ứng với giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4841, N'  Trong hệ đếm bát phân số 264(8) tương ứng với giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4842, N'  Trong hệ đếm bát phân số 204(8) tương ứng với giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4843, N'  Trong hệ đếm bát phân số 204(8) tương ứng với giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4844, N'  Trong hệ đếm bát phân số 204(8) tương ứng với giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4845, N'  Trong hệ đếm thập lục phân số 34F5(16) tương ứng với giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4846, N'  Trong hệ đếm thập lục phân số 44C5(16) tương ứng với giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4847, N'  Trong hệ đếm thập lục phân số 345F(16) tương ứng với giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4848, N'  Trong hệ đếm thập lục phân (Hexa) số 3CF5(16) tương ứng với giá trị thập phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4849, N'  Số 267(10) tương ứng với giá trị nhị phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4850, N'  Số 247(10) tương ứng với giá trị nhị phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4851, N'  Số 285(10) tương ứng với giá trị nhị phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4852, N'  Số 277(10) tương ứng với giá trị nhị phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4853, N'  Số 899(10) tương ứng với giá trị bát phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4854, N'  Số 859(10) tương ứng với giá trị bát phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4855, N'  Số 799(10) tương ứng với giá trị bát phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4856, N'  Số 785(10) tương ứng với giá trị bát phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4857, N'  Số 865(10) tương ứng với giá trị bát phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4858, N'  Số 841(10) tương ứng với giá trị bát phân nào trong các giá trị sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4859, N'  Tổng hai số nhị phân 1010101(2) và 1101011(2) bằng số nhị phân nào trong các số sau?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4860, N'  Tổng hai số nhị phân 1010101(2) và 1100011(2) bằng số nhị phân nào trong các số sau?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4861, N'  Tổng hai số nhị phân 1010101(2) và 1101001(2) bằng số nhị phân nào trong các số sau?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4862, N'  Tổng hai số nhị phân 1011101(2) và 1101011(2) bằng số nhị phân nào trong các số sau?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4863, N'  Kết quả cộng hai số nhị phân 1010111(2) và 1101011(2) bằng số nhị phân nào trong các số sau?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4864, N'  Tổng hai số nhị phân 1001101(2) và 1101001(2) bằng số nhị phân nào trong các số sau?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4865, N'  Tích hai số nhị phân 110(2) và 1011(2) bằng số nhị phân nào trong các số sau?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4866, N'  Tích hai số nhị phân 1110(2) và 1011(2) bằng số nhị phân nào trong các số sau?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4867, N'  Tích hai số nhị phân 1101(2) và 1011(2) bằng số nhị phân nào trong các số sau?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4868, N'  Tích hai số nhị phân 1110(2) và 1010(2) bằng số nhị phân nào trong các số sau?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4869, N'  Tích hai số nhị phân 1101(2) và 1010(2) bằng số nhị phân nào trong các số sau?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4870, N'  Số dấu chấm động A được lưu trữ trong máy tính dưới dạng 32 bit sau? 11001001110100011110100000000000, hỏi số A nhận giá trị nào sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4871, N'  Số dấu chấm động A được lưu trữ trong máy tính dưới dạng 32 bit sau? 11001000110100011110100000000000, hỏi số A nhận giá trị nào sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4872, N'  Số dấu chấm động A được lưu trữ trong máy tính dưới dạng 32 bit sau? 01001000110100011110100000000000, hỏi số A nhận giá trị nào sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4873, N'  Số dấu chấm động A được lưu trữ trong máy tính dưới dạng 32 bit sau? 01001000110100010110100000000000, hỏi số A nhận giá trị nào sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4874, N'  Số dấu chấm động A được lưu trữ trong máy tính dưới dạng 32 bit sau? 11001011110100011110100000000000, hỏi số A nhận giá trị nào sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4875, N'  Số dấu chấm động A được lưu trữ trong máy tính dưới dạng 32 bit sau? 11001010110100011010100000000000, hỏi số A nhận giá trị nào sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4876, N'  Số dấu chấm động A được lưu trữ trong máy tính dưới dạng 32 bit sau? 01001110110100011110100000000000, hỏi số A nhận giá trị nào sau đây?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4877, N'Bus hệ thống của máy tính bao gồm?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4878, N'Chức năng của hệ thống Bus trong máy tính là gì?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4879, N'Bus nào trong máy tính có nhiệm vụ là đường truyền dẫn giữa CPU và các chip hỗ trợ trung gian?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4880, N'Bus nào trong máy tính có nhiệm vụ là đường truyền dẫn giữa các khối của bộ vi xử lý?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4881, N'Bus nào trong máy tính có nhiệm vụ kết nối bộ vi xử lý với bộ nhớ chính và bộ nhớ Cache?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4882, N'Chức năng của Bus hệ thống trong máy tính là gì?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4883, N'Một trong các đặc điểm của Bus đồng bộ là?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4884, N' ĐẶc điểm quan trọng của Bus không đồng bộ là gì?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4885, N'Trong các đặc điểm sau, đặc điểm nào không phải của Bus đồng bộ?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4886, N'Tại sao trong thực tế Bus đồng bộ được sử dụng rộng rãi hơn Bus không đồng bộ?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4887, N'Trong trường hợp nào nên sử dụng Bus không đồng bộ?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4888, N'Trong trường hợp nào nên sử dụng Bus đồng bộ?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4889, N'Bus nào trong máy tính có nhiệm vụ kết nối các thiết bị vào ra với bộ vi xử lý?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4890, N'Chức năng của Bus ngoại vi trong máy tính là gì?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4891, N'Chức năng của Bus bộ vi xử lý trong máy tính là gì?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4892, N'Chức năng của Bus trong bộ vi xử lý của máy tính là gì?', N'SSS')
GO
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4893, N'So với Bus không đồng bộ, Bus đồng bộ có đặc điểm là?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4894, N'So với Bus đồng bộ, Bus không đồng bộ có đặc điểm là?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4895, N' Trong trường hợp sử dụng Bus đồng bộ, nếu một thao tác có thời gian hoàn thành bằng 3,2 chu kỳ thì trong thực tế nó sẽ được thực hiện trong mấy chu kỳ?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4896, N' Trong trường hợp sử dụng Bus không đồng bộ, nếu một thao tác có thời gian hoàn thành bằng 3,2 chu kỳ thì trong thực tế nó sẽ được thực hiện trong mấy chu kỳ?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4897, N'Độ rộng của Bus được xác định bởi?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4898, N'Tần số Bus đặc trưng cho?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4899, N'Dải thông Bus được xác định bởi?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4900, N'Tham số nào đặc trưng cho tốc độ truyền dữ liệu trên Bus?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4901, N'Tham số nào cho biết số lượng Byte chuyển qua Bus trong một đơn vị thời gian?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4902, N'Tham số nào của Bus cho biết đường dây của nó?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4903, N'Trong các Bus sau, Bus nào là Bus một chiều?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4904, N'Bus dữ liệu trong máy tính là?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4905, N'Bus địa chỉ trong máy tính là?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4906, N'Bus điều khiển trong máy tính là?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4907, N'Trong các Bus sau, Bus nào là Bus hai chiều đối với mỗi đường tín hiệu?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4908, N'Bus ISA có tần số là 8MHz, độ rộng Bus bằng 16 bit, thời gian truyền một khối 16 bit cần 2 chu kỳ. Khi đó dải thông của Bus bằng?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4909, N'Bus PCI có tần số là 33MHz, độ rộng Bus bằng 32 bit, thời gian truyền một khối 32 bit cần 2 chu kỳ. Khi đó dải thông của Bus bằng?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4910, N'Trọng tài Bus có chức năng gì?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4911, N'Đặc điểm của trọng tài Bus tập trung?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4912, N'Đặc điểm của trọng tài Bus không tập trung với multibus?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4913, N'Đặc điểm của trọng tài Bus tập trung một mức?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4914, N'Đặc điểm của trọng tài Bus tập trung nhiều mức?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4915, N'Trong kiểu trọng tài Bus nào thì việc phân chia quyền sử dụng Bus do một đơn vị trọng tài Bus duy nhất đảm nhiệm?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4916, N'Trong kiểu trọng tài Bus nào thì việc phân chia quyền sử dụng Bus không cần một đơn vị trọng tài Bus riêng biệt?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4917, N'Trong kiểu trọng tài Bus nào thì các thiết bị ngoại vi dùng chung một đường dây yêu cầu Bus?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4918, N'Trong kiểu trọng tài Bus nào thì các thiết bị ngoại vi được nối với các đường dây yêu cầu Bus khác nhau?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4919, N'Thành phần nào có thể đóng vai trò chủ Bus (Bus Master)?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4920, N'Bus dữ liệu của bộ vi xử lý Intel 8088 có bao nhiêu đường?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4921, N' Các đường dây IOR, IOW trong các máy tính sử dụng bộ vi xử lý 8088088 thuộc vào Bus nào?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4922, N'Các đường dây D0-D7 trong các máy tính sử dụng bộ vi xử lý Intel 8088088 thuộc vào Bus nào?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4923, N'Các đường dây IOCHCHK, IOCHRDY trong các máy tính sử dụng bộ vi xử lý 8088088 thuộc vào Bus nào?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4924, N'Các đường dây A0-A19 trong các máy tính sử dụng bộ vi xử lý 8088088 thuộc vào Bus nào?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4925, N'Các đường dây DACK0-DACK3 trong các máy tính sử dụng bộ vi xử lý 8088088 thuộc vào Bus nào?', N'SSS')
INSERT [dbo].[t_question] ([id_quest], [content_quest], [id_subject]) VALUES (4926, N'Tín hiệu ALE trong Bus IBM PC có chức năng gì?', N'SSS')
SET IDENTITY_INSERT [dbo].[t_question] OFF
INSERT [dbo].[t_subject] ([id_subject], [content_subject], [number_quest], [timer], [date_test]) VALUES (N'e', N'e', 10, 10, CAST(0x0000A5AD00000000 AS DateTime))
INSERT [dbo].[t_subject] ([id_subject], [content_subject], [number_quest], [timer], [date_test]) VALUES (N'SSS', N'sc s s', 33, 22, CAST(0x0000A5D400000000 AS DateTime))
INSERT [dbo].[t_user] ([msv], [password], [name], [class]) VALUES (N'1', N'1', N'1', N'1')
INSERT [dbo].[t_user] ([msv], [password], [name], [class]) VALUES (N'1481310014', N'123456', N'DươngKaKa', N'D9CNPM')
INSERT [dbo].[t_user] ([msv], [password], [name], [class]) VALUES (N'admin', N'admin', N'admin', N'admin')
INSERT [dbo].[t_user] ([msv], [password], [name], [class]) VALUES (N's', N's', N's', N's')
ALTER TABLE [dbo].[t_answer]  WITH CHECK ADD  CONSTRAINT [FK_t_answer_t_question] FOREIGN KEY([id_quest])
REFERENCES [dbo].[t_question] ([id_quest])
GO
ALTER TABLE [dbo].[t_answer] CHECK CONSTRAINT [FK_t_answer_t_question]
GO
ALTER TABLE [dbo].[t_mark]  WITH CHECK ADD  CONSTRAINT [FK_t_mark_t_subject] FOREIGN KEY([id_subject])
REFERENCES [dbo].[t_subject] ([id_subject])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[t_mark] CHECK CONSTRAINT [FK_t_mark_t_subject]
GO
ALTER TABLE [dbo].[t_mark]  WITH NOCHECK ADD  CONSTRAINT [FK_t_mark_t_user1] FOREIGN KEY([msv])
REFERENCES [dbo].[t_user] ([msv])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[t_mark] NOCHECK CONSTRAINT [FK_t_mark_t_user1]
GO
ALTER TABLE [dbo].[t_question]  WITH CHECK ADD  CONSTRAINT [FK_t_question_t_subject] FOREIGN KEY([id_subject])
REFERENCES [dbo].[t_subject] ([id_subject])
GO
ALTER TABLE [dbo].[t_question] CHECK CONSTRAINT [FK_t_question_t_subject]
GO
USE [master]
GO
ALTER DATABASE [db_question] SET  READ_WRITE 
GO
