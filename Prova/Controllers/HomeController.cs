using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prova.Controllers.Base;
using Prova.Domain.Enums;
using Prova.Domain.Interfaces.Services;
using Prova.Infra.Transactions;


namespace Prova.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IServiceTask _serviceTask;

        public HomeController(IUnitOfWork unitOfWork, IServiceTask serviceTask) : base(unitOfWork)
        {
            _serviceTask = serviceTask;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            try
            {
                var listTask = _serviceTask.GetAll();
                return Response(listTask, _serviceTask);
            }
            catch (Exception ex)
            {
                return ResponseException(ex);
            }
        }

        [HttpGet]
        public JsonResult GetNewTasks()
        {
            try
            {
                var listTask = _serviceTask.GetByStatus(EnumStatusTask.New);
                return Response(listTask, _serviceTask);
            }
            catch (Exception ex)
            {
                return ResponseException(ex);
            }
        }
    }
}
