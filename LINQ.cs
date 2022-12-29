using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    /*
     * LINQ:
        LINQ to Objects: применяется для работы с массивами и коллекциями
        LINQ to Entities: используется при обращении к базам данных через технологию Entity Framework
        LINQ to XML: применяется при работе с файлами XML
        LINQ to DataSet: применяется при работе с объектом DataSet
        Parallel LINQ (PLINQ): используется для выполнения параллельных запросов
     */
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill", "Tambi" };
            var selectedPeople = from p in people
                                 where p.ToUpper().StartsWith("T") //фильтрация по критерию
                                 orderby p //упорядочиваем по возрастанию
                                 select p; // выбираем объект в создаваемую коллекцию
            foreach (string person in selectedPeople)
                Console.WriteLine(person);

            //string[] countries = { "Russia", "Albania", "Algeria", "USA", "China" };

            Dictionary<string, int> ratingTable1 = new Dictionary<string, int>()
            {
                {"John",1},
                {"Robert",10},
                {"Nikita",8},
                {"James",3},
                {"Ivan",2},
            };
            
            Dictionary<string, int> ratingTable2 = new Dictionary<string, int>()
            {
                {"John",1},
                {"Robert",10},
                {"Nikita",8},
                {"Joshua",3},
                {"Nikolay",2},
            };


            //var topFromTable = from t in ratingTable where t.Value > 3 orderby t.Value select t;
            var topFromTable = ratingTable1.Where(t => t.Value > 3).OrderByDescending(t => t.Value); //тоже самое, только по уменьшению значения

            var differentTable1Table2 = ratingTable1.Except(ratingTable2); //только те элементы 1 словаря, которых нет во второй
            var similarTable1Table2 = ratingTable1.Intersect(ratingTable2); //только пересекающиеся - схожие элементы из словарей
            var sovietUnionT1T2 = ratingTable1.Union(ratingTable2); //объеденить 2 словаря, повторяющиеся элементы добавить только один раз

            foreach (var t in topFromTable)
                Console.WriteLine(t);

            foreach (var d in differentTable1Table2)
                Console.WriteLine(d);

            Console.WriteLine(differentTable1Table2.Average(x=>x.Value));

            var mixedDict = from rt in ratingTable1     //делаем производный словарь из наших словарей
                            from p in people
                            select new
                            {
                                name = rt.Key,
                                secondName = people[0]
                            };
            foreach (var mlex in mixedDict)
                Console.WriteLine(mlex);

            Console.Read();
        }
    }
}
