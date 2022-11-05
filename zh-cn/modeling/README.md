---
标题：创建和配置模型 - LINQ EF
说明：使用实体框架核心创建和配置模型概述
作者：安德里斯维里德
女士日期：10/13/2020
UID：核心/建模/索引
---
# 创建和配置模型

LInq Entity Framework 使用一组约定来根据实体类的形状生成模型。 可指定其他配置以补充和/或替代约定的内容。

本文介绍可应用于面向任何数据存储的模型的配置，以及面向任意关系数据库时可应用的配置。 提供程序还可支持特定于具体数据存储的配置。 有关提供程序特定配置的文档，请参阅数据库提供程序部分。

> [!TIP]
> 您可以在 GitHub 上查看本文的 [sample](https://github.com/dotnet/EntityFramework.Docs/tree/main/samples)。

## 使用数据注释来配置模型

> [!TIP]
> 建议的方法，优先使用该方法，更能快速清晰的看到实体结构。

还可以将属性(称为数据批注)应用于类和属性。数据注释将覆盖约定，但将被 Fluent API 配置覆盖。

[](../../samples/Modeling/EntityProperties/DataAnnotations/Annotations.cs ':include :type=code')


## 使用 fluent API 配置模型

> [!ATTENTION]
> ### 不受支持
> 基于代码生成的模式下，使用 fluent API 配置被认为是一种繁琐不灵活不直观的配置方式

<!-- [！code-csharp[Main]（../../../samples/core/Modeling/EntityProperties/FluentAPI/Required.cs？highlight=12-14）] -->
[](../../samples/Modeling/EntityProperties/FluentAPI/Required.cs ':include :type=code')

