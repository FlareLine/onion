using System.Collections.Generic;
using System.Threading.Tasks;
using Onion.Core.Models;
using Onion.Core.Results;

namespace Onion.Core.Layers
{
	/// <summary>
	/// Interface to represent a collection of objects ordered by a given score.
	/// </summary>
	/// <typeparam name="TValue">Type of value for this layer.</typeparam>
	public interface ISortedSetLayer<TValue> where TValue : IHasScore
	{
		/// <summary>
		/// Add a value to a set stored under the provided key.
		/// </summary>
		/// <param name="key">Key to add to.</param>
		/// <param name="value">Value to add.</param>
		Task AddAsync(string key, TValue value);

		/// <summary>
		/// Get a map of score to <see cref="IResult{TValue}"/> object based on the key and provided score range.
		/// </summary>
		/// <param name="key">Key to get from.</param>
		/// <param name="minimumScore">Minimum score.</param>
		/// <param name="maximumScore">Maximum score.</param>
		/// <returns>Map of score to <see cref="IResult{TValue}"/>.</returns>
		Task<IDictionary<double, IResult<TValue>>> GetAsync(string key, double minimumScore, double maximumScore);

		/// <summary>
		/// Remove a value from a set stored under the provided key.
		/// </summary>
		/// <param name="key">Key to remove from.</param>
		/// <param name="value">Value to remove.</param>
		Task RemoveAsync(string key, TValue value);
	}
}
