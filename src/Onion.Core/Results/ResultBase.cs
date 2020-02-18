namespace Onion.Core.Results
{
	/// <summary>
	/// Abstract implementation of <see cref="IResult{TValue}"/>.
	/// </summary>
	/// <typeparam name="TValue">Type of value for this result.</typeparam>
	public abstract class ResultBase<TValue> : IResult<TValue>
	{
		/// <inheritdoc />
		public bool Exists { get; }

		/// <inheritdoc />
		public TValue Value { get; }

		/// <summary>
		/// Create a new <see cref="ResultBase{TValue}"/> instance with the specified parameters.
		/// </summary>
		/// <param name="exists">Whether or not the value exists.</param>
		/// <param name="value">The result value, if any.</param>
		protected ResultBase(bool exists, TValue value)
		{
			Exists = exists;
			Value = value;
		}
	}
}
