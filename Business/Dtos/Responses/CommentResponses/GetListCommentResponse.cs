namespace Business.Dtos.Responses.CommentResponses
{
	public class GetListCommentResponse
	{
		public Guid Id { get; set; }
		public Guid AssignmentId { get; set; }
		public string AccountName { get; set; }
		public string Content { get; set; }
		public DateTime CommentDate { get; set; }

	}
}
