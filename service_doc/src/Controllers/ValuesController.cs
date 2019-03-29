using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace src.Controllers
{
	/// <summary>
	/// This is the Values controller.
	/// </summary>
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		/// <summary>
		/// GET api/values
		/// </summary>
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get()
		{
			return new string[] { "value1", "value2" };
		}

		/// <summary>
		/// GET api/values/5
		/// </summary>
		/// <param name="id">ID to search for</param>
		/// <returns></returns>
		[HttpGet("{id}")]
		public ActionResult<string> Get(int id)
		{
			return "value";
		}

		/// <summary>
		/// POST api/values 
		/// </summary>
		/// <param name="value">ID to search for (from Body text)</param>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		/// <summary>
		/// PUT api/values/5
		/// </summary>
		/// <param name="id"></param>
		/// <param name="value"></param>
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		/// <summary>
		/// DELETE api/values/5
		/// </summary>
		/// <param name="id">ID to delete</param>
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
