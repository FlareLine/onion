using System.Collections.Generic;
using Onion.Core.Layers;

namespace Onion.Core.Providers
{
	/// <summary>
	/// Interface for a provider with a collection of <typeparamref name="TLayer"/> layers.
	/// </summary>
	/// <typeparam name="TLayer">Type of layer for this provider.</typeparam>
	public interface IProvider<TLayer> where TLayer : ILayer
	{
		/// <summary>
		/// Layers <see cref="LinkedList{T}"/> collection.
		/// </summary>
		LinkedList<TLayer> Layers { get; }

		/// <summary>
		/// Key for this provider.
		/// </summary>
		string ProviderKey { get; }
	}
}
