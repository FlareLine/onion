using System.Collections;
using System.Collections.Generic;

namespace Onion.Core.Util
{
	/// <summary>
	/// Implementation of a <see cref="IReadOnlyDoubleLinkedList{TElement}"/> instance.
	/// </summary>
	/// <typeparam name="TElement">Type of element for this list.</typeparam>
	public class ReadOnlyDoubleLinkedList<TElement> : IReadOnlyDoubleLinkedList<TElement>
	{
		/// <summary>
		/// Current node for this list.
		/// </summary>
		protected DoubleLinkedListNode<TElement> CurrentNode { get; set; }

		/// <summary>
		/// Current element for this list.
		/// </summary>
		public TElement Current => CurrentNode != null ? CurrentNode.Value : default;

		/// <inheritdoc />
		public bool HasNext()
		{
			return CurrentNode.HasNext();
		}

		/// <inheritdoc />
		public bool HasPrevious()
		{
			return CurrentNode.HasPrevious();
		}

		/// <inheritdoc />
		public bool MoveNext()
		{
			if (HasNext())
			{
				Next();
				return true;
			}

			return false;
		}

		/// <inheritdoc />
		public bool MovePrevious()
		{
			if (HasPrevious())
			{
				Previous();
				return true;
			}

			return false;
		}

		/// <inheritdoc />
		public void Next()
		{
			if (HasNext())
			{
				CurrentNode = CurrentNode.Next();
			}
		}

		/// <inheritdoc />
		public void Previous()
		{
			if (HasPrevious())
			{
				CurrentNode = CurrentNode.Previous();
			}
		}

		/// <inheritdoc />
		public void MoveFirst()
		{
			while (MovePrevious())
			{
			}
		}

		/// <inheritdoc />
		public void MoveLast()
		{
			while (MoveNext())
			{
			}
		}

		/// <inheritdoc />
		public IEnumerator<TElement> GetEnumerator()
		{
			return new DoubleLinkedListEnumerator<TElement>(this);
		}

		/// <inheritdoc />
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
