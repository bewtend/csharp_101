using System;
using System.Collections.Generic;

namespace csharp_learning
{
    public class project_1
    {
        public static void firstScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Telefon rehberi uygulamasına hoşgeldiniz...");
            Console.ResetColor();
            Console.WriteLine("**********************************************");
            Console.WriteLine("=> İşlemler;");
            Console.WriteLine("* [1] - Yeni numara kaydetmek");
            Console.WriteLine("* [2] - Numara silmek");
            Console.WriteLine("* [3] - Numara güncelle");
            Console.WriteLine("* [4] - Rehberi göster");
            Console.WriteLine("* [5] - Rehber içerisinde arama yap");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Yapmak istediğiniz işlemi yazarak veya işlem sırasını belirtiniz: ");
            Console.ResetColor();
            string _input = Console.ReadLine();
            if (_input != null) PhoneTransactions(input: _input);
        }


        private static void PhoneTransactions(string input)
        {
            string _transaction = "";
            int _numTransaction = 0;
            bool isInputInt = int.TryParse(input, out _numTransaction);
            if (!isInputInt) _transaction = input;

            if (_transaction != null && _numTransaction <= 0)
            {
                if (_transaction.Contains("yeni"))
                {
                    AddContact();
                }
                else if (_transaction.Contains("sil"))
                {
                    Person.Contacts.ForEach(element => Console.WriteLine($"{element.Name} {element.Surname} - {element.PhoneNumber}"));
                    DeleteContact();
                }
                else if (_transaction.Contains("gün"))
                {
                    Person.Contacts.ForEach(element => Console.WriteLine($"{element.Name} {element.Surname} - {element.PhoneNumber}"));
                    UpdateContact();
                }
                else if (_transaction.Contains("gös"))
                {
                    ShowContact();
                    firstScreen();
                }
                else if (_transaction.Contains("arama"))
                {

                    SearchContact();
                }
                else
                {
                    Console.WriteLine("Geçersiz bir komut girdiniz.");
                    firstScreen();
                }
            }
            else if (_transaction.Length <= 0 && _numTransaction >= 0)
            {
                switch (_numTransaction)
                {
                    case 1:
                        AddContact();
                        return;
                    case 2:
                        Person.Contacts.ForEach(element => Console.WriteLine($"{element.Name} {element.Surname} - {element.PhoneNumber}"));
                        DeleteContact();
                        return;
                    case 3:
                        Person.Contacts.ForEach(element => Console.WriteLine($"{element.Name} {element.Surname} - {element.PhoneNumber}"));
                        UpdateContact();
                        return;
                    case 4:
                        ShowContact();
                        firstScreen();
                        break;
                    case 5:
                        SearchContact();
                        break;
                    default:
                        Console.Write("İşlem numarası dışında bir giriş yaptınız, tekrar deneyiniz: ");
                        PhoneTransactions(Console.ReadLine());
                        return;
                }
            }


        }
        private static void AddContact()
        {
            Console.WriteLine("**********************************************");
            Person _person = new Person();
            Console.WriteLine("Yeni numara kaydetmek için;");
            Console.Write("*Kişinin adını giriniz: ");
            _person.Name = Console.ReadLine();
            Console.Write("*Kişinin soyadını giriniz: ");
            _person.Surname = Console.ReadLine();
            Console.Write("*Kişinin numarasını giriniz: ");
            _person.PhoneNumber = long.Parse(Console.ReadLine());

            Person.Contacts.Add(_person);
            Console.WriteLine("Başarıyla rehbere eklendi.");
            Console.WriteLine("**********************************************");
            firstScreen();
        }
        private static void DeleteContact()
        {
            Console.WriteLine("**********************************************");
            try
            {
                Console.WriteLine("Lütfen silmek istediğiniz kişinin adını ya da soyadınızı yazınız: ");
                string _input = Console.ReadLine().ToLower();
                if (_input.Length > 0)
                {
                    foreach (var element in Person.Contacts)
                    {
                        if (element.Name.ToLower().Contains(_input) || element.Surname.ToLower().Contains(_input))
                        {
                            Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (y/n)", element.Name);
                            char _char = char.Parse(Console.ReadLine().ToLower());
                            if (_char == 'y')
                            {
                                Person.Contacts.Remove(element);
                                Console.WriteLine("Başarıyla silindi.");
                                firstScreen();
                            }
                            else if (_char == 'n') firstScreen();
                            else firstScreen();
                        }
                    }
                    Console.WriteLine("=> Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için: [1]");
                    Console.WriteLine("* Yeniden denemek için:      [2]");
                    var _answer = Console.ReadLine();
                    if (_answer == "1") firstScreen();
                    else if (_answer == "2")
                    {
                        Console.WriteLine("Lütfen silmek istediğiniz kişinin adını ya da soyadınızı yazınız: ");
                        PhoneTransactions("2");
                    }
                    else Console.WriteLine("Yanlış bir karakter girdiniz lütfen tekrar deneyiniz!");
                }
                else
                {
                    Console.WriteLine("Girdiğiniz değer rehber dışında kalıyor. Lütfen tekrar deneyin!");
                    firstScreen();
                }

            }
            catch (System.Exception)
            {
                Console.WriteLine("Yanlış bir karakter girdiniz lütfen tekrar deneyiniz!");
                firstScreen();
            }
        }
        private static void UpdateContact()
        {
            Console.WriteLine("**********************************************");
            try
            {
                Console.WriteLine("Lütfen güncellemek istediğiniz kişinin adını ya da soyadınızı yazınız: ");
                string _input = Console.ReadLine().ToLower();
                if (_input.Length > 0)
                {
                    foreach (var element in Person.Contacts)
                    {
                        if (element.Name.ToLower().Contains(_input) || element.Surname.ToLower().Contains(_input))
                        {
                            Console.Write("*Kişinin adını giriniz: ");
                            element.Name = Console.ReadLine();
                            Console.Write("*Kişinin soyadını giriniz: ");
                            element.Surname = Console.ReadLine();
                            Console.Write("*Kişinin numarasını giriniz: ");
                            element.PhoneNumber = long.Parse(Console.ReadLine());
                            Console.WriteLine("Güncellemeyi onaylıyor musunuz? (y/n)");
                            char _char = char.Parse(Console.ReadLine().ToLower());
                            if (_char == 'y')
                            {
                                Console.WriteLine("Başarıyla güncellendi.");
                                firstScreen();
                            }
                            else if (_char == 'n') firstScreen();
                            else firstScreen();
                        }
                    }
                    Console.WriteLine("=> Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Güncellemeyi sonlandırmak için: [1]");
                    Console.WriteLine("* Yeniden denemek için:           [2]");
                    var _answer = Console.ReadLine();
                    if (_answer == "1") firstScreen();
                    else if (_answer == "2")
                    {
                        Console.WriteLine("Lütfen güncellemek istediğiniz kişinin adını ya da soyadınızı yazınız: ");
                        PhoneTransactions("2");
                    }
                    else Console.WriteLine("Yanlış bir karakter girdiniz lütfen tekrar deneyiniz!");
                }
                else
                {
                    Console.WriteLine("Girdiğiniz değer rehber dışında kalıyor. Lütfen tekrar deneyin!");
                    firstScreen();
                }

            }
            catch (System.Exception)
            {
                Console.WriteLine("Yanlış bir karakter girdiniz lütfen tekrar deneyiniz!");
                firstScreen();
            }
        }
        private static void ShowContact()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach (var element in Person.Contacts)
            {
                Console.WriteLine($"Kişi adı: {element.Name}");
                Console.WriteLine($"Kişi soyadı: {element.Surname}");
                Console.WriteLine($"Telefon numarası: {element.PhoneNumber}");
                Console.WriteLine("-");
            }
        }
        private static void SearchContact()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            try
            {
                int _input = int.Parse(Console.ReadLine());
                if (_input == 1)
                {
                    Console.WriteLine("Lütfen aramak istediğiniz kişinin adını ya da soyadınızı yazınız: ");
                    string _answer = Console.ReadLine().ToLower();
                    foreach (var element in Person.Contacts)
                    {
                        if (element.Name.ToLower().Contains(_answer) || element.Surname.ToLower().Contains(_answer))
                        {
                            Console.WriteLine($"Kişi adı: {element.Name}");
                            Console.WriteLine($"Kişi soyadı: {element.Surname}");
                            Console.WriteLine($"Telefon numarası: {element.PhoneNumber}");
                            Console.WriteLine("-");
                        }
                    }
                    firstScreen();
                }
                else if (_input == 2)
                {
                    Console.WriteLine("Lütfen aramak istediğiniz kişinin numarasını yazınız: ");
                    long _answer = long.Parse(Console.ReadLine());
                    foreach (var element in Person.Contacts)
                    {
                        if (element.PhoneNumber == _answer)
                        {
                            Console.WriteLine($"Kişi adı: {element.Name}");
                            Console.WriteLine($"Kişi soyadı: {element.Surname}");
                            Console.WriteLine($"Telefon numarası: {element.PhoneNumber}");
                            Console.WriteLine("-");
                        }
                    }
                    firstScreen();

                }
                Console.WriteLine("");
                firstScreen();
            }
            catch (System.Exception)
            {
                Console.WriteLine("Yanlış bir karakter girdiniz lütfen tekrar deneyiniz!");
                firstScreen();
            }
        }
    }
}
