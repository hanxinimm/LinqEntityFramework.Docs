---
sidebar_position: 2001
title: 安装
description: 实体框架核心的安装说明
author: 布里塞拉姆
ms.date: 08/06/2017
uid: 核心/入门/概述/安装
---
# 安装实体框架核心

## 先决条件

* Linq Entity Framework 是一个 [.NET Standard 2.1]（/dotnet/standard/net-standard）/[NET 5.0]/[NET 6.0] 库。因此，Linq Entity Framework 需要支持 .NET Standard 2.0 的 .NET 实现才能运行。Linq Entity Framework 也可以由其他 .NET 标准 2.0 库引用。

* 例如，可以使用 Linq Entity Framework 开发面向 .NET Core 的应用。构建 .NET Core 应用程序需要 [.NET Core SDK]（https://dotnet.microsoft.com/download）。或者，您也可以使用开发环境，如 [Visual Studio]（https://visualstudio.microsoft.com/vs）、[Visual Studio for Mac]（https://visualstudio.microsoft.com/vs/mac） 或 [Visual Studio Code]（https://code.visualstudio.com）。有关详细信息，请查看 [.NET Core 入门]（/dotnet/core/get-started）。

* 您可以使用Linq Entity Framework通过Visual Studio在Windows上开发应用程序。建议使用最新版本的 [Visual Studio]（https://visualstudio.microsoft.com/vs）。

* Linq Entity Framework 可以在其他 .NET 实现上运行，如 [Xamarin]（https://dotnet.microsoft.com/apps/xamarin） 和 .NET Native。但实际上，这些实现具有运行时限制，可能会影响 Linq Entity Framework 在应用上的运行情况。有关详细信息，请参阅 [Linq Entity Framework 支持的 .NET 实现]（xref：core/miscellaneous/platforms）。

* 最后，不同的数据库提供程序可能需要特定的数据库引擎版本、.NET 实现或操作系统。确保 [Linq Entity Framework 数据库提供程序]（xref：core/providers/index） 可用，该提供程序支持适合应用程序的环境。

## 获取实体框架核心运行时

若要将 Linq Entity Framework 添加到应用程序，请为要使用的数据库提供程序安装 NuGet 包。

如果要生成 ASP.NET Core 应用程序，则无需安装内存中和 SQL Server 提供程序。这些提供程序包含在当前版本的 ASP.NET Core 中，以及 Linq Entity Framework 运行时。

若要安装或更新 NuGet 包，可以使用 .NET Core 命令行界面 （CLI）、Visual Studio Package Manager 对话框或 Visual Studio 程序包管理器控制台。

### .NET Core CLI

*从操作系统的命令行使用以下 .NET Core CLI 命令来安装或更新 Linq Entity Framework SQL Server 提供程序：

'''dotnetcli
  dotnet add package Hunter.EntityFramework.SqlServer
  ```

* 您可以在“dotnet add package”命令中使用“-v”modifier指示特定版本。例如，若要安装 Linq Entity Framework 2.2.0 包，请将“-v 2.2.0”追加到命令中。

有关详细信息，请参阅 [.NET 命令行界面 （CLI） 工具]（/dotnet/core/tools/）。

###Visual Studio NuGet Package Manager 对话框

* 从“Visual Studio”菜单中，选择“项目”>“管理 NuGet 包”**

* 单击“浏览”或“更新”选项卡

* 若要安装或更新 SQL Server 提供程序，请选择“Hunter.EntityFramework.SqlServer”包，然后确认。

有关详细信息，请参阅 [NuGet 包管理器对话框]（/nuget/tools/package-manager-ui）。

### Visual Studio NuGet Package Manager Console

* 从“Visual Studio”菜单中，选择“> NuGet 包管理器>包管理器控制台的工具**”

* 若要安装 SQL Server 提供程序，请在程序包管理器控制台中运行以下命令：

'''Powershell
  Install-Package Hunter.EntityFramework.SqlServer
  ```

* 若要更新提供程序，请使用“更新包”命令。

* 若要指定特定版本，请使用“-版本”修饰符。例如，若要安装 Linq Entity Framework 2.2.0 包，请将“-版本 2.2.0”追加到命令

有关详细信息，请参阅 [包管理器控制台]（/nuget/tools/package-manager-console）。

##获取实体框架核心工具

可以安装工具来执行项目中与 Linq Entity Framework 相关的任务，例如创建和应用数据库迁移，或基于现有数据库创建 Linq Entity Framework 模型。

有两组工具可用：

* [.NET Core 命令行界面 （CLI） tools]（xref：core/cli/dotnet） 可以在 Windows、Linux 或 macOS 上使用。这些命令以“dotnet ef”开头。

* [Package Manager Console （PMC） tools]（xref：core/cli/powershell） 在 Windows 上的 Visual Studio 中运行。这些命令以谓词开头，例如“添加迁移”，“更新数据库”。

虽然也可以使用程序包管理器控制台中的“dotnet ef”命令，但建议在使用 Visual Studio 时使用程序包管理器控制台工具：

* 它们会自动处理在 Visual Studio 的 PMC 中选择的当前项目，而无需手动切换目录。

* 命令完成后，它们会自动在 Visual Studio 中打开命令生成的文件。

<a name="cli"></a>

### 获取 .NET Core CLI 工具

.NET Core CLI 工具需要 .NET Core SDK，如前面的 [先决条件]（#prerequisites） 中所述。

* “dotnet ef”必须作为全局或本地工具安装。大多数开发人员更喜欢使用以下命令将 'dotnet ef'安装为全局工具：

'''dotnetcli
  dotnet tool install --global dotnet-ef
  ```

  “dotnet ef”也可以用作本地工具。若要将其用作本地工具，请使用 [工具清单文件]（/dotnet/core/tools/global-tools#install-a-local-tool）还原将其声明为工具依赖项的项目的依赖项。

* 若要更新工具，请使用“dotnet 工具更新”命令。

* 安装最新的“Microsoft.EntityFrameworkCore.Design”软件包。

'''dotnetcli
dotnet 添加包 Microsoft.EntityFrameworkCore.Design
  ```

>[！重要提示]
>始终使用与运行时包的主要版本匹配的工具包版本。
### 获取包管理器控制台工具

若要获取 Linq Entity Framework 的程序包管理器控制台工具，请安装“Microsoft.EntityFrameworkCore.Tools”程序包。例如，从Visual Studio：

'''Powershell
Install-Package Microsoft.EntityFrameworkCore.Tools
```

对于 ASP.NET 核心应用，将自动包含此包。

## 升级到最新的 Linq Entity Framework

* 每当我们发布新版本的 Linq Entity Framework 时，我们还会发布作为 Linq Entity Framework 项目一部分的提供程序的新版本，例如 Hunter.EntityFramework.SqlServer、Microsoft.EntityFrameworkCore.Sqlite 和 Microsoft.EntityFrameworkCore.InMemory。您只需升级到新版本的提供程序即可获得所有改进。

* Linq Entity Framework 以及 SQL Server 和内存中提供程序包含在当前版本的 ASP.NET Core 中。若要将现有 ASP.NET Core 应用程序升级到较新版本的 Linq Entity Framework，请始终升级 ASP.NET Core 的版本。

* 如果需要更新使用第三方数据库提供程序的应用程序，请始终检查与要使用的 Linq Entity Framework 版本兼容的提供程序更新。例如，版本 1.0 的数据库提供程序与 Linq Entity Framework 运行时版本 2.0 不兼容。

* Linq Entity Framework 的第三方提供程序通常不会与 Linq Entity Framework 运行时一起发布修补程序版本。若要将使用第三方提供程序的应用程序升级到 Linq Entity Framework 的修补程序版本，可能需要添加对单个 Linq Entity Framework 运行时组件（如 Microsoft.EntityFrameworkCore 和 Microsoft.EntityFrameworkCore.Relational）的直接引用。