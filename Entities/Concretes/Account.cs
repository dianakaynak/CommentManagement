using Core.Entities;

namespace Entities.Concretes;

public class Account : Entity<Guid>
{
   
    public Guid UserId { get; set; }

    public User User { get; set; }
	public virtual ICollection<Comment> Comments { get; set; }
}
