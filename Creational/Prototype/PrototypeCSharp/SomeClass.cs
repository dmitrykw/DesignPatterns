using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeCSharp
{
    internal class SomeClass : ICloneable
    {
        private string _someprivatefield = "some pivate data";
        public string SomePublicProperty { get; set; } = "some public data";
        public string Name { get; set; } = "some public name";

        public IdInfo IdInfo = new IdInfo(123);

        public SomeClass ShallowCopy() //Поверхностное копирование - ссылки на объекты ссылочных типов внутри клона будут вести на те же объекты что и у прототипа
        {
            return (SomeClass)this.MemberwiseClone();
        }

        public SomeClass DeepCopy() //Ссылки на объекты ссылочных типов внутри клона теперь тоже будут вести на новые объекты
        {
            SomeClass clone = (SomeClass)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = String.Copy(Name);
            return clone;
        }

        public object Clone()
        {
            return ShallowCopy();
        }



        //Для проверки изменились ли приватное поле
        public void ChangePrivateField(string newvalue)
        {
            _someprivatefield = newvalue;
        }

        public string GetPrivatalue()
        {
            return _someprivatefield;
        }
    }
}
