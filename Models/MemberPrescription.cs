using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionService.Models
{
    public class MemberPrescription
    {
        public int PrescriptionId { get; set; }
        public int MemberID { get; set; }
        public string InsurancePolicyNumber { get; set; }
        public string InsuranceProvider { get; set; }
        public DateTime PrescriptionDate { get; set; }
        public int DrugId { get; set; }
        public int DosagePerDay { get; set; }
        public int PrescriptionCourse {get; set; }
        public string DoctorDetails { get; set; }


    }
}
