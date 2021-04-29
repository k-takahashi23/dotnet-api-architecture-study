using ApiArchitectureSample.Core.Domain.SeedWork;

namespace ApiArchitectureSample.Application.Core.AggregateModels.UserAggregate
{
    public class User : Entity, IAggregateRoot
    {
        public string Name { get; private set; }

        public Address Address { get; private set; }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public User(int id, string name, Address address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        public void SetName(string name) => Name = name;

        public void SetAddress(Address address) => Address = address;
    }
}
