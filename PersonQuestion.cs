using System;
using System.Collections.Generic;
using System.Text;

namespace Computershare_Code_Test
{
    class PersonQuestion
    {
        InputChecker iChecker = new InputChecker();
        public string stringInput;
        string Name;
        int Age;

        public PersonQuestion(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
}
