using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
	public class Assignment: Entity<Guid>
    {
	
		public string Title { get; set; }
		public string Description { get; set; }
        public string ImagePath { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

	}
}
