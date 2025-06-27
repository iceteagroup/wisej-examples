using Markdown = Markdig.Markdown;
using System;
using Wisej.Web;
using Markdig;

namespace Wisej.Web.MarkdownEditor;

public partial class Window1 : Form
{

	MarkdownPipeline pipeline;
	private string markdown = @"
# My Markdown Example

## 1. Headers

# H1
## H2
### H3

## 2. Emphasis

*Italic* or _Italic_  
**Bold** or __Bold__  
~~Strikethrough~~

## 3. Lists

### Unordered List
- Item 1
- Item 2
  - Subitem 2.1
  - Subitem 2.2

### Ordered List
1. First
2. Second
3. Third

## 4. Links and Images

[Wisej.NET](https://www.wisej.com)

![Wisej.NET Logo](https://wisej.com/wp-content/uploads/2023/12/wisej-logo-home.png)

## 5. Code

Inline code: `print(""Hello, world!"")`

Block code:
```python
def greet():
    print(""Hello, world!"")
	
	";
	public Window1()
	{
		InitializeComponent();

		pipeline =
			new MarkdownPipelineBuilder()
			.UseBootstrap()
			.UseAutoLinks()
			.UseListExtras()
			.UseCustomContainers()
			.Build();

		this.aceEditor1.Text = markdown;
	}

	private void aceEditor1_TextChanged(object sender, EventArgs e)
	{
		var html = Markdown.ToHtml(aceEditor1.Text, pipeline);
		htmlPanel1.Html = html;
	}
}
