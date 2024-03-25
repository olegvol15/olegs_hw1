//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

//        List<int> evenNumbersUsingMethod = numbers.FindAll(IsEven);
//        List<int> evenNumbersUsingAnonymous = numbers.FindAll(delegate (int number) {
//            return number % 2 == 0;
//        });
//        List<int> evenNumbersUsingLambda = numbers.FindAll(number => number % 2 == 0);

//        PrintNumbers("Even numbers using method:", evenNumbersUsingMethod);
//        PrintNumbers("Even numbers using anonymous method:", evenNumbersUsingAnonymous);
//        PrintNumbers("Even numbers using lambda:", evenNumbersUsingLambda);
//    }

//    static bool IsEven(int number)
//    {
//        return number % 2 == 0;
//    }

//    static void PrintNumbers(string title, List<int> numbers)
//    {
//        Console.WriteLine(title);
//        foreach (int num in numbers)
//        {
//            Console.WriteLine(num);
//        }
//    }
//}


//доп задача

using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Rating { get; set; }

    public Product(string name, double price, int rating)
    {
        Name = name;
        Price = price;
        Rating = rating;
    }

    public override string ToString()
    {
        return $"{Name}, price: {Price}, rating: {Rating}";
    }
}

class Category
{
    public string Name { get; set; }
    public List<Product> Products { get; set; }

    public Category(string name)
    {
        Name = name;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void DisplayProducts()
    {
        Console.WriteLine($"Products in category '{Name}':");
        foreach (var product in Products)
        {
            Console.WriteLine(product);
        }
    }
}

class Cart
{
    public List<Product> Products { get; set; }

    public Cart()
    {
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
        OnProductAdded(product);
    }

    protected virtual void OnProductAdded(Product product)
    {
        Console.WriteLine($"Added product to cart: {product}");
    }
}

class User
{
    public string Login { get; set; }
    public string Password { get; set; }
    public Cart ShoppingCart { get; set; }

    public User(string login, string password)
    {
        Login = login;
        Password = password;
        ShoppingCart = new Cart();
    }
}

class Program
{
    static void Main()
    {
        Category electronics = new Category("Electronics");
        electronics.AddProduct(new Product("Phone", 1000, 5));
        electronics.AddProduct(new Product("Television", 2000, 4));
        electronics.DisplayProducts();

        User user = new User("user1", "pass123");
        user.ShoppingCart.AddProduct(new Product("Laptop", 1500, 5));
        user.ShoppingCart.AddProduct(new Product("Tablet", 600, 4));
    }
}

