using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.AssignmentRequests
{
	public class CreateAssignmentRequest
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string ImagePath { get; set; }

	}
}
