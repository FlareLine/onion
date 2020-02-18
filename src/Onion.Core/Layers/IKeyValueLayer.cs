using System.Collections.Generic;
using System.Threading.Tasks;
using Onion.Core.Results;

namespace Onion.Core.Layers
{
	/// <summary>
	/// A layer supporting a simple key-value storage implementation.
	/// </summary>
	/// <typeparam name="TValue">Type of value for this layer.</typeparam>
	public interface IKeyValueLayer<TValue> : ILayer
	{
		/// <summary>
		/// Get a value stored in the provided key from this layer.
		/// </summary>
		/// <param name="key">Key to lookup.</param>
		/// <returns>Value wrapped in an <see cref="IResult{TValue}"/> object.</returns>
		Task<IResult<TValue>> GetAsync(string key);

		/// <summary>
		/// Get multiple values stored in the specified keys.
		/// </summary>
		/// <param name="keys">Collection of keys to lookup.</param>
		/// <returns>Dictionary of keys to values wrapped in <see cref="IResult{TValue}"/> objects.</returns>
		Task<IDictionary<string, IResult<TValue>>> GetAsync(IEnumerable<string> keys);

		/// <summary>
		/// Set the specified key to the provided value.
		/// </summary>
		/// <param name="key">Key to set.</param>
		/// <param name="value">Value to set.</param>
		Task SetAsync(string key, TValue value);
	}
}
