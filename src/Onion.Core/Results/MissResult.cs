namespace Onion.Core.Results
{
	/// <summary>
	/// Class to represent an operation result that failed to return a value.
	/// </summary>
	/// <typeparam name="TValue">Type of value for this result.</typeparam>
	public class MissResult<TValue> : ResultBase<TValue>
	{
		/// <summary>
		/// Create a new <see cref="MissResult{TValue}"/> instance.
		/// </summary>
		public MissResult() : base(false, default)
		{
		}
	}
}
