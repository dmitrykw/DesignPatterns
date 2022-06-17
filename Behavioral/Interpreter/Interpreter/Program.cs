using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            //Добавляем переменные в контекст
            context.SetVariable("x", 5);
            context.SetVariable("y", 8);
            context.SetVariable("z", 2);


            //Создаем объект для вычисления выражения x + y - z
            //Дерево выражений
            IExpression expression = new SubtractExpression(
                new AddExpression(
                    new NumberExpression("x"), new NumberExpression("y")
                ),
                new NumberExpression("z")
            );

            //Получаем результат интерпретации по дереву выражений
            int result = expression.Interpret(context);


            Console.WriteLine("результат: {0}", result);
            Console.Read();
        }
    }
}
