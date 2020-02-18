using System.Threading.Tasks;

namespace Onion.Core.Layers
{
	/// <summary>
	/// Interface for a layer that stores values of the specified type.
	/// </summary>
	public interface ILayer
	{
		/// <summary>
		/// Delete the specified key from storage.
		/// </summary>
		/// <param name="key">Key to delete.</param>
		Task DeleteAsync(string key);
	}
}
