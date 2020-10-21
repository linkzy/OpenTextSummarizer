using OpenTextSummarizer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTextSummarizer
{
    public class Summarizer
    {
        public static SummarizedDocument Summarize(IContentProvider contentProvider, ISummarizerArguments args)
        {
            if (contentProvider == null || args == null)
            {
                return new SummarizedDocument();
            }

            var engine = new SummarizingEngine();

            var parsedDocument = engine.ParseContent(contentProvider, args.ContentParser());
            var analyzedDocument = engine.AnalyzeParsedContent(parsedDocument, args.ContentAnalyzer());
            var summaryAnalysisDocument = engine.SummarizeAnalysedContent(analyzedDocument, args.ContentSummarizer(), args);

            return summaryAnalysisDocument;
        }
    }
}
