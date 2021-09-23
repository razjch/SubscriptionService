using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionService.DTO
{
    public class RefillDueDTO
    {
            public int DrugId { get; set; }
            public int ToalDrug { get; set; }
            public string RefillOccurrence { get; set; }
            public DateTime SubscriptionDate { get; set; }
            public string Location { get; set; }
        
    }
}
