using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using TravelAgency.Domain.Common;

namespace TravelAgency.Domain.Entities
{
    public class Package : BaseEntity
    {
        public string Description { get; set; } = null!;
        public double Price { get; set; }
        public int Capacity { get; set; }
        public int Duration { get; set; }
        public int StartDate { get; set; }
        public int FinishDate { get; set; }
    }
}