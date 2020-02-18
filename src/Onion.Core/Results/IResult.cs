namespace Onion.Core.Results
{
	/// <summary>
	/// Interface to represent an operation result that may or may not contain a value.
	/// </summary>
	/// <typeparam name="TValue">Type of value for this result.</typeparam>
	public interface IResult<TValue>
	{
		/// <summary>
		/// Whether or not the value exists.
		/// </summary>
		public bool Exists { get; }

		/// <summary>
		/// The result value, if any.
		/// </summary>
		public TValue Value { get; }
	}
}
