using System;
namespace Stack
{
	public class EmptyStackException: Exception
	{
		public EmptyStackException(): base("Stack is empty!")
		{
		}
    }
}

