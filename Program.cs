namespace AssOOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //Person[] person01 = new Person[]
            //       {
            //        new Person (20,"mohamed"),
            //           new Person(27,"nehad"),
            //      new Person(80,"mariam")
            //       };

            //foreach (Person person in person01)
            //{
            //    Console.WriteLine($"the name is {person.name},and the age is {person.age}");
            //} 
            #endregion

            #region 2

            //Console.Write("please enter X for Point 1: ");
            //double x1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("please enter Y for Point 1: ");
            //double y1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("please enter X for Point 2: ");
            //double x2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("please enter Y for Point 2: ");
            //double y2 = Convert.ToDouble(Console.ReadLine());

            //Point p1 = new Point(x1, y1);
            //Point p2 = new Point(x2, y2);
            //double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));

            //Console.WriteLine($"The distance between the two points is: {distance}");

            #endregion

            #region 3
            //    Person[] person = new Person[3];
            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.Write($"Enter name of person {i + 1}: ");
            //        string name = Console.ReadLine();

            //        Console.Write($"Enter age of person {i + 1}: ");
            //        int age;
            //        while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            //        {
            //            Console.Write("Please enter a valid non-negative age: ");
            //        }

            //        person[i] = new Person(age, name);
            //    }

            //    Person oldest = person[0];

            //    for (int i = 1; i < person.Length; i++)
            //    {
            //        if (person[i].age > oldest.age)
            //        {
            //            oldest = person[i];
            //        }
            //    }

            //    Console.WriteLine($"\nThe oldest person is {oldest.name}, Age: {oldest.age}");
            //}

            #endregion

            #region 4
            Rectangle rec = new Rectangle();
            rec.HeightValue = 4.5;
            rec.WidthValue = 9.3;
            rec.DisplayInfo();

            #endregion



        }
    }
}

