using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OurMoneyBlazor.Server.DataProvider;

namespace OurMoneyBlazor.Server.Controllers
{
    [Route("api/markets")]
    [ApiController]
    public class MarketsController : ControllerBase
    {
        private readonly IDataService dataService;

        public MarketsController(IDataService dataService)
        {
            this.dataService = dataService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var markets =  dataService.GetMarkets();
            return Ok(markets);
        }

    }
}
