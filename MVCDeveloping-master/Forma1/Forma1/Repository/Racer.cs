using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    public class Racer
    {
        private string name;
        private int age;
        private int salary;

        public Racer(string name, int age, int salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setSalary(int salary)
        {
            this.salary = salary;
        }

        public string getName()
        {
            return name;
        }

        public int getAge()
        {
            return age;
        }

        public int getSalary()
        {
            return salary;
        }

        public override string ToString()
        {
            return $"{name} {age} éves és fizetése {salary}";
        }
    }
}
