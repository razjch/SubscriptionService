using SubscriptionService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionService.TempData
{
    public class SubscriptionData
    {
        public List<MemberPrescription> memberPrescriptions ;
        public List<MemberSubscription> memberSubscriptions ;

        public SubscriptionData()
        {
            memberPrescriptions = new List<MemberPrescription>()
            {
                new MemberPrescription
                {
                    PrescriptionId = 101,
                    MemberID = 1,
                    InsurancePolicyNumber = "I101",
                    InsuranceProvider = "abc",
                    PrescriptionDate = Convert.ToDateTime("2018/10/12"),
                    DrugId = 1,
                    DosagePerDay = 2,
                    PrescriptionCourse = 60,
                    DoctorDetails = "Dr. Raj"
                },
                new MemberPrescription
                {
                    PrescriptionId = 102,
                    MemberID = 1,
                    InsurancePolicyNumber = "I102",
                    InsuranceProvider = "abcxyz",
                    PrescriptionDate = Convert.ToDateTime("2019/10/12"),
                    DrugId = 2,
                    DosagePerDay = 3,
                    PrescriptionCourse = 90,
                    DoctorDetails = "Dr. Nikhil"
                },
                new MemberPrescription
                {
                    PrescriptionId = 103,
                    MemberID = 1,
                    InsurancePolicyNumber = "I103",
                    InsuranceProvider = "xyz",
                    PrescriptionDate = Convert.ToDateTime("2020/10/12"),
                    DrugId = 3,
                    DosagePerDay = 3,
                    PrescriptionCourse = 70,
                    DoctorDetails = "Dr. Munna Bhai M.B.B.S."
                },
                new MemberPrescription
                {
                    PrescriptionId = 104,
                    MemberID = 1,
                    InsurancePolicyNumber = "I103",
                    InsuranceProvider = "xyz",
                    PrescriptionDate = Convert.ToDateTime("2020/10/12"),
                    DrugId = 3,
                    DosagePerDay = 3,
                    PrescriptionCourse = 70,
                    DoctorDetails = "Dr. Munna Bhai M.B.B.S."
                },
                new MemberPrescription
                {
                    PrescriptionId = 105,
                    MemberID = 1,
                    InsurancePolicyNumber = "I103",
                    InsuranceProvider = "xyz",
                    PrescriptionDate = Convert.ToDateTime("2020/10/12"),
                    DrugId = 3,
                    DosagePerDay = 3,
                    PrescriptionCourse = 70,
                    DoctorDetails = "Dr. Munna Bhai M.B.B.S."
                },
                new MemberPrescription
                {
                    PrescriptionId = 106,
                    MemberID = 2,
                    InsurancePolicyNumber = "I101",
                    InsuranceProvider = "abc",
                    PrescriptionDate = Convert.ToDateTime("2018/10/12"),
                    DrugId = 1,
                    DosagePerDay = 2,
                    PrescriptionCourse = 60,
                    DoctorDetails = "Dr. Raj"
                },
                new MemberPrescription
                {
                    PrescriptionId = 107,
                    MemberID = 2,
                    InsurancePolicyNumber = "I102",
                    InsuranceProvider = "abcxyz",
                    PrescriptionDate = Convert.ToDateTime("2019/10/12"),
                    DrugId = 2,
                    DosagePerDay = 3,
                    PrescriptionCourse = 90,
                    DoctorDetails = "Dr. Nikhil"
                },
                new MemberPrescription
                {
                    PrescriptionId = 108,
                    MemberID = 2,
                    InsurancePolicyNumber = "I103",
                    InsuranceProvider = "xyz",
                    PrescriptionDate = Convert.ToDateTime("2020/10/12"),
                    DrugId = 3,
                    DosagePerDay = 3,
                    PrescriptionCourse = 70,
                    DoctorDetails = "Dr. Munna Bhai M.B.B.S."
                },
                new MemberPrescription
                {
                    PrescriptionId = 109,
                    MemberID = 2,
                    InsurancePolicyNumber = "I103",
                    InsuranceProvider = "xyz",
                    PrescriptionDate = Convert.ToDateTime("2020/10/12"),
                    DrugId = 3,
                    DosagePerDay = 3,
                    PrescriptionCourse = 70,
                    DoctorDetails = "Dr. Munna Bhai M.B.B.S."
                },
                new MemberPrescription
                {
                    PrescriptionId = 110,
                    MemberID = 2,
                    InsurancePolicyNumber = "I103",
                    InsuranceProvider = "xyz",
                    PrescriptionDate = Convert.ToDateTime("2020/10/12"),
                    DrugId = 3,
                    DosagePerDay = 3,
                    PrescriptionCourse = 70,
                    DoctorDetails = "Dr. Munna Bhai M.B.B.S."
                },new MemberPrescription
                {
                    PrescriptionId = 111,
                    MemberID = 3,
                    InsurancePolicyNumber = "I101",
                    InsuranceProvider = "abc",
                    PrescriptionDate = Convert.ToDateTime("2018/10/12"),
                    DrugId = 1,
                    DosagePerDay = 2,
                    PrescriptionCourse = 60,
                    DoctorDetails = "Dr. Raj"
                },
                new MemberPrescription
                {
                    PrescriptionId = 112,
                    MemberID = 3,
                    InsurancePolicyNumber = "I102",
                    InsuranceProvider = "abcxyz",
                    PrescriptionDate = Convert.ToDateTime("2019/10/12"),
                    DrugId = 2,
                    DosagePerDay = 3,
                    PrescriptionCourse = 90,
                    DoctorDetails = "Dr. Nikhil"
                },
                new MemberPrescription
                {
                    PrescriptionId = 113,
                    MemberID = 3,
                    InsurancePolicyNumber = "I103",
                    InsuranceProvider = "xyz",
                    PrescriptionDate = Convert.ToDateTime("2020/10/12"),
                    DrugId = 3,
                    DosagePerDay = 3,
                    PrescriptionCourse = 70,
                    DoctorDetails = "Dr. Munna Bhai M.B.B.S."
                },
                new MemberPrescription
                {
                    PrescriptionId = 114,
                    MemberID = 3,
                    InsurancePolicyNumber = "I103",
                    InsuranceProvider = "xyz",
                    PrescriptionDate = Convert.ToDateTime("2020/10/12"),
                    DrugId = 3,
                    DosagePerDay = 3,
                    PrescriptionCourse = 70,
                    DoctorDetails = "Dr. Munna Bhai M.B.B.S."
                },
                new MemberPrescription
                {
                    PrescriptionId = 115,
                    MemberID = 3,
                    InsurancePolicyNumber = "I103",
                    InsuranceProvider = "xyz",
                    PrescriptionDate = Convert.ToDateTime("2020/10/12"),
                    DrugId = 3,
                    DosagePerDay = 3,
                    PrescriptionCourse = 70,
                    DoctorDetails = "Dr. Munna Bhai M.B.B.S."
                }
            };

            memberSubscriptions = new List<MemberSubscription>
            {
                new MemberSubscription
                {
                    SubscriptionId = 201,
                    MemberId = 1,
                    SubscriptionDate = Convert.ToDateTime("2021/08/08"),
                    PrescriptionId = 101,
                    RefillOccurrence = "Weekly",
                    MemberLocation = "Bangalore",
                    SubscriptionStatus = false
                },
                new MemberSubscription
                {
                    SubscriptionId = 202,
                    MemberId = 1,
                    SubscriptionDate = Convert.ToDateTime("2021/07/08"),
                    PrescriptionId = 102,
                    RefillOccurrence = "Monthly",
                    MemberLocation = "Mysore",
                    SubscriptionStatus = false
                },
                new MemberSubscription
                {
                    SubscriptionId = 203,
                    MemberId = 1,
                    SubscriptionDate = Convert.ToDateTime("2021/08/09"),
                    PrescriptionId = 103,
                    RefillOccurrence = "Weekly",
                    MemberLocation = "Chennai",
                    SubscriptionStatus = false
                },
                new MemberSubscription
                {
                    SubscriptionId = 204,
                    MemberId = 1,
                    SubscriptionDate = Convert.ToDateTime("2021/08/08"),
                    PrescriptionId = 104,
                    RefillOccurrence = "Weekly",
                    MemberLocation = "Bangalore",
                    SubscriptionStatus = false
                },
                new MemberSubscription
                {
                    SubscriptionId = 205,
                    MemberId = 1,
                    SubscriptionDate = Convert.ToDateTime("2021/07/08"),
                    PrescriptionId = 105,
                    RefillOccurrence = "Monthly",
                    MemberLocation = "Mysore",
                    SubscriptionStatus = false
                },
                new MemberSubscription
                {
                    SubscriptionId = 206,
                    MemberId = 2,
                    SubscriptionDate = Convert.ToDateTime("2021/08/08"),
                    PrescriptionId = 106,
                    RefillOccurrence = "Weekly",
                    MemberLocation = "Bangalore",
                    SubscriptionStatus = false
                },
                new MemberSubscription
                {
                    SubscriptionId = 207,
                    MemberId = 2,
                    SubscriptionDate = Convert.ToDateTime("2021/07/08"),
                    PrescriptionId = 107,
                    RefillOccurrence = "Monthly",
                    MemberLocation = "Mysore",
                    SubscriptionStatus = false
                },
                new MemberSubscription
                {
                    SubscriptionId = 208,
                    MemberId = 2,
                    SubscriptionDate = Convert.ToDateTime("2021/08/09"),
                    PrescriptionId = 108,
                    RefillOccurrence = "Weekly",
                    MemberLocation = "Chennai",
                    SubscriptionStatus = false
                },
                new MemberSubscription
                {
                    SubscriptionId = 209,
                    MemberId = 2,
                    SubscriptionDate = Convert.ToDateTime("2021/08/08"),
                    PrescriptionId = 109,
                    RefillOccurrence = "Weekly",
                    MemberLocation = "Bangalore",
                    SubscriptionStatus = false
                },
                new MemberSubscription
                {
                    SubscriptionId = 210,
                    MemberId = 2,
                    SubscriptionDate = Convert.ToDateTime("2021/07/08"),
                    PrescriptionId = 110,
                    RefillOccurrence = "Monthly",
                    MemberLocation = "Mysore",
                    SubscriptionStatus = false
                },
                new MemberSubscription
                {
                    SubscriptionId = 211,
                    MemberId = 3,
                    SubscriptionDate = Convert.ToDateTime("2021/08/08"),
                    PrescriptionId = 111,
                    RefillOccurrence = "Weekly",
                    MemberLocation = "Bangalore",
                    SubscriptionStatus = false
                },
                new MemberSubscription
                {
                    SubscriptionId = 212,
                    MemberId = 3,
                    SubscriptionDate = Convert.ToDateTime("2021/07/08"),
                    PrescriptionId = 112,
                    RefillOccurrence = "Monthly",
                    MemberLocation = "Mysore",
                    SubscriptionStatus = false
                },
                new MemberSubscription
                {
                    SubscriptionId = 213,
                    MemberId = 3,
                    SubscriptionDate = Convert.ToDateTime("2021/08/09"),
                    PrescriptionId = 113,
                    RefillOccurrence = "Weekly",
                    MemberLocation = "Chennai",
                    SubscriptionStatus = false
                },
                new MemberSubscription
                {
                    SubscriptionId = 214,
                    MemberId = 3,
                    SubscriptionDate = Convert.ToDateTime("2021/08/08"),
                    PrescriptionId = 114,
                    RefillOccurrence = "Weekly",
                    MemberLocation = "Bangalore",
                    SubscriptionStatus = false
                },
                new MemberSubscription
                {
                    SubscriptionId = 215,
                    MemberId = 3,
                    SubscriptionDate = Convert.ToDateTime("2021/07/08"),
                    PrescriptionId = 115,
                    RefillOccurrence = "Monthly",
                    MemberLocation = "Mysore",
                    SubscriptionStatus = false
                }
            };
        }
    }
}
