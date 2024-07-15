using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.AssignmentRequests
{
	public class DeleteAssignmentRequest
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string ImagePath { get; set; }

	}
}
