using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack<string> stack = new Stack<string>(8);
                // добавляем четыре элемента
                stack.Push("Kate");
                stack.Push("Sam");
                stack.Push("Alice");
                stack.Push("Tom");
                stack.ChangePlaces();
                // извлекаем один элемент
                var head = stack.Pop();
                Console.WriteLine(head);    

                // просто получаем верхушку стека без извлечения
                head = stack.Peek();
                Console.WriteLine(head);    
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
