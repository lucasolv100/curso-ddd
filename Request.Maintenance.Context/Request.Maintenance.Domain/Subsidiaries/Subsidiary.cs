using Flunt.Validations;
using Request.Maintenance.Shared.Entities;

namespace Request.Maintenance.Domain.Subsidiaries
{
    public class Subsidiary : Entity
    {
        public Subsidiary(string name)
        {
            Name = name;
            
            AddNotifications(
                new Contract()
                .Requires()
                .IsNullOrEmpty("Subsidiary.Name", name, "O nome da subsidiaria é invalido")
            );
            
        }

        public string Name { get; private set; }

        
    }
}