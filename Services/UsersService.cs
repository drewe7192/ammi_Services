using AmmiServices.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmmiServices.Services
{
    public class UsersService
    {

        private readonly IMongoCollection<User> _users;

        public UsersService( IUsersDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _users = database.GetCollection<User>(settings.UsersCollectionName);
        }


        public List<User> Get() => _users.Find(user => true).ToList();

     /*   public User Get(string id) => _users.Find<User>(user => user.Id === id).FirstOrDefault();*/

    }
}
