using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_lab
{
    class Program
    {
        #region Задача
        /* Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы.
         * Проверить, корректно ли в ней расставлены скобки. 
         * Например, в строке ([]{})[] скобки расставлены корректно, а в строке ([]] — нет. 
         * Указание: задача решается однократным проходом по символам заданной строки слева направо; 
         * для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая, 
         * каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека (при этом скобка с вершины стека снимается);
         * в конце прохода стек должен быть пуст.
         */
        #endregion
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Stack<char> branch = new Stack<char>();
            bool f = true; // флаг на случай если закрывающих скобок больше открывающих
            foreach (char c in str)
            {
                switch (c)
                {
                    case '(':
                        branch.Push(')');
                        break;
                    case '{':
                        branch.Push('}');
                        break;
                    case '[':
                        branch.Push(']');
                        break;
                    case ')':
                        if (branch.Contains(')'))
                            branch.Pop();
                        else
                            f = false;
                        break;
                    case '}':
                        if (branch.Contains('}'))
                            branch.Pop();
                        else
                            f = false;
                        break;
                    case ']':
                        if (branch.Contains(']'))
                            branch.Pop();
                        else
                            f = false;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(((branch.Count() == 0) && f) ? "Скобки расставлены корректно" : "Скобки расставлены некорректно");
            Console.ReadKey();
        }
    }
}
