using System.Threading.Tasks;

namespace Onion.Core.Layers
{
	/// <summary>
	/// Interface representing a layer with collections of values stored within single keys.
	/// </summary>
	/// <typeparam name="TValue">Type of value for this layer.</typeparam>
	public interface ISetLayer<TValue>
	{
		/// <summary>
		/// Add a value to a set stored under the provided key.
		/// </summary>
		/// <param name="key">Key to add to.</param>
		/// <param name="value">Value to add.</param>
		Task AddAsync(string key, TValue value);

		/// <summary>
		/// Remove a value from a set stored under the provided key.
		/// </summary>
		/// <param name="key">Key to remove from.</param>
		/// <param name="value">Value to remove.</param>
		Task RemoveAsync(string key, TValue value);
	}
}
