using System.Text.RegularExpressions;

namespace RegexLexer
{
	/// <summary>
	/// Defines a token the lexer can search for.
	/// </summary>
	public class TokenDefinition
	{
		/// <summary>
		/// The token's identifier.
		/// </summary>
		public string Type { get; private set; }

		/// <summary>
		/// The token's regular expression.
		/// </summary>
		public Regex Regex { get; private set; }

		/// <summary>
		/// Whether the token is ignored in the output.
		/// </summary>
		public bool Ignore { get; private set; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="regex"></param>
		public TokenDefinition(string type, Regex regex)
			: this(type, regex, false)
		{
		}

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="type">The token's identifier.</param>
		/// <param name="regex">The regular expression to search for.</param>
		/// <param name="ignore">Whether the token is ignored in the output.</param>
		public TokenDefinition(string type, Regex regex, bool ignore)
		{
			this.Type = type;
			this.Regex = regex;
			this.Ignore = ignore;
		}
	}
}
