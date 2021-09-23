using SubscriptionService.DTO;
using SubscriptionService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionService.Repository
{
    public interface ISubscriptionRepository
    {
        List<MemberPrescription> GetAllPrescription(int memberId);
        List<MemberSubscription> GetAllSubscription(int memberId);
        MemberSubscription Subscribe(SubscriptionDTO subscription);
        MemberSubscription UnSubscribe(SubscriptionDTO subscription);
        RefillDueDTO GetRefillData(int subscriptionId);
    }
}
