using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessageService.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MessageController : ControllerBase
	{
		// GET: api/Message
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "Hello", "there" };
		}
	}
}
