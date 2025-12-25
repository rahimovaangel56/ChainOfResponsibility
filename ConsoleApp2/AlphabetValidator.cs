using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class AlphabetValidator : Validator
    {
        public override bool Validate(string data)
        {
            if (!data.Any(char.IsLetter))
            {
                Console.WriteLine("Ошибка: Данные должны содержать хотя бы одну букву.");
                return false;
            }
            return NextValidator?.Validate(data) ?? true;
        }
    }
}
