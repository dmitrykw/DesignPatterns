﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    internal interface IExpression
    {
        int Interpret(Context context);
    }
}
