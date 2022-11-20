---
title: Managing Database Schemas - Linq EF
description: Overview of strategies for managing your database schemas with Linq Entity Framework
author: bricelam
ms.date: 10/30/2017
uid: core/managing-schemas/index
---
# Managing Database Schemas

Linq EF provides two primary ways of keeping your Linq EF model and database schema in sync. To choose between the two,
decide whether your Linq EF model or the database schema is the source of truth.

If you want your Linq EF model to be the source of truth, use [Migrations][1]. As you make changes to your Linq EF
model, this approach incrementally applies the corresponding schema changes to your database so that it remains
compatible with your Linq EF model.

Use [Reverse Engineering][2] if you want your database schema to be the source of truth. This approach allows you to
scaffold a DbContext and the entity type classes by reverse engineering your database schema into an Linq EF model.

> [!NOTE]
> The [create and drop APIs][3] can also create the database schema from your Linq EF model. However, they are primarily
> for testing, prototyping, and other scenarios where dropping the database is acceptable.

  [1]: xref:core/managing-schemas/migrations/index
  [2]: xref:core/managing-schemas/scaffolding
  [3]: xref:core/managing-schemas/ensure-created
