using System;
namespace csharp_learning
{
    public class lesson_21
    {
        public static void static_class()
        {
            Console.WriteLine($"Customer sayısı: {Customer.Customers}");
            Customer customer = new Customer(name: "Burak", surname: "Bilgin");
            Console.WriteLine($"Customer sayısı: {Customer.Customers}");
            Customer customer1 = new Customer(name: "Burak1", surname: "Bilgin1");
            Console.WriteLine($"Customer sayısı: {Customer.Customers}");
            Customer customer2 = new Customer(name: "Burak2", surname: "Bilgin2");
            Console.WriteLine($"Customer sayısı: {Customer.Customers}");
            Customer customer3 = new Customer(name: "Burak3", surname: "Bilgin3");
            Console.WriteLine($"Customer sayısı: {Customer.Customers}");

        }

        class Customer
        {
            private static int customers;
            public static int Customers { get => customers; }
            private int customerNo;
            private string customerName;
            private string customerSurname;


            static Customer()
            {
                customers = 0;
            }

            public Customer(string name, string surname)
            {
                customerName = name;
                customerSurname = surname;
                customers = Calculate.addition(customers, 1);
                Console.WriteLine("Customer sayısı 1 arttı.");
            }
        }

        public class Calculate
        {
            public static int addition(int num1, int num2)
            {
                return num1 + num2;
            }
        }
    }
}