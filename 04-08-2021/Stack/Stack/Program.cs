using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            StackDS values = new StackDS();
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1: Push 2: Pop 3: Display");
            var s = Convert.ToInt32(Console.ReadLine());
            switch(s)
            {
                case 1:
                    {
                        Console.WriteLine("Enter the values");
                        var val = Console.ReadLine();
                        values.stackValue[] += val;
                        break;
                    }

                case 2:
                    {
                        var popElement = values.pop();
                        Console.WriteLine(popElement);
                        break;
                    }
                case 3:
                    {
                        values.printStack();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter the valid key");
                        break;
                    }
                    
            }
        }
    }

    class StackDS
    {
        static int max = 1000;
        public static int top;
        public int[] stackValue = new int[max];
        bool isEmpty()
        {
            return (top < 0);
        }

        public StackDS()
        {
                
        }
        public StackDS(int[] stackValue)
        {
            top = -1;
            this.stackValue = stackValue;
        }

        
        public static StackDS operator + (StackDS data)
        {
            StackDS stacks = new StackDS();
            stacks.stackValue[top++] = Convert.ToInt32(data);
            return stacks;
        }

        public int pop()
        {
            if(top < 0)
            {
                Console.WriteLine("stack underflow");
                return 0;
            }

            else
            {
                int value = stackValue[top--];
                return value;
            }
        }

        public void printStack()
        {
            if(top < 0)
            {
                Console.WriteLine("stack underflow");
            }

            else
            {
                Console.WriteLine("Items in stack are");
                for(int i = top;i>=0;i--)
                {
                    Console.WriteLine(stackValue[i]);
                }
            }
        }

      
    }
}
