using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinaceBilling.Controllers
{
    public abstract class BaseController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="successMessage"></param>
        /// <returns></returns>
        protected JsonResult ReturnAjaxSuccessMessage(string successMessage)
        {
            return Json(new
            {
                success = true,
                message = successMessage
            });
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        protected JsonResult ReturnAjaxErrorMessage(string errorMessage)
        {
            return Json(new
            {
                success = false,
                message = errorMessage
            });
        }

        /// <summary>
        /// Success 
        /// </summary>
        /// <returns></returns>
        protected JsonResult ReturnAjaxSuccessData(object value)
        {
            return Json(new
            {
                success = true,
                message = value
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        protected JsonResult ReturnJsonResult(object value)
        {
            return Json(value);
        }
    }
}
