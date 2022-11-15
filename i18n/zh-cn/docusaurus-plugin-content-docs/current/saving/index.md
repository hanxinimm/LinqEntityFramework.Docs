---
sidebar_position: 5001
title: 概述
description: Overview of saving data with Linq Entity Framework
author: ajcvickers
ms.date: 10/27/2016
uid: core/saving/index
---
# 概述

每个上下文实例都有一个 `ChangeTracker`，它负责跟踪需要写入数据库的更改。 更改实体类的实例时，这些更改会记录在 `ChangeTracker` 中，然后在调用 `SaveChanges` 时被写入数据库。 此数据库提供程序负责将更改转换为特定于数据库的操作（例如，关系数据库的 `INSERT`、`UPDATE` 和 `DELETE` 命令）。
