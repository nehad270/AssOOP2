namespace AssOOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            Person[] person01 = new Person[]
                   {
                    new Person (20,"mohamed"),
                       new Person(27,"nehad"),
                  new Person(80,"mariam")
                   };

            foreach (Person person in person01)
            {
                Console.WriteLine($"the name is {person.name},and the age is {person.age}");
            } 
            #endregion
        }
    }
}
