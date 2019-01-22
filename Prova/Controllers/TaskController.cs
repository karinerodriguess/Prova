using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Prova.Controllers.Base;
using Prova.Domain.Arguments.Task;
using Prova.Domain.Interfaces.Services;
using Prova.Infra.Transactions;
using Prova.ViewModels;

namespace Prova.Controllers
{
    public class TaskController : BaseController
    {
        private readonly IServiceTask _serviceTask;

        public TaskController(IUnitOfWork unitOfWork, IServiceTask serviceTask) : base(unitOfWork)
        {
            _serviceTask = serviceTask;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(Guid id)
        {
            var task = _serviceTask.GetById(id);

            TaskViewModel viewModel = new TaskViewModel
            {
                Id = task.Id,
                Title = task.Title,
                Description = task.Description,
                Status = (int)task.Status,
                CreatedDate=task.CreatedDate
            };

            return View(viewModel);
        }

        [HttpPost]
        public JsonResult Add(AddTaskRequest request)
        {
            try
            {
                var response = _serviceTask.Add(request);
                return Response(response, _serviceTask);
            }
            catch (Exception ex)
            {
                return ResponseException(ex);
            }
        }

        [HttpPost]
        public JsonResult Edit(EditTaskRequest request)
        {
            try
            {
                var response = _serviceTask.Edit(request);
                return Response(response, _serviceTask);
            }
            catch (Exception ex)
            {
                return ResponseException(ex);
            }
        }

        [HttpPost]
        public JsonResult Remove(RemoveTaskRequest request)
        {
            try
            {
                var response = _serviceTask.Remove(request);
                return Response(response, _serviceTask);
            }
            catch (Exception ex)
            {
                return ResponseException(ex);
            }
        }

        [HttpGet]
        public JsonResult GetTask(Guid id)
        {
            try
            {
                var task = _serviceTask.GetById(id);
                return Response(task, _serviceTask);
            }
            catch (Exception ex)
            {
                return ResponseException(ex);
            }
        }
    }
}
