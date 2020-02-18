using System.Collections;
using System.Collections.Generic;

namespace Onion.Core.Util
{
	/// <summary>
	/// An <see cref="IEnumerator{TElement}"/> instance for <see cref="IReadOnlyDoubleLinkedList{TElement}"/> instances.
	/// </summary>
	/// <typeparam name="TElement">Type of element for this enumerator.</typeparam>
	public class DoubleLinkedListEnumerator<TElement> : IEnumerator<TElement>
	{
		/// <summary>
		/// Underlying enumerator <see cref="IReadOnlyDoubleLinkedList{TElement}"/> instance.
		/// </summary>
		private readonly IReadOnlyDoubleLinkedList<TElement> _list;

		/// <summary>
		/// Whether or not this enumerator has started.
		/// </summary>
		private bool _started;

		/// <summary>
		/// Current element.
		/// </summary>
		public TElement Current => _list.Current;

		/// <summary>
		/// Explicit interface implementation.
		/// </summary>
		object IEnumerator.Current => _started ? Current : default;

		/// <summary>
		/// Create a new <see cref="DoubleLinkedListEnumerator{TElement}"/> with the specified underlying list.
		/// </summary>
		/// <param name="list">Underlying list.</param>
		public DoubleLinkedListEnumerator(IReadOnlyDoubleLinkedList<TElement> list)
		{
			_list = list;
		}

		/// <summary>
		/// Move this enumerator to the next element.
		/// </summary>
		/// <returns>Whether or not the next element existed.</returns>
		public bool MoveNext()
		{
			if (_started) return _list.MoveNext();

			_started = true;
			return true;
		}

		/// <summary>
		/// Reset this enumerator.
		/// </summary>
		public void Reset()
		{
			_started = false;
			_list.MoveFirst();
		}

		/// <summary>
		/// Dispose this enumerator.
		/// </summary>
		public void Dispose()
		{
		}
	}
}
