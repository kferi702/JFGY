﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Model
{
    public class Racer
    {
        private int id;
        private string name;
        private int age;
        private int salary;

        public Racer(int id, string name, int age, int salary)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public int getID()
        {
            return id;
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
            return $"{id}) {name} {age} éves és fizetése {salary}";
        }

        public void update(Racer r)
        {
            this.id = r.getID();
            this.name = r.getName();
            this.age = r.getAge();
            this.salary = r.getSalary();
        }
    }
}