using System;

namespace RegexLexer
{
	/// <summary>
	/// An exception that is thrown if an unknown character is found in
	/// a string.
	/// </summary>
	public class UnrecognizedSymbolException : Exception
	{
		/// <summary>
		/// Unknown character in question.
		/// </summary>
		public char Symbol { get; private set; }

		/// <summary>
		/// Position at which the token was found.
		/// </summary>
		public StringPosition Position { get; set; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="symbol"></param>
		/// <param name="line"></param>
		/// <param name="column"></param>
		public UnrecognizedSymbolException(char symbol, StringPosition position)
			: base(string.Format("Unrecognized symbol '{0}' at index {1} (line {2}, column {3}).", symbol, position.Index, position.Line, position.Column))
		{
			this.Symbol = symbol;
			this.Position = position;
		}
	}
}
