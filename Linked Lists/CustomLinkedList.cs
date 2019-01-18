using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists
{
	class CustomLinkedList<T>
	{
		//Number of Nodes in the list
		private int count;
		//Node at the start of the list
		private CustomLinkedNode<T> headNode;
		//Node at the end of the list
		private CustomLinkedNode<T> tailNode;
		
		/// <summary>
		/// The number of Nodes in the list
		/// </summary>
		public int Count {  get {  return count; } }

        /// <summary>
        /// Gets the data at index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get { return GetData(index); }
            set
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException("Index was invalid");

                CustomLinkedNode<T> currentNode = headNode;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.NextNode;
                }

                currentNode.Data = value;
            }
        }

        /// <summary>
        /// Initalizes a new empty LinkedList
        /// </summary>
        public CustomLinkedList()
        {
            headNode = null;
            tailNode = null;
            count = 0;
        }

        /// <summary>
        /// Initalizes a new list by creating a new Node as the head
        /// </summary>
        /// <param name="data"></param>
        public CustomLinkedList(T data)
		{
			headNode = new CustomLinkedNode<T>(data, null);
			tailNode = headNode;
			count = 1;
		}
		/// <summary>
		/// Initalizes a new LinkedList using a premade Node as the head
		/// </summary>
		/// <param name="node"></param>
		public CustomLinkedList(CustomLinkedNode<T> node)
		{
			headNode = node;
			tailNode = node;
			count = 1;
		}
		/// <summary>
		/// Adds the data to a new Node and attaches that Node to the end of the list
		/// </summary>
		/// <param name="data"></param>
		public void Add(T data)
		{
            CustomLinkedNode<T> node = new CustomLinkedNode<T>(data, null);

            if(headNode == null)
            {
                headNode = node;
                tailNode = node;
            }

            tailNode.NextNode = node;
			tailNode = node;
			count++;
		}
		/// <summary>
		/// Iterates trhough the Nodes to find the data at the given index
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public T GetData(int index)
		{
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Index was invalid");

			CustomLinkedNode<T> currentNode = headNode;
			for(int i = 0; i < index; i++)
			{
				currentNode = currentNode.NextNode;
			}
			return currentNode.Data;
		}

        /// <summary>
        /// Takes an integer parameter, which is the index of the data to remove from the list
        /// and returns the actual data that was removed
        /// </summary>
        /// <param name="index"></param>
        /// <returns>The data that was removed</returns>
        public T Remove(int index)
        {
            Console.WriteLine("Removing node at index: " + index);

            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Index was invalid");

            CustomLinkedNode<T> removedNode;

            //If there is only one Node
            if (count == 1)
            {
                removedNode = headNode;
                headNode = null;
                tailNode = null;
            }
            //If removing head Node
            else if (index == 0)
            {
                removedNode = headNode;
                headNode = headNode.NextNode;
            }
            //If removing tail Node
            else if (index == count - 1)
            {
                removedNode = tailNode;
                CustomLinkedNode<T> currentNode = headNode;
                for (int i = 0; i < index - 1; i++)
                {
                    currentNode = currentNode.NextNode;
                }
                currentNode.NextNode = null;
            }
            //If removing a Node in the middle
            else
            {
                CustomLinkedNode<T> currentNode = headNode;
                for (int i = 0; i < index - 1; i++)
                {
                    currentNode = currentNode.NextNode;
                }
                removedNode = currentNode.NextNode;
                currentNode.NextNode = currentNode.NextNode.NextNode;
            }

            count--;
            Console.WriteLine("Removed");
            return removedNode.Data;
        }
	}
}
