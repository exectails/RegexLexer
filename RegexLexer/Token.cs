namespace RegexLexer
{
	/// <summary>
	/// Represents a token found in a string.
	/// </summary>
	public class Token
	{
		/// <summary>
		/// Position at which the token was found.
		/// </summary>
		public StringPosition Position { get; set; }

		/// <summary>
		/// The token's type, based on the Lexer's definitions.
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// The full token, as it appeared in the string.
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// Creates a new instance.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="value"></param>
		/// <param name="position"></param>
		public Token(string type, string value, StringPosition position)
		{
			this.Type = type;
			this.Value = value;
			this.Position = position;
		}

		/// <summary>
		/// Returns a string representation of the Token.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			var value = this.Value.Replace("\r", "\\r").Replace("\n", "\\n");
			return string.Format("Token: {{ Type: \"{0}\", Value: \"{1}\", Position: {{ Index: \"{2}\", Line: \"{3}\", Column: \"{4}\" }} }}", this.Type, value, this.Position.Index, this.Position.Line, this.Position.Column);
		}
	}
}
