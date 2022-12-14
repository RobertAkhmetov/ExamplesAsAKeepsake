using System;

namespace ConsoleApp7
{
    class Person
    {
        public string Name { get; }
        public Person(string name) => Name = name;
    }
    class Company
    {
        Person[] personal;
        public Company(Person[] people) => personal = people;

        public Person this[int index]                           // ИНДЕКСАТОР (int)
        {
            get => personal[index]; //возвращение объекта в индексаторе
            set => personal[index] = value; //установка значения по индексу
        }

        public Person this[string strParam]                    // ИНДЕКСАТОР не по порядковому номеру
        {
            get
            {
                switch (strParam)
                {
                    case "special":
                        return new Person("special");
                    default:
                        return new Person("default");
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Person[] myPersonal = { new Person("Robert"), new Person("John"), new Person("Uri") };
                Company myCompany = new Company(myPersonal);
                Console.WriteLine(myCompany[0].Name); //-->Robert

                myCompany[0] = new Person("Henry"); //перезапишем по 0му индексу новую персону
                Console.WriteLine(myCompany[0].Name);//-->Henry

                Console.WriteLine(myCompany["special"].Name); //воспользуемся специальным, не ИНТовым индексом -->special
            }
        }
    }
}
