using Borjomi.Data.Intetfaces;
using Borjomi.Data.Models;
using Borjomi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Borjomi.Controllers
{
    public class StaffController : Controller
    {
        private readonly IStaff _allStaff;

        public StaffController(IStaff allStaff)
        {
            _allStaff = allStaff;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Сотрудники";
            StaffListViewModel obj = new StaffListViewModel();
            obj.getAllStaff = _allStaff.AllStaff;
            return View(obj);
        }


        

    }
}
