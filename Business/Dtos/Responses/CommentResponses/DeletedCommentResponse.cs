namespace Business.Dtos.Responses.CommentResponses
{
	public class DeletedCommentResponse
	{
		public Guid Id { get; set; }
		public Guid AssignmentId { get; set; }
		public Guid AccountId { get; set; }
		public string Content { get; set; }
		public DateTime CommentDate { get; set; }
	}
}
