using Business.Abstracts;
using Business.Dtos.Requests.CommentRequests;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CommentsController : ControllerBase
	{
		ICommentService _commentService;

		public CommentsController(ICommentService commentService)
		{
			_commentService = commentService;
		}

		[HttpGet("GetList")]
		public async Task<IActionResult> GetListAsync([FromQuery] PageRequest pageRequest)
		{
			var result = await _commentService.GetListAsync(pageRequest);
			return Ok(result);
		}

		[HttpPost]
		public async Task<IActionResult> AddAsync([FromBody] CreateCommentRequest createCommentRequest)
		{
			var result = await _commentService.AddAsync(createCommentRequest);
			return Ok(result);
		}

		[HttpPut]
		public async Task<IActionResult> UpdateAsync([FromBody] UpdateCommentRequest updateCommentRequest)
		{
			var result = await _commentService.UpdateAsync(updateCommentRequest);
			return Ok(result);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteAsync([FromRoute] Guid id)
		{
			var result = await _commentService.DeleteAsync(id);
			return Ok(result);
		}

		[HttpGet("GetById")]
		public async Task<IActionResult> GetByIdAsync(Guid id)
		{
			var result = await _commentService.GetByIdAsync(id);
			return Ok(result);
		}
	}
}
