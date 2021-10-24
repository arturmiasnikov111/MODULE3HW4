using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using MODULE3HW4.Models;

namespace MODULE3HW4
{
    public class StarterLinq
    {
        public void Run()
        {
            var data = new User[]
            {
                new User()
                {
                    FirstName = "Oleg",
                    LastName = "Petrov",
                    Number = "0505525806",
                    Age = 20
                },
                new User()
                {
                    FirstName = "Artur",
                    LastName = "Sidorov",
                    Number = "0503525806",
                    Age = 30
                },
                new User()
                {
                    FirstName = "Oleg",
                    LastName = "Kozlov",
                    Number = "0505335806",
                    Age = 40,
                },
                new User()
                {
                    FirstName = "Valentin",
                    LastName = "Petrov",
                    Number = "0505525801",
                    Age = 15
                },
            };
            
            var firstOrDefault = data.FirstOrDefault(x => x?.LastName == "Kozlov");
            var where = data.Where(x => x.Age > 20 && x.Age < 40);
            var select = data.Select(x => x.Age);
            var orderby = data.OrderBy(x => x.Age);
            var any = data.Any(x => x.LastName == "Petrov" && x.Age > 15);
            var dist = data.GroupBy(x => x.Age < 25);
            print(data);
        }

        public void print(IEnumerable<User> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine($"{User.Id} : {item.FirstName} : {item.LastName} : {item.Age} : {item.Number}");}
            }
        }
    }