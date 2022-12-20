using Practice.Models;

#region Task 1

//int age = 22;

//int result = CountOfMarried(age);

//Console.WriteLine(result);

//static Person[] GetPersons()
//{
//    Person person1 = new Person("Ali", "Talibov", 21, true);
//    Person person2 = new Person("Cavid", "Bashirov", 29, false);
//    Person person3 = new Person("Rustam", "Hacizade", 25, true);
//    Person person4 = new Person("Teymur", "Isayev", 23, false);

//    return new Person[] { person1, person2, person3, person4 };
//}

//static int CountOfMarried(int age)
//{
//    Person[] persons = GetPersons();

//    int count = 0;

//    foreach (Person person in persons)
//    {
//        if (person.Age > age && person.IsMarried)
//        {
//            count++;
//        }
//    }

//    return count;
//}

#endregion

#region Task2

//GetFilteredOrders(200, DateTime.Now);

//static Order[] GetOrders()
//{
//    Order order1 = new Order(400, DateTime.Now);
//    Order order2 = new Order(100, new DateTime(2022, 08, 10));
//    Order order3 = new Order(500, new DateTime(2022, 12, 28));
//    Order order4 = new Order(700, new DateTime(2023, 04, 02));

//    return new Order[] { order1, order2, order3, order4 };
//}

//static void GetFilteredOrders(int price, DateTime date)
//{
//    Order[] orders = GetOrders();

//    foreach (Order order in orders)
//    {
//        if (order.Price > price && order.Date <= date.AddDays(1))
//        {
//            Console.WriteLine($"{order.Price} {order.Date}");
//        }
//    }
//}

#endregion