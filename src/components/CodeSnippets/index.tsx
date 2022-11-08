import React, { type ReactNode } from 'react';
import stripIndent from 'strip-indent';
import CodeBlock from '@theme/CodeBlock';

export interface Props {
    readonly children: string;
    readonly className?: string;
    readonly metastring?: string;
    readonly title?: string;
    readonly language?: string;
    readonly showLineNumbers?: boolean;
    readonly fragment: string;
}


const findEndFragment = (startIndex: number, content: string, nested: number) => {
    const nextStartIndex = content.indexOf('#region', startIndex)
    const endIndex = content.indexOf('#endregion', startIndex)

    if (endIndex > 0) {
        if (nextStartIndex == -1 || endIndex < nextStartIndex) {
            if (nested == 0) {
                return endIndex;
            } else {
                return findEndFragment(endIndex + 10, content, nested--)
            }
        } else {
            return findEndFragment(endIndex + 10, content, nested++)
        }
    } else {
        return -1;
    }
}

const getCodeSnippets = (content: string, fragment: string, language?: string) => {
    if (language == 'csharp') {
        const pattern = new RegExp(
            `(?:#region)\\s*${fragment}([\\s\\r]+[\\s\\S]*)`
        )

        const codeContent = (content.match(pattern) || [])[1] || '';
        const endIndex = findEndFragment(0, codeContent, 0);
        if (endIndex > 0) {
            const code = codeContent.substring(0, endIndex);
            return stripIndent(code).trim();
        }
        return '';
    } else {
        const pattern = new RegExp(
            `(?:###|\\/\\/\\/)\\s*\\[${fragment}\\]([\\s\\S]*)(?:###|\\/\\/\\/)\\s*\\[${fragment}\\]`
        );

        return stripIndent((content.match(pattern) || [])[1] || '').trim();
    }
}



export default function CodeSnippets(props: Props): JSX.Element {
    if (props.fragment && props.children) {
        const { fragment, children, ...other } = props;

        const code = getCodeSnippets(children, fragment, props.language);
        return <CodeBlock {...other} >{code}</CodeBlock>;
    }



    return <></>
}

