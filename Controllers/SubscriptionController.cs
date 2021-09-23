using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SubscriptionService.DTO;
using SubscriptionService.Repository;
using SubscriptionService.TempData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SubscriptionService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class SubscriptionController : ControllerBase
    {
        private readonly ISubscriptionRepository _subscriptionRepository;
        private readonly SubscriptionData _subscriptionData;
        public SubscriptionController(ISubscriptionRepository subscriptionRepository, SubscriptionData subscriptionData)
        {
            _subscriptionRepository = subscriptionRepository;
            _subscriptionData = subscriptionData;
        }

        [HttpPost("Subscribe")]
        public ActionResult Subscription([FromBody] SubscriptionDTO subscription)
        {
            var pres = _subscriptionData.memberPrescriptions.Find(p => p.PrescriptionId == subscription.PrescriptionId);
            if (pres == null)
                return NotFound("Wrong Prescription Id");
            var memb = _subscriptionData.memberSubscriptions.Find(m => m.PrescriptionId == pres.PrescriptionId);
            if ( memb!=null && memb.SubscriptionStatus == true)
                return NoContent();
            var subscribedMember = _subscriptionRepository.Subscribe(subscription);
            if (subscribedMember!=null)
                return Ok(subscribedMember);
            else
                return BadRequest("Subscription cannot be accepted due to drug unavailability");
        }

        [HttpPost("UnSubscribe")]
        public ActionResult UnSubscription([FromBody] SubscriptionDTO subscription)
        {
            var obj = _subscriptionRepository.UnSubscribe(subscription);
            if (obj!=null)
                return Ok(obj);
            else
                return BadRequest("Cannot Unsubscribe... Please clear your Dues");
        }

        [HttpGet("getallprescription/{memberId}")]
        public IActionResult GetAllPrescription(int memberId)
        {
            var res = _subscriptionRepository.GetAllPrescription(memberId);
            if (res.Count == 0)
                return NoContent();
            return Ok(res);
        }

        [HttpGet("getallsubscription/{memberId}")]
        public IActionResult GetAllSubscription(int memberId)
        {
            var res = _subscriptionRepository.GetAllSubscription(memberId);
            if (res.Count == 0)
                return NoContent();
            return Ok(res);
        }

        [HttpGet("getrefilldata/{subscriptionId}")]
        public IActionResult GetRefillData(int subscriptionId)
        {
            var res = _subscriptionRepository.GetRefillData(subscriptionId);
            if (res != null)
                return Ok(res);
            return BadRequest("Enter valid subscriptionID");
        }


    }
}
