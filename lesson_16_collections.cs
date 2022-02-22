using System;
using System.Collections.Generic;

namespace csharp_learning
{
    public class lesson_16
    {
        public static void _list()
        {
            List<string> _strList = new List<string>(){
                "Burak","Bilgin",
            };

            _strList.Add("Merhaba"); //? listeye item ekler.

            _strList[0] = "Burak(Edit)"; //? listenin girilen indexine göre girilen değer ile değiştirir

            Console.WriteLine(_strList.Count); //? liste uzunluğunu verir.

            _strList.Remove("Merhaba"); //? girilen değeri listede varsa eğer çıkarır.

            _strList.RemoveAt(1); //? istenilen indexi siler.

            Console.WriteLine(_strList.Contains("Burak")); //? Liste içerisinde item arar.

            Console.WriteLine(_strList.BinarySearch("Burak(Edit)")); //? Item ile hangi indexte olduğunu tespit etmek

            _strList.ForEach(e => Console.WriteLine(e)); //? liste içerisinde foreach döner.

            string[] _hayvanlar = { "At", "Avrat", "Silah" }; //? Array

            List<string> hayvanlar = new List<string>(_hayvanlar); //? List

            hayvanlar.Clear(); //? Listeyi Temizler

            List<Users> userList = new List<Users>() {
                new Users(){
                     Id=0,
                    Name="Burak",
                    Surname="Bilgin"
                },
                new Users(){
                    Id=1,
                    Name="Ali",
                    Surname = "Yıldız",
                }
            };

            userList.Add(new Users()
            {
                Id = 2,
                Name = "Osman",
                Surname = ""
            });


        }

        public class Users
        {
            private int _id;
            private string _name;
            private string _surname;
            public int Id { get => _id; set => _id = value; }
            public string Name { get => _name; set => _name = value; }
            public string Surname { get => _surname; set => _surname = value; }
        }

    }
}