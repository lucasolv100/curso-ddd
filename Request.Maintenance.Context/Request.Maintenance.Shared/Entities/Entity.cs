using System;
using Flunt.Notifications;

namespace Request.Maintenance.Shared.Entities
{
    public abstract class Entity : Notifiable
    {
        public string Id { get; protected set; }
        public Entity()
        {
            Id = Guid.NewGuid().ToString();
        }

    }
}