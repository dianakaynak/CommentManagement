using Business.Dtos.Requests.AssignmentRequests;
using Business.Dtos.Responses.Assignment;
using Business.Dtos.Responses.UserResponses;
using Core.DataAccess.Paging;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
	public interface IAssignmentService
	{
		Task<IPaginate<GetListAssignmentResponse>> GetListAsync(PageRequest pageRequest);
		Task<CreatedAssignmentResponse> AddAsync(CreateAssignmentRequest createAssignmentRequest);
		Task<UpdatedAssignmentResponse> UpdateAsync(UpdateAssignmentRequest updateAssignmentRequest);
		Task<DeletedAssignmentResponse> DeleteAsync(Guid id);
		Task<GetListAssignmentResponse> GetByIdAsync(Guid? id);

	}
}
