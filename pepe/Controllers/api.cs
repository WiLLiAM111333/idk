using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using pepe.Repository;
using pepe.models;

namespace pepe.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class Controller : ControllerBase
	{
		private readonly ImageRepository imageRepository; //Imports database

		public Controller(ImageRepository ImageRepository)
		{
			imageRepository = ImageRepository; //Why the fck is it like this??
		}
		[HttpGet("{Id}")]
		public ActionResult<ImageClass> GetImage(string Id)
		{
			var Image = imageRepository.GetImage(Id); //Implement this databaseshit method
			if (Image == null) {
				return NotFound();
			}
			return Ok(Image);
		}

		[HttpGet]
		public ActionResult<ImageClass> GetRandomImage()
		{
			var Image = imageRepository.GetRandomImage(); //Implement this databaseshit method
			if (Image == null) {
				return NotFound();
			}
			return Ok(Image);
		}

		[HttpPost("")]
		public ActionResult<ImageClass> AddImage(ImageClass image)
		{
			var Image = imageRepository.AddImage(image); //implement  this databaseshit method
			if (Image == null) {
				return NotFound();
			}
			return Ok(Image);
		}

		[HttpPatch("{Id}")]
		public ActionResult<ImageClass> UpdateImage(ImageClass image)
		{
			var Image = imageRepository.UpdateImage(image); //implement this databaseshit method
			if (Image == null) {
				return NotFound();
			}
			return Ok(Image);
		}

		[HttpDelete("{Id}")]
		public ActionResult<ImageClass> DeleteImage(string? Id)
		{
			var Image = imageRepository.DeleteImage(Id); //implement this databaseshit method
			if (Image == null)
			{
				return NotFound();
			}
			return Ok(Image);
		}
	}
}


