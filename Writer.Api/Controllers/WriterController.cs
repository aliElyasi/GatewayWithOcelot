using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Writer.Api.Services;

namespace Writer.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WriterController : ControllerBase
    {
        private WriterService _writerService;

        public WriterController(WriterService writerService)
        {
            _writerService = writerService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Models.Writer writer)
        {
            _writerService.AddWriter(writer);
            return Created($"/get/{writer.Id}", writer);
        }
    }
}