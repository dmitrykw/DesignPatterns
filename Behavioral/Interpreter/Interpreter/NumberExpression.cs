using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    //TerminalExpression: терминальное выражение, реализует метод Interpret()
    //для терминальных символов грамматики. Для каждого символа грамматики создается свой объект TerminalExpression
    internal class NumberExpression : IExpression
    {
        string name; // имя переменной
        public NumberExpression(string variableName)
        {
            name = variableName;
        }
        public int Interpret(Context context)
        {
            return context.GetVariable(name);
        }
    }
}
