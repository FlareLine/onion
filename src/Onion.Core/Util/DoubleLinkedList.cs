using System;

namespace Onion.Core.Util
{
	/// <summary>
	/// Mutable implementation of a <see cref="ReadOnlyDoubleLinkedList{TElement}"/>.
	/// </summary>
	/// <typeparam name="TElement">Type of element for this list.</typeparam>
	public class DoubleLinkedList<TElement> : ReadOnlyDoubleLinkedList<TElement>, IDoubleLinkedList<TElement>
	{
		/// <summary>
		/// Create a new empty <see cref="DoubleLinkedList{TElement}"/> instance.
		/// </summary>
		public DoubleLinkedList()
		{
		}

		/// <summary>
		/// Create a new <see cref="DoubleLinkedList{TElement}"/> with the specified node.
		/// </summary>
		/// <param name="node"><see cref="DoubleLinkedListNode{TElement}"/> instance.</param>
		public DoubleLinkedList(DoubleLinkedListNode<TElement> node)
		{
			if (node == null)
			{
				throw new ArgumentNullException(nameof(node), "Node cannot be null.");
			}

			CurrentNode = node;
		}

		/// <summary>
		/// Create a new <see cref="DoubleLinkedList{TElement}"/> with the specified element.
		/// </summary>
		/// <param name="element"><typeparamref name="TElement"/> instance.</param>
		public DoubleLinkedList(TElement element) : this(new DoubleLinkedListNode<TElement>(element))
		{
		}

		/// <inheritdoc />
		public void AddAfter(TElement element)
		{
			if (CurrentNode == null)
			{
				CurrentNode = new DoubleLinkedListNode<TElement>(element);
				return;
			}

			CurrentNode.AddNext(element);
		}

		/// <inheritdoc />
		public void AddBefore(TElement element)
		{
			if (CurrentNode == null)
			{
				CurrentNode = new DoubleLinkedListNode<TElement>(element);
				return;
			}

			CurrentNode.AddPrevious(element);
		}

		/// <inheritdoc />
		public void AddFirst(TElement element)
		{
			if (CurrentNode == null)
			{
				CurrentNode = new DoubleLinkedListNode<TElement>(element);
				return;
			}

			var node = CurrentNode;

			while (node.HasPrevious())
			{
				node = node.Previous();
			}

			node.AddPrevious(element);
		}

		/// <inheritdoc />
		public void AddLast(TElement element)
		{
			if (CurrentNode == null)
			{
				CurrentNode = new DoubleLinkedListNode<TElement>(element);
				return;
			}

			var node = CurrentNode;

			while (node.HasNext())
			{
				node = node.Next();
			}

			node.AddNext(element);
		}

		/// <inheritdoc />
		public IReadOnlyDoubleLinkedList<TElement> AsReadOnly()
		{
			return new DoubleLinkedList<TElement>(CurrentNode);
		}
	}
}
