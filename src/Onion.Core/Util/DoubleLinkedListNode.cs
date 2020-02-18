namespace Onion.Core.Util
{
	/// <summary>
	/// Implementation of a single node of an <see cref="IDoubleLinkedList{TElement}"/>.
	/// </summary>
	/// <typeparam name="TElement">Type of element for this list.</typeparam>
	public class DoubleLinkedListNode<TElement>
	{
		/// <summary>
		/// Previous element.
		/// </summary>
		private DoubleLinkedListNode<TElement> _previous;

		/// <summary>
		/// Next element.
		/// </summary>
		private DoubleLinkedListNode<TElement> _next;

		/// <summary>
		/// Node underlying value.
		/// </summary>
		public TElement Value { get; }

		/// <summary>
		/// Create a new <see cref="DoubleLinkedListNode{TElement}"/> instance with the specified underlying value.
		/// </summary>
		/// <param name="element">Underlying element value.</param>
		public DoubleLinkedListNode(TElement element)
		{
			Value = element;
		}

		/// <summary>
		/// Get the next node.
		/// </summary>
		/// <returns>Next node.</returns>
		public DoubleLinkedListNode<TElement> Next()
		{
			return _next;
		}

		/// <summary>
		/// Get the previous node.
		/// </summary>
		/// <returns>Previous node.</returns>
		public DoubleLinkedListNode<TElement> Previous()
		{
			return _previous;
		}

		/// <summary>
		/// Whether or not this node has a next node.
		/// </summary>
		/// <returns>Has next node or not.</returns>
		public bool HasNext()
		{
			return _next != null;
		}

		/// <summary>
		/// Whether or not this node has a previous node.
		/// </summary>
		/// <returns>Has previous node or not.</returns>
		public bool HasPrevious()
		{
			return _previous != null;
		}

		/// <summary>
		/// Add a node as the next node after this node.
		/// </summary>
		/// <param name="element">Node to add next.</param>
		public void AddNext(TElement element)
		{
			var newNode = new DoubleLinkedListNode<TElement>(element);
			var oldNext = _next;

			newNode._previous = this;

			if (oldNext != null)
			{
				newNode._next = oldNext;
			}

			_next = newNode;
		}

		/// <summary>
		/// Add a node as the previous node before this node.
		/// </summary>
		/// <param name="element">Node to add previous.</param>
		public void AddPrevious(TElement element)
		{
			var newNode = new DoubleLinkedListNode<TElement>(element);
			var oldPrevious = _previous;

			newNode._next = this;

			if (oldPrevious != null)
			{
				newNode._previous = oldPrevious;
			}

			_previous = newNode;
		}
	}
}
