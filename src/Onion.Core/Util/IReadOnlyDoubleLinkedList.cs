using System.Collections.Generic;

namespace Onion.Core.Util
{
	/// <summary>
	/// Interface for a read-only double linked list.
	/// </summary>
	/// <typeparam name="TElement">Type of element for this list.</typeparam>
	public interface IReadOnlyDoubleLinkedList<TElement> : IEnumerable<TElement>
	{
		/// <summary>
		/// The current element.
		/// </summary>
		TElement Current { get; }

		/// <summary>
		/// Whether or not this list a next element.
		/// </summary>
		/// <returns>Has a next element or not.</returns>
		bool HasNext();

		/// <summary>
		/// Whether or not this list a previous element.
		/// </summary>
		/// <returns>Has a previous element or not.</returns>
		bool HasPrevious();

		/// <summary>
		/// Try to move the enumerator to the next element.
		/// </summary>
		/// <returns>Move success or failure.</returns>
		bool MoveNext();

		/// <summary>
		/// Try to move the enumerator to the previous element.
		/// </summary>
		/// <returns>Move success or failure.</returns>
		bool MovePrevious();

		/// <summary>
		/// Move the enumerator to the next element.
		/// </summary>
		void Next();

		/// <summary>
		/// Move the enumerator to the previous element.
		/// </summary>
		void Previous();

		/// <summary>
		/// Move the enumerator to the first element.
		/// </summary>
		void MoveFirst();

		/// <summary>
		/// Move the enumerator to the last element.
		/// </summary>
		void MoveLast();
	}
}
