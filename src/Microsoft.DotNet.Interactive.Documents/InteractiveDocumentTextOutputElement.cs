﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DotNet.Interactive.Documents
{
    public class InteractiveDocumentTextOutputElement : InteractiveDocumentOutputElement
    {
        public string Text { get; }

        public InteractiveDocumentTextOutputElement(string text)
        {
            Text = text;
        }
    }
}