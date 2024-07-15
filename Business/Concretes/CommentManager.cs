using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.CommentRequests;
using Business.Dtos.Responses.CommentResponses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
	public class CommentManager: ICommentService
	{
		ICommentDal _commentDal;
		IMapper _mapper;
		public CommentManager(ICommentDal commentDal, IMapper mapper)
		{
			_commentDal = commentDal;
			_mapper = mapper;
		}

		

		public async Task<CreatedCommentResponse> AddAsync(CreateCommentRequest createCommentRequest)
		{
			Comment comment = _mapper.Map<Comment>(createCommentRequest);
			Comment createdComment = await _commentDal.AddAsync(comment);
			CreatedCommentResponse createdCommentResponse = _mapper.Map<CreatedCommentResponse>(createdComment);
			return createdCommentResponse;
		}

		public async Task<DeletedCommentResponse> DeleteAsync(Guid id)
		{
			Comment comment = await _commentDal.GetAsync(predicate: a => a.Id == id);
			Comment deletedComment = await _commentDal.DeleteAsync(comment);
			DeletedCommentResponse deletedCommentResponse = _mapper.Map<DeletedCommentResponse>(deletedComment);
			return deletedCommentResponse;
		}

		public async Task<IPaginate<GetListCommentResponse>> GetListAsync(PageRequest pageRequest)
		{
			var comment = await _commentDal.GetListAsync(
				  index: pageRequest.PageIndex,
			   size: pageRequest.PageSize,
			   include: ab => ab
			   .Include(ab => ab.Account).ThenInclude(ab => ab.User)
			 
			   );
				var mappedComment = _mapper.Map<Paginate<GetListCommentResponse>>(comment);
			return mappedComment;
		}

		public async Task<UpdatedCommentResponse> UpdateAsync(UpdateCommentRequest updateCommentRequest)
		{
			Comment comment = _mapper.Map<Comment>(updateCommentRequest);
			Comment updatedComment = await _commentDal.UpdateAsync(comment);
			UpdatedCommentResponse updatedCommentResponse = _mapper.Map<UpdatedCommentResponse>(updatedComment);
			return updatedCommentResponse;
		}

		public async Task<GetListCommentResponse> GetByIdAsync(Guid? id)
		{
			var comments = await _commentDal.GetAsync(b => b.Id == id);
			var mappedComments = _mapper.Map<GetListCommentResponse>(comments);
			return mappedComments;

		}
	}
}

