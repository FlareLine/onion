namespace Onion.Core.Util
{
	/// <summary>
	/// Mutable <see cref="IReadOnlyDoubleLinkedList{TElement}"/> implementation.
	/// </summary>
	/// <typeparam name="TElement">Type of element for this list.</typeparam>
	public interface IDoubleLinkedList<TElement> : IReadOnlyDoubleLinkedList<TElement>
	{
		/// <summary>
		/// Add an element after the current element.
		/// </summary>
		/// <param name="element">Element to add.</param>
		void AddAfter(TElement element);

		/// <summary>
		/// Add an element before the current element.
		/// </summary>
		/// <param name="element">Element to add.</param>
		void AddBefore(TElement element);

		/// <summary>
		/// Add an element at the start of this list.
		/// </summary>
		/// <param name="element">Element to add.</param>
		void AddFirst(TElement element);

		/// <summary>
		/// Add an element at the end of this list.
		/// </summary>
		/// <param name="element">Element to add.</param>
		void AddLast(TElement element);

		/// <summary>
		/// Convert this instance to a <see cref="IReadOnlyDoubleLinkedList{TElement}"/> instance.
		/// </summary>
		/// <returns><see cref="IReadOnlyDoubleLinkedList{TElement}"/> instance.</returns>
		IReadOnlyDoubleLinkedList<TElement> AsReadOnly();
	}
}
