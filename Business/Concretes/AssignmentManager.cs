using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.AssignmentRequests;
using Business.Dtos.Responses.Assignment;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
	public class AssignmentManager : IAssignmentService
	{
		private readonly IAssignmentDal _assignmentDal;
		private readonly IMapper _mapper;

		public AssignmentManager(IAssignmentDal assignmentDal, IMapper mapper)
		{
			_assignmentDal = assignmentDal;
			_mapper = mapper;
		}
	

	public async Task<CreatedAssignmentResponse> AddAsync(CreateAssignmentRequest createAssignmentRequest)
		{
			Assignment assignment = _mapper.Map<Assignment>(createAssignmentRequest);
			Assignment createdAssignment = await _assignmentDal.AddAsync(assignment);
			CreatedAssignmentResponse createdAssignmentResponse = _mapper.Map<CreatedAssignmentResponse>(createdAssignment);
			return createdAssignmentResponse;
		}

		public async Task<DeletedAssignmentResponse> DeleteAsync(Guid id)
		{
			Assignment assignment = await _assignmentDal.GetAsync(predicate: a => a.Id == id);
			Assignment deletedAssignment = await _assignmentDal.DeleteAsync(assignment);
			DeletedAssignmentResponse deletedAssignmentResponse = _mapper.Map<DeletedAssignmentResponse>(deletedAssignment);
			return deletedAssignmentResponse;
		}

		public async Task<IPaginate<GetListAssignmentResponse>> GetListAsync(PageRequest pageRequest)
		{
			var assignment = await _assignmentDal.GetListAsync(
		index: pageRequest.PageIndex,
		size: pageRequest.PageSize);
			var mappedAssignment = _mapper.Map<Paginate<GetListAssignmentResponse>>(assignment);
			return mappedAssignment;
		}

		public async Task<UpdatedAssignmentResponse> UpdateAsync(UpdateAssignmentRequest updateAssignmentRequest)
		{
			Assignment assignment = _mapper.Map<Assignment>(updateAssignmentRequest);
			Assignment updatedAssignment = await _assignmentDal.UpdateAsync(assignment);
			UpdatedAssignmentResponse updatedAssignmentResponse = _mapper.Map<UpdatedAssignmentResponse>(updatedAssignment);
			return updatedAssignmentResponse;
		}

		public async Task<GetListAssignmentResponse> GetByIdAsync(Guid? id)
		{
			var assignments = await _assignmentDal.GetAsync(b => b.Id == id);
			var mappedAssignments = _mapper.Map<GetListAssignmentResponse>(assignments);
			return mappedAssignments;

		}
	}
}
