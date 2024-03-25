//using System;
//using System.Text;

//public interface ICipher
//{
//    string Encode(string input);
//    string Decode(string input);
//}

//public class SimpleCipher : ICipher
//{
//    private readonly int shift;

//    public SimpleCipher(int shift)
//    {
//        this.shift = shift;
//    }

//    public string Encode(string input)
//    {
//        StringBuilder encoded = new StringBuilder();
//        foreach (char c in input)
//        {
//            char shifted = (char)('a' + (c - 'a' + shift + 26) % 26);
//            encoded.Append(shifted);
//        }
//        return encoded.ToString();
//    }

//    public string Decode(string input)
//    {
//        StringBuilder decoded = new StringBuilder();
//        foreach (char c in input)
//        {
//            char shifted = (char)('a' + (c - 'a' - shift + 26) % 26);
//            decoded.Append(shifted);
//        }
//        return decoded.ToString();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        ICipher cipher = new SimpleCipher(3);

//        string original = "python";
//        string encoded = cipher.Encode(original);
//        string decoded = cipher.Decode(encoded);

//        Console.WriteLine($"Original: {original}");
//        Console.WriteLine($"Encoded:  {encoded}");
//        Console.WriteLine($"Decoded:  {decoded}");
//    }
//}



// доп задача

//using System;

//public class Product : IComparable<Product>
//{
//    public string Name { get; set; }
//    public decimal Price { get; set; }

//    public Product(string name, decimal price)
//    {
//        Name = name;
//        Price = price;
//    }

//    public int CompareTo(Product other)
//    {
//        return Price.CompareTo(other.Price);
//    }

//    public override string ToString()
//    {
//        return $"{Name} - ${Price}";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Product[] products = {
//            new Product("Laptop", 1200.00m),
//            new Product("Smartphone", 500.00m),
//            new Product("Tablet", 300.00m),
//            new Product("Monitor", 150.00m)
//        };

//        Array.Sort(products);

//        Console.WriteLine("Products sorted by price:");
//        foreach (Product product in products)
//        {
//            Console.WriteLine(product);
//        }
//    }
//}
