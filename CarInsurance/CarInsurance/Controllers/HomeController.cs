using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insuree(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, string carModel,
                                    bool hasDUI, int numberOfSpeedingTickets, string fullCoverageOrLiability)
        {


            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) ||
                dateOfBirth == null || string.IsNullOrEmpty(carYear.ToString()) || string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel) ||
                string.IsNullOrEmpty(hasDUI.ToString()) || string.IsNullOrEmpty(numberOfSpeedingTickets.ToString()) || string.IsNullOrEmpty(fullCoverageOrLiability))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (InsuranceEntities db = new InsuranceEntities())
                {

                    var insuree = new Insuree();
                    insuree.FirstName = firstName;
                    insuree.LastName = lastName;
                    insuree.EmailAddress = emailAddress;
                    insuree.DateOfBirth = dateOfBirth;
                    insuree.CarYear = carYear;
                    insuree.CarMake = carMake;
                    insuree.CarModel = carModel;
                    insuree.HasDUI = hasDUI;
                    insuree.NumberOfSpeedingTickets = numberOfSpeedingTickets;
                    insuree.FullCoverageOrLiability = fullCoverageOrLiability;

                    decimal ageQuote = new decimal();
                    if (DateTime.Now.Year - dateOfBirth.Year < 25)
                    {
                        ageQuote = 25;
                    }
                    else if (DateTime.Now.Year - dateOfBirth.Year < 18)
                    {
                        ageQuote = 100;
                    }
                    else if (DateTime.Now.Year - dateOfBirth.Year > 100)
                    {
                        ageQuote = 25;
                    }
                    else
                    {
                        ageQuote = 0;
                    }

                    decimal yearQuote = new decimal();
                    if (carYear < 2000)
                    {
                        yearQuote = 25;
                    }
                    else if (carYear > 2015)
                    {
                        yearQuote = 25;
                    }
                    else
                    {
                        yearQuote = 0;
                    }

                    decimal makeQuote = new decimal();
                    if (carMake == "Porsche")
                    {
                        makeQuote = 25;
                    }
                    else if (carMake == "Porsche" && carModel == "911 Carrera")
                    {
                        makeQuote = 50;
                    }
                    decimal speedingTicketQuote = numberOfSpeedingTickets * 10;
                    decimal hasDUIQuote = new decimal();
                    if (hasDUI == true)
                    {
                        hasDUIQuote = 1.25m;
                    }
                    else
                    {
                        hasDUIQuote = 1;
                    }

                    decimal fullCoverageQuote = new decimal();
                    if (fullCoverageOrLiability == "Full Coverage")
                    {
                        fullCoverageQuote = 1.5m;
                    }
                    else
                    {
                        fullCoverageQuote = 1;
                    }

                    decimal quote = ((yearQuote + ageQuote + makeQuote + speedingTicketQuote + 50) * hasDUIQuote) * fullCoverageQuote;

                    insuree.InsuranceQuote = quote;
                    ViewBag.FinalQuote = quote;


                    db.Insurees.Add(insuree);
                    db.SaveChanges();
                }


                return View("Success");
            }

        }
        public ActionResult Admin()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees.Where(x => x.InsuranceQuote != null).ToList();
                var insureeVms = new List<Insuree>();
                foreach (var signup in insurees)
                {
                    var insureeVm = new Insuree();
                    insureeVm.FirstName = signup.FirstName;
                    insureeVm.LastName = signup.LastName;
                    insureeVm.EmailAddress = signup.EmailAddress;
                    insureeVm.InsuranceQuote = signup.InsuranceQuote;
                }
                return View(insurees);
            }

        }
    }
}