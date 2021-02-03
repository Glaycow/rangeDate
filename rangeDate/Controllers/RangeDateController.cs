using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace rangeDate.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RangeDateController : ControllerBase
    {
        private readonly ILogger<RangeDateController> _logger;
        public RangeDateController(ILogger<RangeDateController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<DateTime> Get()
        {
            DateTime starting = new DateTime(2021, 01, 01);
            DateTime ending = new DateTime(2021, 06,  06);
            List<DateTime> dates = GetDatesBetween(starting, ending);
            return dates;

        }
        private static List<DateTime> GetDatesBetween(DateTime startDate, DateTime endDate)
        {
            List<DateTime> allDates = new List<DateTime>();
            for (DateTime date = startDate; date <= endDate; date = date.AddMonths(1))
                allDates.Add(date);
            return allDates;
        }
    }
}
