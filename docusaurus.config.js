// @ts-check
// Note: type annotations allow type checking and IDEs autocompletion

const lightCodeTheme = require('prism-react-renderer/themes/github');
const darkCodeTheme = require('prism-react-renderer/themes/dracula');

/** @type {import('@docusaurus/types').Config} */
const config = {
  title: 'Linq Entity Framework For C#',
  tagline: 'simple, yet powerful ORM for modeling and insert/update/querying data.',
  url: 'https://em-ide.com',
  baseUrl: '/',
  onBrokenLinks: 'throw',
  onBrokenMarkdownLinks: 'warn',
  favicon: '/images/favicon.ico',

  staticDirectories: ['public', 'static'],

  // GitHub pages deployment config.
  // If you aren't using GitHub pages, you don't need these.
  organizationName: 'hanxinimm', // Usually your GitHub org/user name.
  projectName: 'LINQ EF', // Usually your repo name.

  // Even if you don't use internalization, you can use this field to set useful
  // metadata like html lang. For example, if your site is Chinese, you may want
  // to replace "en" with "zh-Hans".
  i18n: {
    defaultLocale: 'en',
    locales: ['en', 'zh-cn'],
    localeConfigs: {
      'zh-cn': {
        htmlLang: 'zh',
      }
    }
  },

  presets: [
    [
      'classic',
      /** @type {import('@docusaurus/preset-classic').Options} */
      ({
        docs: {
          sidebarPath: require.resolve('./sidebars.js'),
          // Please change this to your repo.
          // Remove this to remove the "edit this page" links.
          editUrl:
            'https://github.com/github0null/eide-docs/tree/master',
          admonitions: {
            tag: '> ',
            keywords: ['[!NOTE]', '[!TIP]', '[!INFO]', '[!WARNING]', '[!ATTENTION]'],
          },
        },
        blog: {
          showReadingTime: true,
          // Please change this to your repo.
          // Remove this to remove the "edit this page" links.
          editUrl:
            'https://github.com/github0null/eide-docs/tree/master',
        },
        theme: {
          customCss: require.resolve('./src/css/custom.css'),
        },
      }),
    ]
  ],

  themeConfig:
    /** @type {import('@docusaurus/preset-classic').ThemeConfig} */
    ({
      colorMode: {
        defaultMode: 'dark'
      },
      navbar: {
        title: `Linq Entity Framework`,
        items: [
          {
            type: 'localeDropdown',
            position: 'left',
          },
          {
            type: 'doc',
            docId: 'intro',
            position: 'left',
            label: 'Docs',
          },
          /* {
            to: '/blog', label: 'Blog', position: 'left'
          }, */
          {
            href: 'https://github.com/github0null/eide',
            label: 'GitHub',
            position: 'right',
          },
        ],
      },
      footer: {
        style: 'dark',
        links: [
          {
            title: 'Docs',
            items: [
              {
                label: 'Tutorial',
                to: '/docs/intro',
              },
            ],
          },
          {
            title: 'Community',
            items: [
              {
                label: 'Github Discussions',
                href: 'https://github.com/github0null/eide/discussions',
              },
              {
                label: 'EIDE Forum',
                href: 'https://discuss.em-ide.com',
              }
            ],
          },
          {
            title: 'More',
            items: [
              {
                label: 'Linq Entity Framework',
                href: 'https://github.com/github0null/eide',
              },
              {
                label: 'SourceForge',
                href: 'https://em-ide.sourceforge.io/'
              },
              {
                label: 'Legacy Docs',
                href: 'https://em-ide.com/legacy-docs',
              },
            ],
          },
        ],
        copyright: `Copyright © ${new Date().getFullYear()} github0null.io`,
      },
      prism: {
        theme: lightCodeTheme,
        darkTheme: darkCodeTheme,
        additionalLanguages: ['ini', 'ignore', 'batch', 'powershell','csharp'],
      },
      algolia: {
        
        appId: 'GQJ2F17TSG',

        apiKey: 'dd4a6214e345cc730aacb7c634a16cba',

        indexName: 'em-ide',
  
        // 可选：见下文
        contextualSearch: true,
  
        // 可选：声明哪些域名需要用 window.location 型的导航而不是 history.push。 适用于 Algolia 配置会爬取多个文档站点，而我们想要用 window.location.href 在它们之间跳转时。
        externalUrlRegex: 'em-ide\\.com',
  
        // 可选：Algolia 搜索参数
        searchParameters: {},
  
        // 可选：搜索页面的路径，默认启用（可以用 `false` 禁用）
        searchPagePath: 'search',
      },
    }),
};

module.exports = config;