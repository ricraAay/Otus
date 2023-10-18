using Otus.HomerWork.DapperProject.DAL.Model;
using Otus.HomerWork.DapperProject.DAL.Repository;
using Npgsql;

namespace Otus.HomerWork.DapperProject
{
    static class Program
    {
        static void Main(string[] args)
        {
            using (var connection = new NpgsqlConnection(Configuration.ConnectionString))
            {
                Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

                connection.Open();

                var customerRepository = new Repository<Customer>(connection);
                var productRepository = new Repository<Product>(connection);
                var orderRepository = new Repository<Order>(connection);

                Console.WriteLine(customerRepository.Get(1)?.FirstName);
                Console.WriteLine(productRepository.Get(5)?.Name);
                Console.WriteLine(orderRepository.Get(5)?.CustomerId);

                Console.WriteLine(customerRepository.Like("first_name", "Иван")?.FirstOrDefault()?.FirstName);
                Console.WriteLine(productRepository.Like("name", "Продукт 2")?.FirstOrDefault()?.Name);

                customerRepository.Add(new Customer
                {
                    FirstName = "Илья",
                    LastName = "Колесниченко",
                    Age = 25
                });

                productRepository.Add(new Product
                {
                    Name = "Продукт 123",
                    Description = "Продукт 123"
                });
            }

            Console.ReadLine();
        }
    }
}