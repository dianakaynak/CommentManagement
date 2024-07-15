using AutoMapper;
using Business.Dtos.Requests.AssignmentRequests;
using Business.Dtos.Responses.Assignment;
using Business.Dtos.Responses.UserResponses;
using Core.DataAccess.Paging;
using Core.Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
	public class AssignmentProfile : Profile
	{
		public AssignmentProfile()
		{
			CreateMap<Assignment, CreateAssignmentRequest>().ReverseMap();
			CreateMap<Assignment, CreatedAssignmentResponse>().ReverseMap();


			CreateMap<Assignment, UpdateAssignmentRequest>().ReverseMap();
			CreateMap<Assignment, UpdatedAssignmentResponse>().ReverseMap();


			CreateMap<Assignment, DeleteAssignmentRequest>().ReverseMap();
			CreateMap<Assignment, DeletedAssignmentResponse>().ReverseMap();
		

			CreateMap<Assignment, GetListAssignmentResponse>().ReverseMap();
			CreateMap<IPaginate<Assignment>, Paginate<GetListAssignmentResponse>>().ReverseMap();
		}
	}
}
