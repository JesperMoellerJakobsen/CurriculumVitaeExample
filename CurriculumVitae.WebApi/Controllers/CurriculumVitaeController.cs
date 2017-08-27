using System.Collections.Generic;
using System.Threading.Tasks;
using CurriculumVitae.Database;
using CurriculumVitae.WebApi.GraphQL;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CurriculumVitae.WebApi.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/[controller]/graphql")]
    public class CurriculumVitaeController : Controller
    {
        private readonly CurriculumVitaeGraphQuery curriculumVitaeGraphQuery;
        private readonly ILogger<CurriculumVitaeController> logger;

        public CurriculumVitaeController(CurriculumVitaeGraphQuery curriculumVitaeGraphQuery, ILogger<CurriculumVitaeController> logger)
        {
            this.curriculumVitaeGraphQuery = curriculumVitaeGraphQuery;
            this.logger = logger;
        }


        [HttpPost]
        public async Task<IActionResult> PostQuery([FromBody] GraphQuery queryFromFrontend)
        {
            var schema = new Schema { Query = curriculumVitaeGraphQuery };

            var result = await new DocumentExecuter().ExecuteAsync(x =>
            {
                x.Schema = schema;
                x.Query = queryFromFrontend.Query;

            }).ConfigureAwait(false);

            if (result.Errors?.Count > 0)
            {
                //Error handling sucks a bit. Log it to log container instead :-)
                return BadRequest();
            }

            return Ok(result);
        }
    }
}