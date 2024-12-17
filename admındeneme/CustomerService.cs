using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.Json;

namespace admındeneme
{
    public class CustomerService
    {
        private readonly IMongoCollection<Customer> _customers;

        public CustomerService()
        {
            // MongoDB bağlantısını yap
            var client = new MongoClient("mongodb+srv://serdar:ZAdKlBkZGWKkwD93@busiparis.puzru.mongodb.net/"); // MongoDB bağlantı adresini buraya yaz
            var database = client.GetDatabase("BuSiparis"); // Veritabanı adını buraya yaz
            _customers = database.GetCollection<Customer>("customers"); // Koleksiyon adını buraya yaz
        }

        // Tüm müşterileri getiren metot
        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            return await _customers.Find(new BsonDocument()).ToListAsync();
        }
    }

}
