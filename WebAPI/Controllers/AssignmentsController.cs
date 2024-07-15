using Business.Abstracts;
using Business.Dtos.Requests.AssignmentRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AssignmentsController : ControllerBase
	{
		IAssignmentService _assignmentService;

		public AssignmentsController(IAssignmentService assignmentService)
		{
			_assignmentService = assignmentService;
		}
		[HttpGet("GetList")]
		public async Task<IActionResult> GetListAsync([FromQuery] PageRequest pageRequest)
		{
			var result = await _assignmentService.GetListAsync(pageRequest);
			return Ok(result);
		}

		[HttpPost]
		public async Task<IActionResult> AddAsync([FromBody] CreateAssignmentRequest createAssignmentRequest)
		{
			var result = await _assignmentService.AddAsync(createAssignmentRequest);
			return Ok(result);
		}

		[HttpPut]
		public async Task<IActionResult> UpdateAsync([FromBody] UpdateAssignmentRequest updateAssignmentRequest)
		{
			var result = await _assignmentService.UpdateAsync(updateAssignmentRequest);
			return Ok(result);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteAsync([FromRoute] Guid id)
		{
			var result = await _assignmentService.DeleteAsync(id);
			return Ok(result);
		}

		[HttpGet("GetById")]
		public async Task<IActionResult> GetByIdAsync(Guid id)
		{
			var result = await _assignmentService.GetByIdAsync(id);
			return Ok(result);
		}
	}
}
