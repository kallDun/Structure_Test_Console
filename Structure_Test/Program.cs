using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_Test
{
    struct Date
    {
        public byte day;
        public byte month;
        public short year;

        public Date(byte day_, byte month_, short year_)
        {
            day = day_;
            month = month_;
            year = year_;
        }

        public override string ToString()
        {
            //return $"{day}.{month}.{year}";
            return day + "." + month + "." + year;
        }
    }

    struct Person
    {
        public string fullName;
        public Date birthDay;
        public char gender;

        public Person(string fullName, Date birthDay, char gender)
        {
            this.fullName = fullName;
            this.birthDay = birthDay;
            this.gender = gender;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Date birthday1 = new Date(10, 12, 2000);
            Person person1 = new Person("Alex Po", birthday1, 'M');

            Date birthday2 = new Date(10, 11, 1998);
            Person person2 = new Person("Andrew L", birthday2, 'M');

            Console.WriteLine(person1.birthDay);
        }
    }
}
