﻿using Markdown.Tag.Asterisks;

namespace Markdown.Tag.Standart
{
    public class Bold : MarkdownTag
    {
        public Bold() : base("__", "bold", new Italic().Translation) { }
    }
}