using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists
{
	class Program
	{
		static void Main(string[] args)
		{
			CustomLinkedList<string> customLinkedList = new CustomLinkedList<string>("Start");
			customLinkedList.Add("First");
			customLinkedList.Add("Second");
			customLinkedList.Add("Third");
			customLinkedList.Add("Fourth");
			customLinkedList.Add("Fifth");
            customLinkedList.Add("Sixth");
            customLinkedList.Add("Seventh");
            customLinkedList.Add("Eighth");
            customLinkedList.Add("Ninth");

            Console.WriteLine(customLinkedList.Count);
			
            //Print the data
			for(int i = 0; i < customLinkedList.Count; i++)
				Console.WriteLine(customLinkedList.GetData(i));
            Console.WriteLine("");

            //a.	Try to delete an invalid index (catch the exception and print an error)
            try
            {
                customLinkedList.Remove(1000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //b. Delete the last node
            customLinkedList.Remove(customLinkedList.Count - 1);
            //c. Delete the first node
            customLinkedList.Remove(0);
            //d. Delete a node somewhere in the middle
            customLinkedList.Remove(3);

            //Print the data again.
            Console.WriteLine("");
            for (int i = 0; i < customLinkedList.Count; i++)
                Console.WriteLine(customLinkedList.GetData(i));

            Console.ReadLine();
		}
	}
}
