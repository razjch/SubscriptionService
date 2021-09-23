using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionService.DTO
{
    public class SubscribedMemberDTO
    {
        public int DrugId { get; set; }
        public int MemberId { get; set; }
        public bool SubscriptionStatus { get; set; }
        public DateTime SubscriptionDate { get; set; }

    }
}
