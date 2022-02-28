using System;
using System.Collections.Generic;

namespace csharp_learning
{
    public class Person
    {
        private string _name;
        private string _surname;
        private long _phoneNumber;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null)
                {
                    _name = value;
                }
                else
                {
                    Console.Write("İsim boş bırakılamaz. Tekrar deneyiniz: ");
                    _name = Console.ReadLine();
                }
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value != null)
                {
                    _surname = value;
                }
                else
                {
                    Console.Write("Soyisim boş bırakılamaz. Tekrar deneyiniz: ");
                    _surname = Console.ReadLine();
                }
            }
        }

        public long PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (value > 0)
                {
                    _phoneNumber = value;
                }
                else
                {
                    Console.Write("Numara boş bırakılamaz. Tekrar deneyiniz: ");
                    _phoneNumber = int.Parse(Console.ReadLine());
                }
            }
        }



        public static List<Person> Contacts = new List<Person>()
            {
                new Person(){
                    Name= "Burak",
                    Surname = "Bilgin",
                    PhoneNumber = 05551234567
                },
                new Person(){
                    Name="Ahmet Hamdi",
                    Surname="Tanpınar",
                    PhoneNumber = 05441234567
                },
                new Person(){
                    Name= "Reşat Nuri",
                    Surname = "Güntekin",
                    PhoneNumber = 05331234567
                },
                new Person(){
                    Name="Halide Edip",
                    Surname = "Adıvar",
                    PhoneNumber = 05423789632
                },
                new Person(){
                    Name = "Nazım Hikmet",
                    Surname ="Ran",
                    PhoneNumber = 05413394557
                },
            };
    }
}