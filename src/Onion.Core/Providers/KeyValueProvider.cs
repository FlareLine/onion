using System;
using System.Collections.Generic;
using Onion.Core.Layers;
using Onion.Core.Results;

namespace Onion.Core.Providers
{
	/// <summary>
	/// Abstract <see cref="IKeyValueLayer{TValue}"/> provider.
	/// </summary>
	/// <typeparam name="TValue">Type of value for this provider.</typeparam>
	public abstract class KeyValueProvider<TValue> : IProvider<IKeyValueLayer<TValue>>
	{
		/// <inheritdoc />
		public LinkedList<IKeyValueLayer<TValue>> Layers { get; }

		/// <inheritdoc />
		public abstract string ProviderKey { get; }

		/// <summary>
		/// Create a new <see cref="KeyValueProvider{TValue}"/> with the specified layer collection.
		/// </summary>
		/// <param name="layers">Layer collection.</param>
		protected KeyValueProvider(LinkedList<IKeyValueLayer<TValue>> layers)
		{
			if (layers == null)
			{
				throw new ArgumentNullException(nameof(layers), "Provider layer collection cannot be null.");
			}

			Layers = layers;
		}

		/// <summary>
		/// Create a new <see cref="KeyValueProvider{TValue}"/> with the specified layer collection.
		/// </summary>
		/// <param name="layers">Layer collection.</param>
		protected KeyValueProvider(IEnumerable<IKeyValueLayer<TValue>> layers) : this(new LinkedList<IKeyValueLayer<TValue>>(layers))
		{
		}

		/// <summary>
		/// Create a new <see cref="KeyValueProvider{TValue}"/> with the specified layer collection.
		/// </summary>
		/// <param name="layers">Layer collection.</param>
		protected KeyValueProvider(params IKeyValueLayer<TValue>[] layers) : this(new LinkedList<IKeyValueLayer<TValue>>(layers))
		{
		}

		private IResult<TValue> Fetch(string key)
		{
			if (key == null)
			{
				throw new ArgumentNullException(nameof(key), "Subkey cannot be null.");
			}

			IResult<TValue> result = Result<TValue>.Miss();

			do
			{

			} while (Layers.GetEnumerator().MoveNext());

			return null;
		}
	}
}
