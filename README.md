RegexLexer
=============================================================================

A simple lexer for C# using regular expressions.

Example
-----------------------------------------------------------------------------

```csharp
var example = @"
// Some comment
123 + 456
test
";

var lexer = new Lexer();
lexer.AddDefinition(new TokenDefinition("COMMENT", new Regex(@"//[^\r\n]*", RegexOptions.Compiled)));
lexer.AddDefinition(new TokenDefinition("LITERAL", new Regex(@"[+-]?[\d]+", RegexOptions.Compiled)));
lexer.AddDefinition(new TokenDefinition("PLUS", new Regex(@"+", RegexOptions.Compiled)));
lexer.AddDefinition(new TokenDefinition("IDENTIFIER", new Regex(@"[a-z]+[a-z0-9_]*", RegexOptions.Compiled | RegexOptions.IgnoreCase)));
lexer.AddDefinition(new TokenDefinition("LINE_BREAK", new Regex(@"\r?\n", RegexOptions.Compiled)));

var tokens = lexer.Tokenize(example);

// Tokens:
// - LINE_BREAK
// - COMMENT:    // Some comment
// - LINE_BREAK
// - LITERAL:    123
// - PLUS:       +
// - LITERAL:    456
// - LINE_BREAK
// - IDENTIFIER: test
// - LINE_BREAK
```
