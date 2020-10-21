using System;
using OpenTextSummarizer.Interfaces;

namespace OpenTextSummarizer.ContentProviders
{
    public class DirectTextContentProvider : IContentProvider
    {
        public string Content { get; private set; }

        public DirectTextContentProvider(string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                throw new ArgumentNullException("content");
            }
            Content = content;
        }
    }
}