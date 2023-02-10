using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiProject
{
    public class DataViewModel
    {
        public List<Person> Data { get; set; }
        public DataViewModel() {
            Data = new List<Person>()
            {
                new Person { Name = "David", Height = 170 },
                new Person { Name = "Michael", Height = 96 },
                new Person { Name = "Steve", Height = 65 },
                new Person { Name = "Joel", Height = 182 },
                new Person { Name = "Bob", Height = 134 }
            };
        }
    }
}
