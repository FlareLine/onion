namespace Onion.Core.Results
{
	/// <summary>
	/// Class to represent an operation result that returned some value.
	/// </summary>
	/// <typeparam name="TValue">Type of value for this result.</typeparam>
	public class HitResult<TValue> : ResultBase<TValue>
	{
		/// <summary>
		/// Create a new <see cref="HitResult{TValue}"/> with the specified value.
		/// </summary>
		/// <param name="value">The result value, if any.</param>
		public HitResult(TValue value) : base(true, value)
		{
		}
	}
}
