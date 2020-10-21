OpenTextSummarizer
==================

.Net Standard verison of OpenTextSummarizer forked from [vrittis](https://github.com/vrittis).

# Usage

## Basic

To use the original OpenTextSummarizer algorithm, just call the static `Summarize` method on the summarizer. You can pass content through a `IContentProvider` implementation.
There are two implementations matching what existed in the original library, `DirectTextContentProvider` and `FileContentProvider`.
The second argument is a `ISummarizerArguments` implementation, the default one being `SummarizerArguments`.

```csharp
var summarizedDocument = OpenTextSummarizer.Summarizer.Summarize(
	new OpenTextSummarizer.FileContentProvider("TextualData\\AutomaticSummarization.txt"),
	new SummarizerArguments() 
	{
		Language = "en",
		MaxSummarySentences = 5
	});
```