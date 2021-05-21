using BuildingDataProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BuildingDataProject.Core.Entities
{
    public class Building : IEntity<Int16>
    {      
        public Int16 Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string? Location { get; set; }
        public IList<Reading> Readings { get; set; }
    }
}
