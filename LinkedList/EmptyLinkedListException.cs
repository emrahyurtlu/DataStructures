using System;
namespace LinkedList
{
	public class EmptyLinkedListException: Exception
	{
		public EmptyLinkedListException(): base("LinkedList is empty.")
		{
		}
	}
}

