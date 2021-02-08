using Microsoft.AspNetCore.Mvc;
using System;

namespace Assignment1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HostingCostController : ControllerBase
    {
        [HttpGet("{id}")]
        public Decimal Get(Int32 id)
        {
            Decimal costPerForthNight = (decimal)5.50;
            Decimal hstPerForthnight = (decimal)13/100 * costPerForthNight;

            Decimal value = id / 14;
            Decimal numberOfForthNights = Math.Floor(value) + 1;
            Decimal totalCostOfForthNights = costPerForthNight * numberOfForthNights;

            Decimal totalHst = hstPerForthnight * numberOfForthNights;
            Decimal totalHousingCost = totalCostOfForthNights + totalHst;

            return Math.Round(totalHousingCost, 2);
        }



        /*  
  
            costPerForthnight = 5.50
            numberOfForthnights = value % 14
            totalCostForForthnights = costPerForthnight * numberOfForthnights
            
            hstPerForthnight = 0.72 
            totalHst = 0.72 * numberOfForthnights

            totalHostingCost = totalCostForForthnights + totalHst
        */

    }
}


