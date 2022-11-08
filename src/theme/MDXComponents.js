import React from 'react';
// 导入原映射
import MDXComponents from '@theme-original/MDXComponents';
import Tabs from '@theme/Tabs';
import TabItem from '@theme/TabItem';
import CodeBlock from '@theme/CodeBlock';
import CodeSnippets from '@site/src/components/CodeSnippets'


export default {
  // 复用默认的映射
  ...MDXComponents,
  Tabs,
  TabItem,
  CodeBlock,
  CodeSnippets,
};