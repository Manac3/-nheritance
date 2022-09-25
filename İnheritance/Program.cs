namespace Inheritance1
{
    internal class Program //interfaceler abstracttır yani newlenemez ama classlar concrete(somut) dir newlenir
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Mehmet",
                Surname = "Anaç"
            };
            person.DisplayName();

            Student student = new Student()
            {
                Department = "Biology",
                Name = "Mehmet",
                Surname = "Anaç"
            };
            student.DisplayName();

            Person insan = new Customer()
            {
                CardNo = "**** **** **** **22",
                Name = "Seda",
                Surname = "Anac"
            };
            insan.DisplayName();
            Console.WriteLine(((Customer)insan).CardNo); //casting: tip dönüşüm
            Console.WriteLine((insan as Customer).CardNo);

            Person[] people = new Person[3]
            {
                new Student()
                {
                    Department = "Yazılım",
                    Name = "Ali",
                    Surname ="anaç"
                },
                new Customer()
                {
                    CardNo = "**** **12",
                    Name = "Zeynep",
                    Surname = "Uzun"
                },
                new ExtendedCustomer()
                {
                    Address = "Ankara",
                    Name = "Mehmet",
                    Surname = "Anaç",
                    CardNo = "**** **45"
                }
            };
            foreach (Person p in people)
            {
                p.DisplayName();
            }

            ExtendedCustomer extended = (people[2] as ExtendedCustomer);
            extended.DisplayName();
            Console.WriteLine(extended.CardNo + " - " + extended.Address);
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public void DisplayName()
        {
            Console.WriteLine($"{Name} {Surname}");
        }
    }
    class Student : Person // bunun adı kalıtım demektir //sub, child
    {
        public string Department { get; set; }
    }
    class Customer : Person //is a relationship // sub, child
    {
        public string CardNo { get; set; }
    }
    sealed class ExtendedCustomer : Customer, IAddress //mühürlendi bu class artık miras alınamaz bu classtan
    {
        public string Address { get; set; }
    }

    interface IAddress
    {
        string Address { get; set; }
    }
}