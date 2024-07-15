using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.CommentRequests
{
	public class UpdateCommentRequest
	{
		public Guid Id { get; set; }
		public Guid AssignmentId { get; set; }
		public Guid AccountId { get; set; }
		public string Content { get; set; }
		public DateTime CommentDate { get; set; }
	}
}
