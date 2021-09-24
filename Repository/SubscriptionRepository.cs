using Newtonsoft.Json;
using SubscriptionService.DTO;
using SubscriptionService.Models;
using SubscriptionService.TempData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionService.Repository
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly SubscriptionData _subscriptionData;
        static int memberId = 2;

        public SubscriptionRepository(SubscriptionData subscriptionData)
        {
            _subscriptionData = subscriptionData;
        }

        public MemberSubscription Subscribe(SubscriptionDTO subscription)
        {
            MemberPrescription prescription = GetPrescriptionById(subscription.PrescriptionId);
            

            MemberSubscription member = _subscriptionData.memberSubscriptions.Find(m => m.PrescriptionId == subscription.PrescriptionId);
           
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://20.83.8.158");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", subscription.Token);

           StringContent content = new StringContent(JsonConvert.SerializeObject(""), Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync("/api/Drug/getStock/" + prescription.DrugId + "/" + member.MemberLocation,content).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string jsonString = response.Content.ReadAsStringAsync().Result;
                DispatchableDrugDTO drug = JsonConvert.DeserializeObject<DispatchableDrugDTO>(jsonString);

                int quantityRequired = prescription.DosagePerDay * prescription.PrescriptionCourse;

                if (quantityRequired > drug.Stock)
                {
                    return null;
                }
                member.SubscriptionStatus = true;
                //SubscribedMemberDTO subscribedMember = new SubscribedMemberDTO
                //{
                //    DrugId = drug.Id,
                //    MemberId = member.MemberId,
                //    SubscriptionStatus = true,
                //    SubscriptionDate = DateTime.Now
                //};
                return member;
            }
            return null;
        }

        private MemberSubscription GetSubscriptionByMemberId(int memberID)
        {
            return _subscriptionData.memberSubscriptions.Find(m => m.MemberId == memberID);
        }

        private MemberPrescription GetPrescriptionById(int prescriptionId)
        {
            return _subscriptionData.memberPrescriptions.Find(p => p.PrescriptionId == prescriptionId);
        }

        public MemberSubscription UnSubscribe(SubscriptionDTO subscription)
        {
            var member = _subscriptionData.memberSubscriptions.Find(m => m.PrescriptionId == subscription.PrescriptionId);
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://20.40.247.22");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", subscription.Token);
            HttpResponseMessage response = client.GetAsync("/api/Refill/checkPendingPaymentStatus/" + member.SubscriptionId).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                member.SubscriptionStatus = false;
                return member;
            }
            return null;
        }

        public RefillDueDTO GetRefillData(int subscriptionId)
        {
            var member = _subscriptionData.memberSubscriptions.Find(m => m.SubscriptionId == subscriptionId);
            if(member==null || member.SubscriptionStatus==false) 
                return null;
            
            var prescription = GetPrescriptionById(member.PrescriptionId);
            RefillDueDTO refillData = new RefillDueDTO();
            refillData.DrugId = prescription.DrugId;
            refillData.Location = member.MemberLocation;
            refillData.RefillOccurrence = member.RefillOccurrence;
            refillData.SubscriptionDate = member.SubscriptionDate;
            refillData.ToalDrug = prescription.DosagePerDay * prescription.PrescriptionCourse;

            return refillData;

        }
        public List<MemberPrescription> GetAllPrescription(int memberId)
        {
            return _subscriptionData.memberPrescriptions.FindAll(p => p.MemberID == memberId);
        }
        public List<MemberSubscription> GetAllSubscription(int memberId)
        {
            
            return _subscriptionData.memberSubscriptions.FindAll(m => m.MemberId == memberId);
        }

    }
}
