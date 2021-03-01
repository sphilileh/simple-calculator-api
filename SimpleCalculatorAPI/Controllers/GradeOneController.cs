using Microsoft.AspNetCore.Mvc;
using SimpleCalculatorAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleCalculatorAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GradeOneController : ControllerBase
	{
		// GET: api/<GradeOneController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}


		// POST api/<GradeOneController>
		[HttpPost("add")]
		public int PostAdd([FromBody] TwoNumbersModel value)
		{
			return value.Number1 + value.Number2;
		}

		// POST api/<GradeOneController>
		[HttpPost("subtract")]
		public int PostSub([FromBody] TwoNumbersModel value)
		{
			return value.Number1 - value.Number2;
		}


	}
}
