using DotNetWebSearchAnalyticsAPI.Api.Services;
using DotNetWebSearchAnalyticsAPI.Data.Activity;
using DotNetWebSearchAnalyticsAPI.Data.Models;
using DotNetWebSearchAnalyticsAPI.Data.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DotNetWebSearchAnalyticsAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchTransactionController : ControllerBase
    {
        private UserService _userService;
        private ISearchTransactionRepository _ISearchTransactionRepository;

        public SearchTransactionController(UserService prUserService, ISearchTransactionRepository prISearchTransactionRepository)
        {
            _userService = prUserService;
            _ISearchTransactionRepository = prISearchTransactionRepository;
        }

        [HttpGet("GetAll")]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<SearchTransaction>))]
        //[Authorize] TODO
        public async Task<IActionResult> GetAll()
        {
            SearchTransactionActivityCoordinator lSearchTransactionActivityCoordinator = new SearchTransactionActivityCoordinator(_ISearchTransactionRepository);
            return Ok(lSearchTransactionActivityCoordinator.GetAll());
        }

        [HttpGet("GetAllWithAuthorization")]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<SearchTransaction>))]
        [Authorize]
        public async Task<IActionResult> GetAllWithAuthorization()
        {
            SearchTransactionActivityCoordinator lSearchTransactionActivityCoordinator = new SearchTransactionActivityCoordinator(_ISearchTransactionRepository);
            return Ok(lSearchTransactionActivityCoordinator.GetAll());
        }

        [HttpGet("SearchKeyword")]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<SearchTransaction>))]
        //[Authorize] TODO
        public async Task<IActionResult> SearchKeyword(string prURL, string prSearchTerm, int prTakeResult, string prKeyword)
        {
            SearchTransactionActivityCoordinator lSearchTransactionActivityCoordinator = new SearchTransactionActivityCoordinator(_ISearchTransactionRepository);
            
            if(lSearchTransactionActivityCoordinator.ScrapeSearchEnginesForKeyword(prURL, prSearchTerm, prTakeResult, prKeyword, "Google"))
                return Ok(lSearchTransactionActivityCoordinator.GetAll());
            else
                return BadRequest(lSearchTransactionActivityCoordinator._CoMessageList.ToString());
        }
    }
}