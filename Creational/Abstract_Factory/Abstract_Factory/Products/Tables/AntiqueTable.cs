using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Products.Tables
{
    internal class AntiqueTable : ITable
    {
        public string GetName()
        {
            return GetTableName();
        }

        public string GetTableName()
        {
            return "Hello, I`m Antique Table";
        }
    }
}
