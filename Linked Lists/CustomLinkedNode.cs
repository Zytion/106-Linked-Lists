using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists
{
	class CustomLinkedNode<T>
	{
		/// <summary>
		/// The data stored in this node
		/// </summary>
		public T Data { get; set;}
		/// <summary>
		/// The next node in the list
		/// </summary>
		public CustomLinkedNode<T> NextNode { get; set; }

		/// <summary>
		/// Creates a new Node with a stored data (of type T) and the next Node
		/// </summary>
		/// <param name="data"></param>
		/// <param name="nextNode"></param>
		public CustomLinkedNode(T data, CustomLinkedNode<T> nextNode)
		{
			Data = data;
			NextNode = nextNode;
		}

	}
}
