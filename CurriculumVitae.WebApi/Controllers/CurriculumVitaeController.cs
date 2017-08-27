using System.Threading.Tasks;
using CurriculumVitae.WebApi.GraphQL;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
            var result = await new DocumentExecuter().ExecuteAsync(new ExecutionOptions { Schema = schema, Query = queryFromFrontend.Query }).ConfigureAwait(false);

            if (result.Errors?.Count > 0)
                logger.LogError($"{result.Errors}");
            
            return Json(result);
        }
    }
}