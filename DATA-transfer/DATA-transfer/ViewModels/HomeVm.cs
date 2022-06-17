using DATA_transfer.Models;
using System.Collections.Generic;

namespace DATA_transfer.ViewModels
{
    public class HomeVm
    {
        public List<Group> Groups { get; set; }

        public List<Student>students { get; set; }
    }
}
