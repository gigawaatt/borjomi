using Borjomi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Borjomi.ViewModels
{
    public class StaffListViewModel
    {
        public IEnumerable<Staff> getAllStaff { get; set; }
    }
}
