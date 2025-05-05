using Newtonsoft.Json;

namespace TMS_HomeWork13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "orders.json";

            List<Order> orders = new List<Order>();
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                orders = JsonConvert.DeserializeObject<List<Order>>(json);
                Console.WriteLine("Десериализованные данные:");
                foreach (var order in orders)
                {
                    Console.WriteLine($"Номер заказа: {order.OrderId}, Время заказа: {order.Date}");
                    foreach (var product in order.Products)
                    {
                        Console.WriteLine($"  Номер товара: {product.Id}, Товар: {product.Name}, Цена: {product.Price}");
                    }
                }
            }
            else
            {
                orders.Add(new Order
                {
                    OrderId = 1,
                    Date = DateTime.Now,
                    Products = new List<Product>
                {
                    new Product { Id = 1, Name = "Бургер", Price = 12.50m },
                    new Product { Id = 2, Name = "Пицца", Price = 20.90m }
                }
                });

                orders.Add(new Order
                {
                    OrderId = 2,
                    Date = DateTime.Now.AddDays(-1),
                    Products = new List<Product>
                {
                    new Product { Id = 3, Name = "Латте", Price = 8.00m },
                    new Product { Id = 4, Name = "Кекс", Price = 4.55m }
                }
                });
                string json = JsonConvert.SerializeObject(orders, Formatting.Indented);
                File.WriteAllText(filePath, json);
                Console.WriteLine("Заказы сохранены в файл orders.json");
            }
            Console.ReadLine();
        }
    }
}
