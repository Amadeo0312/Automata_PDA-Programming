using System.Collections;

namespace PushDown_Automata
{
    public class Palindromes
    {
        /// <summary>
        /// Checks if the string input is a Palindrome
        /// </summary>
        /// <param name="s"> String </param>
        /// <returns> true if it is palindrome, otherwise, false </returns>
        public bool IsPalindrome(string s)
        {
            string str = s;
            char[] word = str.ToCharArray();
            int length = word.Length;
            
            Stack stack = new Stack();

            // Push the first half of the string
            for(int i = 0; i < length - (length/2); i++)
            {   
                // If input has odd length then the middle will be skipped
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

            // Pop the Stack if the top of the stack is 
            // the same as the characted being read
            for (int i = length - (length/2); i < length; i++)
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

            // If the stack is Empty then it will be accepted
            if (stack.Count == 0)
                return true;
            else
                return false;    
        }

        /// <summary>
        /// This is a helper method that will display 
        /// the items of the stack every pop or push
        /// </summary>
        /// <param name="stack"> Stack </param>S
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
