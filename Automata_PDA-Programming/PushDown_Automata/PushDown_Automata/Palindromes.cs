using System.Collections;

namespace PushDown_Automata
{
    public class Palindromes
    {
        public bool IsPalindrome(string s)
        {
            string str = s;
            char[] word = str.ToCharArray();
            int length = word.Length;
            
            Stack stack = new Stack();

            for(int i = 0; i < length - (length/2); i++)
            {   
                if(i == length/2)
                {
                    Console.WriteLine("Skip one " + word[i]);
                    Display(stack);
                }
                else
                {
                    Console.WriteLine("Push " + word[i]);
                    stack.Push(word[i]);
                    Display(stack);
                }
            }

            for(int i = length - (length/2); i < length; i++)
            {
                if (word[i] == Convert.ToChar(stack.Peek()))
                {
                    Console.WriteLine("pop " + stack.Peek());
                    stack.Pop();
                    Display(stack);
                }
                else
                {
                    Console.WriteLine("Pop failed. Not a Match");
                    Display(stack);
                }
            }

            if (stack.Count == 0)
                return true;
            else
                return false;    
        }

        public void Display(Stack stack)
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Current Stack: Empty\n");
            }
            else
            {
                Console.Write("Current Stack: ");
                foreach (var item in stack)
                {
                    Console.Write(item + " <- ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
