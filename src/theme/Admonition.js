import React from 'react';
import Admonition from '@theme-original/Admonition';

export default function AdmonitionWrapper(props) {
    const { type, ...other } = props;
    switch (props.type) {
        case '[!TIP]':
            return <Admonition {...other} type='tip' />;
        case '[!NOTE]':
            return <Admonition {...other} type='note' />;
        case '[!INFO]':
            return <Admonition {...other} type='info' />;
        case '[!WARNING]':
            return <Admonition {...other} type='caution' />;
        case '[!ATTENTION]':
            return <Admonition {...other} type='danger' />;
        default:
            return <Admonition {...props} />;
    }

}