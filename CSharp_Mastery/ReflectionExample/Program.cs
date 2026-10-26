

using ReflectionExample;
using System.Reflection;

IProduct product = DataSender.SendData();

Assembly a = Assembly.GetExecutingAssembly();
Type[] types = a.GetTypes();

foreach (Type type in types)
{
    Console.WriteLine($"Type: {type.Name}");
}

Type typeOfProduct = product.GetType();
Type typeOfProductDirect = typeof(Product);

ConstructorInfo[] constructors = typeOfProductDirect.GetConstructors();
ConstructorInfo constructor = typeOfProductDirect.GetConstructor(new Type[] { typeof(string), typeof(double) });

Product p = (Product)constructor.Invoke(new object[] { "New Product", 99.99m });

p.Name = "Updated Product";
p.Price = 200;
MethodInfo method = typeOfProductDirect.GetMethod("GetDiscountedPrice", new Type[] { typeof(double) });
double discountedPrice = (double)method.Invoke(p, new object[] { 10.0 });

Console.WriteLine(discountedPrice);