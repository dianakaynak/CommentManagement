using Business.Dtos.Requests.CommentRequests;
using Business.Dtos.Responses.CommentResponses;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
	public interface ICommentService
	{
		Task<IPaginate<GetListCommentResponse>> GetListAsync(PageRequest pageRequest);
		Task<CreatedCommentResponse> AddAsync(CreateCommentRequest createCommentRequest);
		Task<UpdatedCommentResponse> UpdateAsync(UpdateCommentRequest updateCommentRequest);
		Task<DeletedCommentResponse> DeleteAsync(Guid id);
		Task<GetListCommentResponse> GetByIdAsync(Guid? id);
	}
}
