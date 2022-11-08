---
sidebar_position: 2
title: 入门
description: 实体框架核心入门教程
author: 里克-安德森
ms.date: 09/17/2019
uid: 核心/入门/概述/第一个应用
---

# Linq Entity Framework 入门

在本教程中，你将创建一个 .NET Core 控制台应用，该应用使用实体框架核心对 SQLite 数据库执行数据访问。

您可以通过在 Windows 上使用 Visual Studio 或使用 Windows、macOS 或 Linux 上的 .NET Core CLI 来遵循本教程。

[在 GitHub 上查看本文的示例](https://github.com/dotnet/EntityFramework.Docs/tree/main/samples/core/GetStarted)。

## 先决条件

安装以下软件：

<!-- tabs:start -->

### **.NET Core CLI**

* [.NET Core SDK](https://www.microsoft.com/net/download/core)。

### **Visual Studio**

* [Visual Studio 2019 版本 16.3 或更高版本](https://www.visualstudio.com/downloads/) 对于此工作负载：
  * “.NET Core 跨平台开发”（位于“其他工具集”下）


<!-- tabs:end -->

---

## 创建新项目

<!-- tabs:start -->

### **.NET Core CLI**

```dotnetcli
dotnet new console -o EFGetStarted
cd EFGetStarted
```

### **Visual Studio**

* 打开 Visual Studio
* 单击 "创建新项目"
* 选择带有 C# 标记的“控制台应用 (.NET Core)” ，然后单击“下一步”
* 输入“EFGetStarted”作为名称，然后单击“创建”


<!-- tabs:end -->

---

## 安装实体框架核心

若要安装 EF 核心，请为要面向的 Linq Entity Framework 数据库提供程序安装包。本教程使用 SQLite，因为它在 .NET Core 支持的所有平台上运行。有关可用提供程序的列表，请参阅 [数据库提供程序]（外部参照：核心/提供程序/索引）。

<!-- tabs:start -->

### **.NET Core CLI**

```dotnetcli
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
```

### **Visual Studio**

* > NuGet 包管理器>包管理器控制台的工具**
*运行以下命令：

```Powershell
  Install-Package Microsoft.EntityFrameworkCore.Sqlite
  ```

<!-- tabs:end -->

提示：还可以通过右键单击项目并选择“管理 NuGet 包**”来安装包

---

## 创建模型

定义上下文类和组成模型的实体类。

<!-- tabs:start -->

### **.NET Core CLI**

* 在项目目录中，使用以下代码创建 Model.cs

### **Visual Studio**

* 右键单击项目，然后选择“添加”>“类”
* 输入“Model.cs”作为名称，然后单击“添加”
* 将此文件的内容替换为以下代码

<!-- tabs:end -->

---

[](../../samples/GetStarted/Model.cs ':include :type=code')

Linq Entity Framework 还可以 [逆向工程]（xref：core/managing-schemas/scaffolding） 现有数据库中的模型。

提示:为清楚起见，有意简化了此应用程序。 连接字符串不应存储在生产应用程序的代码中。 可能还需要将每个 C# 类拆分为其自己的文件。

## 创建数据库

以下步骤使用[迁移](xref:core/managing-schemas/migrations/index)创建数据库。

<!-- tabs:start -->

### **.NET Core CLI**

* 运行以下命令：

  ```dotnetcli
  dotnet tool install --global dotnet-ef
  dotnet add package Microsoft.EntityFrameworkCore.Design
  dotnet ef migrations add InitialCreate
  dotnet ef database update
  ```

  这会安装 dotnet ef 和设计包，这是对项目运行命令所必需的。 migrations 命令为迁移搭建基架，以便为模型创建一组初始表。 database update 命令创建数据库并向其应用新的迁移。

### **Visual Studio**

* 在“包管理器控制台(PMC)”中，运行以下命令

```Powershell
  Install-Package Microsoft.EntityFrameworkCore.Tools
添加迁移初始创建
更新数据库
  ```

这将安装 [PMC Tools for Linq Entity Framework](xref：core/cli/powershell)。“添加迁移”命令为迁移搭建基架，为模型创建初始表集。“更新数据库”命令创建数据库并对其应用新的迁移。

<!-- tabs:end -->

---

## 创建、读取、更新和删除

* 打开 Program.cs 并将内容替换为以下代码：

[](../../samples/GetStarted/Program.cs ':include :type=code')

## 运行应用

<!-- tabs:start -->


### **.NET Core CLI**

```dotnetcli
dotnet run
```

### **Visual Studio**

“调试”>“开始执行(不调试)”


<!-- tabs:end -->

---

## 后续步骤

* 按照 [ASP.NET Core 教程](/aspnet/core/data/ef-rp/intro) 在 Web 应用中使用 Linq Entity Framework
* 了解有关 [LINQ query expressions](https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/concepts/linq/basic-linq-query-operations) 的更多信息
* [配置模型](xref：core/modeling/index)指定[必需项]和[最大长度]等内容
* 使用 [迁移](xref：core/managing-schemas/migrations/index)在更改模型后更新数据库架构