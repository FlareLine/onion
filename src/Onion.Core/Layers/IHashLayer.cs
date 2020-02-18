using System.Collections.Generic;
using System.Threading.Tasks;
using Onion.Core.Results;

namespace Onion.Core.Layers
{
	/// <summary>
	/// Interface to represent a key-value table stored under a single top-level layer key.
	/// </summary>
	/// <typeparam name="TValue">Type of value for this layer.</typeparam>
	public interface IHashLayer<TValue> : ILayer
	{
		/// <summary>
		/// Get a single value from a hash using the specified key-subkey pair.
		/// </summary>
		/// <param name="key">Key to lookup.</param>
		/// <param name="subkey">Hash subkey to lookup.</param>
		/// <returns>Value wrapped in an <see cref="IResult{TValue}"/> object.</returns>
		Task<IResult<TValue>> GetAsync(string key, string subkey);

		/// <summary>
		/// Get multiple values from a hash using the specified key and subkey collection.
		/// </summary>
		/// <param name="key">Key to lookup.</param>
		/// <param name="subkeys">Collection of hash subkeys to lookup.</param>
		/// <returns>Dictionary of subkeys to values wrapped in <see cref="IResult{TValue}"/> objects.</returns>
		Task<IDictionary<string, IResult<TValue>>> GetAsync(string key, IEnumerable<string> subkeys);

		/// <summary>
		/// Set a single subkey to the specified value stored in the hash at the provided key.
		/// </summary>
		/// <param name="key">Key for hash.</param>
		/// <param name="subkey">Hash subkey to set.</param>
		/// <param name="value">Value to set.</param>
		/// <returns>Value wrapped in an <see cref="IResult{TValue}"/> object.</returns>
		Task SetAsync(string key, string subkey, TValue value);

		/// <summary>
		/// Set a single subkey to the specified value stored in the hash at the provided key.
		/// </summary>
		/// <param name="key">Key for hash.</param>
		/// <param name="values">Dictionary of subkeys and values to set.</param>
		Task SetAsync(string key, IDictionary<string, TValue> values);
	}
}
