using shazebs.api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace shazebs.api.Controllers
{
    [Authorize]
    [EnableCors("default")]
    [Route("api/[controller]")]
    [ApiController]
    public class TweetsController : ODataController
    {
        private readonly DataContext _context;

        public TweetsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/tweets/
        [ODataRoute("Tweets")]
        [EnableQuery]
        public IQueryable<Tweet> Get()
        {
            return _context.ReadAllTweetsFromDb();
        }

        // GET: api/tweets/id/
        [ODataRoute("Tweets({key})")]
        [EnableQuery]
        public SingleResult<Tweet> Get([FromODataUri]long key)
        {
            return SingleResult.Create(_context.ReadOneTweet(key));
        }

        // POST: api/tweets/
        [ODataRoute("Tweets")]
        [EnableQuery]
        public async Task<IActionResult> Post([FromBody] Tweet entity)
        {
            if (entity == null) return BadRequest(entity);

            var result = await _context.InsertTweetIntoDb(entity);

            if (result == null)
            {
                return BadRequest(result); 
            }

            return Created(result);
        }
    }
}
