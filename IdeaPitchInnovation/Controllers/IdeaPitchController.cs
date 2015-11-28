namespace IdeaPitchInnovation.Controllers
{
    #region NameSpace

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using IdeaPitch.Entity;
    using IdeaPitch.Processing;
    using System.Collections;

    #endregion 

    /// <summary>
    /// Main Controller, responsible for data manipulation and interpretation 
    /// </summary>
    public class IdeaPitchController : Controller
    {
        /// <summary>
        /// Involved in pre populating the Innovation data and viewing the same in the landing screen
        /// </summary>
        /// <returns> The Landing screen and the resulting page </returns>
        public ActionResult LandingScreen()
        {
            var userView = new InnovationData();
            var innovationFormExtract = new InnovationFormPopulation(userView);
            return View(userView);
        }

        /// <summary>
        /// Data obtained from the User. The core innovative idea!
        /// </summary>
        /// <param name="innovativeOutput"> The innovation entity responsible for further manipulation </param>
        /// <returns>The success page</returns>
        public ActionResult UserInnovation(InnovationData innovativeOutput)
        {
            var check = innovativeOutput;
            return View();
        }

        public ActionResult Terms()
        {
            return View();
        }

    }
}
