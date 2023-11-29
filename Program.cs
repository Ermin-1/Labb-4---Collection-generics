namespace Labb_4___Collection_generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee em1 = new Employee(111, "Ermin", "Male", 35000);
            Employee em2 = new Employee(222, "Sharam", "Male", 34000);
            Employee em3 = new Employee(333, "Markus", "Male", 33000);
            Employee em4 = new Employee(444, "Eva", "Female", 32000);
            Employee em5 = new Employee(555, "Anna", "Female", 31000);

            Stack<Employee> Emstack = new Stack<Employee>();
            Emstack.Push(em1);
            Emstack.Push(em2);
            Emstack.Push(em3);
            Emstack.Push(em4);
            Emstack.Push(em5);



            foreach (Employee item in Emstack)
            {
                Console.WriteLine($"Items kvar i Stack: {Emstack.Count}");
                Console.WriteLine(item);
            }


            Console.WriteLine("------------------------------");
            Console.WriteLine("Retrive Using Pop Method");
            while (Emstack.Count > 0)
            {
                Console.WriteLine($"Items kvar i Stack: {Emstack.Count}");
                Employee EmployeePOP = Emstack.Pop();
                Console.WriteLine(EmployeePOP);
            }

            Emstack.Push(em1);
            Emstack.Push(em2);
            Emstack.Push(em3);
            Emstack.Push(em4);
            Emstack.Push(em5);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Retrive Using Peek Method");
            var peek1 = Emstack.Peek();
            var peek2 = Emstack.Peek();
            Console.WriteLine(peek1);
            Console.WriteLine(peek2);
            Console.WriteLine($"Items kvar i Stack: {Emstack.Count}");


            Console.WriteLine("------------------------------");
            var itemSearch = em3;
            bool containsItem = Emstack.Contains(itemSearch);
            if (containsItem)
            {
                Console.WriteLine("em3 is in the stack");
            }
            else
            {
                Console.WriteLine("em3 is not in the stack");
            }

            Console.WriteLine("------------------------------");

            List<Employee> Emlist = new List<Employee>();
            Emlist.Add(em1);
            Emlist.Add(em2);
            Emlist.Add(em3);
            Emlist.Add(em4);
            Emlist.Add(em5);

            if (Emlist.Contains(em2))
            {
                Console.WriteLine("Employee2 object exist in the list");
            }
            else
            {
                Console.WriteLine("Emplyee2 object does not exist in the list");
            }


            Console.WriteLine("");

            Employee firstMale = Emlist.Find(s => s.Gender == "Male");

            Console.WriteLine(firstMale);



            Console.WriteLine("");

            List<Employee> allMale = Emlist.FindAll(e => e.Gender == "Male");

            foreach (var employee in allMale)
            {
                Console.WriteLine(employee);
            }
        }
    }
}