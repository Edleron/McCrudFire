using Bogus;
using McCrudFire.Models;
using System.Collections.Generic;

namespace McCrudFire.Fake
{
    public static class FakeData
    {
        private static List<User> _users;

        public static List<User> GetUsers(int count) 
        {
            if (_users == null)
            {
                _users = new Faker<User>()
               .RuleFor(u => u.Id, f => f.IndexFaker + 1)
               .RuleFor(u => u.FirstName, f => f.Name.FirstName())
               .RuleFor(u => u.LastName, f => f.Name.LastName())
               .RuleFor(u => u.Adress, f => f.Address.FullAddress())
               .Generate(count);
            }
            return _users;
        }   
    }
}
