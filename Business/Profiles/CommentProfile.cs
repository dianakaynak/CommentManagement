using AutoMapper;
using Business.Dtos.Requests.CommentRequests;
using Business.Dtos.Responses.CommentResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
	public class CommentProfile : Profile
	{
		public CommentProfile()
		{
			CreateMap<Comment, CreateCommentRequest>().ReverseMap();
			CreateMap<Comment, CreatedCommentResponse>().ReverseMap();


			CreateMap<Comment, UpdateCommentRequest>().ReverseMap();
			CreateMap<Comment, UpdatedCommentResponse>().ReverseMap();


			CreateMap<Comment, DeleteCommentRequest>().ReverseMap();
			CreateMap<Comment, DeletedCommentResponse>().ReverseMap();


			
			CreateMap<IPaginate<Comment>, Paginate<GetListCommentResponse>>().ReverseMap();
			CreateMap<Comment, GetListCommentResponse>()
		   .ForMember(destinationMember: response => response.AccountName,
	  memberOptions: opt => opt.MapFrom(c => c.Account.User.FirstName)).ReverseMap();
		}
	}
}
