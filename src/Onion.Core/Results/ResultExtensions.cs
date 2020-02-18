namespace Onion.Core.Results
{
	/// <summary>
	/// Static helper methods for creating <see cref="IResult{TValue}"/> objects.
	/// </summary>
	public class Result<TValue>
	{
		/// <summary>
		/// Create a new <see cref="MissResult{TValue}"/> object.
		/// </summary>
		/// <returns><see cref="MissResult{TValue}"/> object.</returns>
		public static MissResult<TValue> Miss()
		{
			return new MissResult<TValue>();
		}

		/// <summary>
		/// Create a new <see cref="HitResult{TValue}"/> object.
		/// </summary>
		/// <param name="value">Value for this result.</param>
		/// <returns><see cref="HitResult{TValue}"/> object.</returns>
		public static HitResult<TValue> Hit(TValue value)
		{
			return new HitResult<TValue>(value);
		}
	}
}
