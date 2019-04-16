﻿using Forma1.myexeption;
using Forma1.validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Forma1.repository
{
    class Racer
    {
        private int id;
        private string name;
        private int age;
        private int salary;

        public Racer(int id, string name, int age, int salary)
        {
            this.id = id;

            try
            {
                NameValidator validator = new NameValidator(name);
                validator.validation();
                this.name = name;
            }
            catch (NameNotValidNameIsEmptyException e)
            {
                Debug.WriteLine(e.Message);
                throw new RacerException(e.Message);
            }
            catch (NameNotValidFirstLetterProblemException e)
            {
                Debug.WriteLine(e.Message);
                throw new RacerException(e.Message);
            }

            this.age = age;
            this.salary = salary;
        }

        public void setName(string name)
        {
            try
            {
                NameValidator validator = new NameValidator(name);
                validator.validation();
                this.name = name;
            }
            catch (NameNotValidNameIsEmptyException e)
            {
                Debug.WriteLine(e.Message);
                throw new RacerException(e.Message);
            }
            catch (NameNotValidFirstLetterProblemException e)
            {
                Debug.WriteLine(e.Message);
                throw new RacerException(e.Message);
            }
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

        public int getId()
        {
            return id;
        }

        public void update(Racer racer)
        {
            id = racer.getId();
            name = racer.getName();
            age = racer.getAge();
            salary = racer.getSalary();
        }

        public override string ToString()
        {
            return $"{id} {name} {age} {salary}";
        }
    }
}