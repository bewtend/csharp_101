using System;
namespace csharp_learning
{
    public class lesson_19
    {
        public static void _class()
        {
            //* Class
            //? class Example
            //?   public int number
            //?   private Example example(params)
            //? {
            //?     Method(){}    
            //? }

            //* Erişim belirleyiciler 

            //? Public : Her yerden erişilebilir.
            //? Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
            //? Internal : Sadece bulunduğu proje içerisinden erişilebilir
            //? Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.

            //? Example 1
            Employee _employee = new Employee()
            {
                Name = "Burak",
                Surname = "Bilgin",
                Departmant = "Yazılım Geliştirici",
                EmpNo = 1,
            };
            //? Example 2
            Employee _employee2 = new Employee(1, "Burak", "Bilgin", "Yazılım Geliştirici");
            _employee.EmployeeInfo();
            _employee2.EmployeeInfo();
        }
    }

    class Employee
    {
        private int _empNo;
        private string _name;
        private string _surname;
        private string _departmant;

        public Employee(int empNo, string name, string surname, string departmant)
        {
            this._empNo = empNo;
            this._name = name;
            this._surname = surname;
            this._departmant = departmant;
        }

        public Employee() { }
        public int EmpNo { get => _empNo; set => _empNo = value; }
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Departmant { get => _departmant; set => _departmant = value; }

        public void EmployeeInfo()
        {
            Console.WriteLine($"Employee No: {_empNo}");
            Console.WriteLine($"Employee Name: {_name}");
            Console.WriteLine($"Employee Departmant: {_departmant}");
        }
    }
}