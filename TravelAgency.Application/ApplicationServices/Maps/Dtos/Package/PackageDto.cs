using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Application.ApplicationServices.Maps.Dtos.Package
{
    public class PackageDto
    {
        public int Id {get; set;} = 0;
        public string Description {get; set;}
        public int Price{get; set;}
        public int Capacity { get; set; }
        public int Duration { get; set; }
        public int StartDate { get; set; }
        public int FinishDate { get; set; }
    }
}