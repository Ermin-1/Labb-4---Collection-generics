namespace Labb_4___Collection_generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee em1 = new Employee(111, "Ermin", "Male", 35000);
            Employee em2 = new Employee(222, "Sharam", "Male", 34000);
            Employee em3 = new Employee(333, "Markus", "Male", 33000);
            Employee em4 = new Employee(444, "Christian", "Male", 32000);
            Employee em5 = new Employee(555, "Fredrik", "Male", 31000);

            Stack<Employee> Emstack = new Stack<Employee>();
            Emstack.Push(em1);
            Emstack.Push(em2);
            Emstack.Push(em3);
            Emstack.Push(em4);
            Emstack.Push(em5);



        foreach(Employee item in Emstack) 
            {
                Console.WriteLine("Items left in Stack = " + Emstack.Count);
                Console.WriteLine(item + " ");
            
            }

        }
    }
}