namespace RegexLexer
{
	/// <summary>
	/// Describes a position in a string.
	/// </summary>
	public class StringPosition
	{
		/// <summary>
		/// Index of the position in the entire string.
		/// </summary>
		public int Index { get; private set; }

		/// <summary>
		/// The number of the line the position is on.
		/// </summary>
		public int Line { get; private set; }

		/// <summary>
		/// Index of the column the position starts at.
		/// </summary>
		public int Column { get; private set; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="index"></param>
		/// <param name="line"></param>
		/// <param name="column"></param>
		public StringPosition(int index, int line, int column)
		{
			this.Index = index;
			this.Line = line;
			this.Column = column;
		}
	}
}
