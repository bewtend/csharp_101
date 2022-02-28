using System;
using System.Collections.Generic;

namespace csharp_learning
{
    public class project_2
    {
        public static void Menu()
        {
            //? Lütfen yapmak istediğiniz işlemi seçiniz :) 
            //? *******************************************
            //? (1) Board Listelemek
            //? (2) Kart Ekle
            //? (3) Kart Güncelle
            //? (3) Kart Silme
            //? (4) Kart Taşı

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Lütfen yapmak istediğiniz işlemin numarasını ya da işlem adını yazarak seçiniz :)");
            Console.ResetColor();
            Console.WriteLine("*******************************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("(1) Board Listelemek");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("(2) Kart Ekle");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("(3) Kart Güncelle");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("(4) Kart Taşı");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("(5) Kart Sil");
            Console.ResetColor();

            Console.Write("İşlem numarası ya da işlemin adı: ");
            string _input = Console.ReadLine();
            if (_input == "1" || _input.Contains("liste")) Board();
            else if (_input == "2" || _input.Contains("ekle")) AddCard();
            else if (_input == "3" || _input.Contains("güncelle")) Update();
            else if (_input == "4" || _input.Contains("taşı")) Move();
            else if (_input == "5" || _input.Contains("sil"))
            {

            }
            else
            {
                Console.Write("Aradığınızı bulamadım tekrar denemek ister misiniz? (y/n) ");
                string _answer = Console.ReadLine();
                if (_answer == "y") Menu();
                else return;
            }

        }
        private static void Board()
        {
            Todo();
            InProgress();
            Done();
            Menu();
        }
        private static void Todo()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("*****************************");
            bool _isBlank = true;
            foreach (var element in Card.BoardList)
            {
                if (element.Categories == CategoriesEnums.TODO.ToString())
                {
                    Console.WriteLine($"Başlık     : {element.Title}");
                    Console.WriteLine($"Açıklama   : {element.Description}");
                    Console.WriteLine($"Atanan Kişi: {element.Responsible}");
                    Console.WriteLine($"Büyüklük   : {element.Dimension}");
                    Console.WriteLine("-");
                    _isBlank = false;
                }
            }
            if (_isBlank == true) Console.WriteLine("~ Burada herhangi bir işlem yok. ~");

            Console.WriteLine();
        }
        private static void InProgress()
        {
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("*****************************");
            bool _isBlank = true;
            foreach (var element in Card.BoardList)
            {
                if (element.Categories == CategoriesEnums.INPROGRESS.ToString())
                {
                    Console.WriteLine($"Başlık     : {element.Title}");
                    Console.WriteLine($"Açıklama   : {element.Description}");
                    Console.WriteLine($"Atanan Kişi: {element.Responsible}");
                    Console.WriteLine($"Büyüklük   : {element.Dimension}");
                    Console.WriteLine("-");
                    _isBlank = false;

                }
            }
            if (_isBlank == true) Console.WriteLine("~ Burada herhangi bir işlem yok. ~");

            Console.WriteLine();
        }
        private static void Done()
        {
            Console.WriteLine("DONE Line");
            Console.WriteLine("*****************************");
            bool _isBlank = true;
            foreach (var element in Card.BoardList)
            {
                if (element.Categories == CategoriesEnums.DONE.ToString())
                {
                    Console.WriteLine($"Başlık     : {element.Title}");
                    Console.WriteLine($"Açıklama   : {element.Description}");
                    Console.WriteLine($"Atanan Kişi: {element.Responsible}");
                    Console.WriteLine($"Büyüklük   : {element.Dimension}");
                    Console.WriteLine("-");
                    _isBlank = false;
                }
            }
            if (_isBlank == true) Console.WriteLine("~ Burada herhangi bir işlem yok. ~");

            Console.WriteLine();
        }
        private static void AddCard()
        {
            Card _input = new Card();
            Console.Write("Başlık giriniz: ");
            _input.Title = Console.ReadLine();
            Console.Write("İçerik giriniz: ");
            _input.Description = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz => XS(1) - S(2) - M(3) - L(4) - XL(5): ");
            var _dimension = Console.ReadLine();
            switch (_dimension)
            {
                case "1":
                    _input.Dimension = Size.XS.ToString();
                    break;
                case "2":
                    _input.Dimension = Size.S.ToString();
                    break;
                case "3":
                    _input.Dimension = Size.M.ToString();
                    break;
                case "4":
                    _input.Dimension = Size.L.ToString();
                    break;
                case "5":
                    _input.Dimension = Size.XL.ToString();
                    break;
                default:
                    Console.WriteLine("Hatalı giriş yaptınız.");
                    return;
            }
            Console.Write("Kişinin numarasını ya da adını giriniz => Test(1), Backend(2), Frontend(3), ProjectManager(4): ");
            var _responsible = Console.ReadLine();
            if (_responsible == "1" || _responsible.ToLower().Contains("test")) _input.Responsible = Owner.Test.ToString();
            else if (_responsible == "2" || _responsible.ToLower().Contains("back")) _input.Responsible = Owner.Backend.ToString();
            else if (_responsible == "3" || _responsible.ToLower().Contains("front")) _input.Responsible = Owner.Frontend.ToString();
            else if (_responsible == "4" || _responsible.ToLower().Contains("project")) _input.Responsible = Owner.Project_Manager.ToString();
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız.");
                Menu();
            }
            Card.BoardList.Add(_input);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kart ekleme başarılı!");
            Console.ResetColor();
            Menu();
        }
        private static void Update()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Güncellemek istediğiniz kartın başlığını giriniz: ");
            string _input = Console.ReadLine().ToLower();
            bool _isNotCard = true;
            foreach (var element in Card.BoardList)
            {
                if (element.Title.ToLower() == _input)
                {
                    Console.Write("Başlık giriniz: ");
                    element.Title = Console.ReadLine();
                    Console.Write("İçerik giriniz: ");
                    element.Description = Console.ReadLine();
                    Console.Write("Büyüklük Seçiniz => XS(1) - S(2) - M(3) - L(4) - XL(5): ");
                    element.Dimension = Console.ReadLine();
                    Console.Write("Kişinin numarasını ya da adını giriniz => Test(1), Backend(2), Frontend(3), ProjectManager(4): ");
                    element.Responsible = Console.ReadLine();
                    _isNotCard = false;
                }
            }
            if (_isNotCard == true)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * Güncellemeyi sonlandırmak için : (1) ");
                Console.WriteLine(" * Yeniden denemek için : (2) ");
                string _answer = Console.ReadLine();
                if (_answer == "1")
                {
                    Console.WriteLine("Güncelleme işlemi iptal edildi.");
                    Menu();
                }
                else if (_answer == "2") Update();
                else
                {
                    Console.WriteLine("Yapmak istediğiniz işlemi anlayamadım. Anasayfaya yönlendiriliyorsunuz.");
                    Menu();
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kart güncelleme başarılı!");
            Console.ResetColor();
            Menu();

        }
        private static void Move()
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Taşımak istediğiniz kartın başlığını giriniz: ");
            string _input = Console.ReadLine().ToLower();
            bool _isNotCard = true;
            foreach (var element in Card.BoardList)
            {
                if (element.Title.ToLower() == _input)
                {
                    Console.WriteLine("Bulunan kart bilgileri");
                    Console.WriteLine("**************************************");
                    Console.WriteLine($"Başlık     : {element.Title}");
                    Console.WriteLine($"Açıklama   : {element.Description}");
                    Console.WriteLine($"Atanan Kişi: {element.Responsible}");
                    Console.WriteLine($"Büyüklük   : {element.Dimension}");
                    Console.WriteLine($"Line       : {element.Categories}");
                    _isNotCard = false;
                    Console.WriteLine();
                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                    List<string> _categories = new List<string>(){
                        CategoriesEnums.BOARD.ToString(),
                        CategoriesEnums.TODO.ToString(),
                        CategoriesEnums.INPROGRESS.ToString(),
                        CategoriesEnums.DONE.ToString(),
                    };
                    if (element.Categories == CategoriesEnums.BOARD.ToString()) _categories.Remove(CategoriesEnums.BOARD.ToString());
                    else if (element.Categories == CategoriesEnums.TODO.ToString()) _categories.Remove(CategoriesEnums.TODO.ToString());
                    else if (element.Categories == CategoriesEnums.INPROGRESS.ToString()) _categories.Remove(CategoriesEnums.INPROGRESS.ToString());
                    else if (element.Categories == CategoriesEnums.DONE.ToString()) _categories.Remove(CategoriesEnums.DONE.ToString());
                    for (int i = 1; i < _categories.Count + 1; i++) Console.WriteLine($"({i}) {_categories[i - 1]}");
                    string _answer = Console.ReadLine();
                    if (_answer == "1") element.Categories = _categories[0];
                    else if (_answer == "2") { element.Categories = _categories[1]; }
                    else if (_answer == "3") { element.Categories = _categories[2]; }
                }
            }
            if (_isNotCard == true)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * Taşımayı sonlandırmak için : (1) ");
                Console.WriteLine(" * Yeniden denemek için : (2) ");
                string _answer = Console.ReadLine();
                if (_answer == "1")
                {
                    Console.WriteLine("Taşıma işlemi iptal edildi.");
                    Menu();
                }
                else if (_answer == "2") Move();
                else
                {
                    Console.WriteLine("Yapmak istediğiniz işlemi anlayamadım. Anasayfaya yönlendiriliyorsunuz.");
                    Menu();
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kart taşıma başarılı!");
            Console.ResetColor();
            Menu();
        }
        private static void Delete()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Silmek istediğiniz kartın başlığını giriniz: ");
            string _input = Console.ReadLine().ToLower();
            bool _isNotCard = true;
            foreach (var element in Card.BoardList)
            {
                if (element.Title.ToLower() == _input)
                {
                    Console.WriteLine("Bulunan kart bilgileri");
                    Console.WriteLine("**************************************");
                    Console.WriteLine($"Başlık     : {element.Title}");
                    Console.WriteLine($"Açıklama   : {element.Description}");
                    Console.WriteLine($"Atanan Kişi: {element.Responsible}");
                    Console.WriteLine($"Büyüklük   : {element.Dimension}");
                    Console.WriteLine($"Line       : {element.Categories}");
                    _isNotCard = false;
                    Console.WriteLine();
                    Console.Write("Silmek istiyor musunuz? (evet/hayır)");
                    string _answer = Console.ReadLine().ToLower();
                    if (_answer.Contains("evet")) Card.BoardList.Remove(element);
                    else if (_answer.Contains("hayır"))
                    {
                        Console.WriteLine("Kart silme işlemi iptal edildi.");
                        Menu();
                    }
                }

            }
            if (_isNotCard == true)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * Silmeyi sonlandırmak için : (1) ");
                Console.WriteLine(" * Yeniden denemek için : (2) ");
                string _answer = Console.ReadLine();
                if (_answer == "1")
                {
                    Console.WriteLine("Silme işlemi iptal edildi.");
                    Menu();
                }
                else if (_answer == "2") Move();
                else
                {
                    Console.WriteLine("Yapmak istediğiniz işlemi anlayamadım. Anasayfaya yönlendiriliyorsunuz.");
                    Menu();
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kart silme başarılı!");
            Console.ResetColor();
            Menu();
        }
    }
}