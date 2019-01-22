using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Prova.Domain.Interfaces.Services.Base;
using Prova.Infra.Transactions;

namespace Prova.Controllers.Base
{
    public class BaseController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private IServiceBase _serviceBase;

        public BaseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public JsonResult Response(object result, IServiceBase serviceBase)
        {
            _serviceBase = serviceBase;

            if (!serviceBase.Notifications.Any())
            {
                try
                {
                    _unitOfWork.Commit();

                    return Json(new { ok = true, result = JsonConvert.SerializeObject(result) });
                }
                catch (Exception)
                {
                    return Json(new { ok = false, errors = "Houve um problema interno com o servidor." });
                }
            }
            else
            {
                return Json(new { ok = false, errors = serviceBase.Notifications });
            }
        }

        public JsonResult ResponseException(Exception exception)
        {
            return Json(new { ok = false, errors = exception.Message, exception = exception.ToString() });
        }
    }
}
