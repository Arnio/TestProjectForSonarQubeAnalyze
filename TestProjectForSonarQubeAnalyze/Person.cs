using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectForSonarQubeAnalyze
{
    class Person
    {
        public string name;
        public int age;

        public void Go()
        {
            var x = name + age;
        }

        public void Run()
        {
            var x = name + age;
        }
    }
}
