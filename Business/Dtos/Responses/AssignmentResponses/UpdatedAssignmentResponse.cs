using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.Assignment
{
	public class UpdatedAssignmentResponse
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string ImagePath { get; set; }


	}
}
