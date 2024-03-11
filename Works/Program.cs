using System;
using System.Collections.Generic;
using Business.Concrete;
using Entities.Concrete;


namespace Works

{
    class Program
    {
        static void Main(string[] args)
        {
           
            SelamVer();

            


            Person person1 = new Person();
            Console.WriteLine("Adınızı giriniz:");
            person1.FirstName = Console.ReadLine();

            Console.WriteLine("Soyadınızı giriniz:");
            person1.LastName = Console.ReadLine();
            Console.WriteLine("Doğum tarihinizi giriniz:" );
            person1.DateOfBirthYear = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Tc numarasını giriniz:" );


            person1.NationalIdentity = Convert.ToInt64(Console.ReadLine());
           


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();

        }
        static void SelamVer()
        {
            Console.WriteLine("Merhaba!!!");
        }
    }

    
}
