using System;
using System.Collections.Generic;

namespace TaskAssignmentStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(19);
            stack.Push(11);
            stack.Push(22);
            stack.Push(15);
            stack.Push(13);
          /*  stack.Pop();
            stack.Pop();*/
            stack.Pop();
            Console.WriteLine("Current stack count: " + stack.Size());
            Console.WriteLine("Stack Empty: " + stack.IsEmpty());
            Console.WriteLine("Last item Entered: " + stack.Peek());
            stack.Print();

           
        }
    }

    // Stack:FIFO
//...........14
//............5
//............8
//............6
//............3

    public class Stack<T>
    {
        List<T> stackValues; 
       // public 
       public Stack()
        {
            stackValues = new List<T>();
        }

        // Add - Push()
        public void Push(T val)
        {
            stackValues.Add(val);
        }

        // Remove - Pop() 
        public T Pop()
        {
            if (stackValues.Count <= 0) Console.WriteLine("Stack Empty");
            T temp = stackValues[stackValues.Count - 1];
            // Remove the last value, whish is the first value
            stackValues.RemoveAt(stackValues.Count - 1);
            return temp; 

        }
        // GetCount();
        public int Size() 
        {
            return stackValues.Count;
        }
        // IsEmpty();
        public bool IsEmpty()
        {
            if (stackValues.Count <= 0) return true;
            else return false;
        }

        // GetPeek()
        public T Peek()
        {
            if (stackValues.Count <= 0) Console.WriteLine("Stack is Empty");
            T temp = stackValues[stackValues.Count - 1];
            // Remove the last value, whish is the first value
          //  stackValues.RemoveAt(stackValues.Count - 1);
            return temp;

        }

        public void Print()
        {
            while (Size() > 0)
            {
                Console.WriteLine(Pop());
            }
        }

    }

}
