using BuildingDataProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BuildingDataProject.Core.Entities
{
    public class Object : IEntity<Byte>
    {
        public Byte Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        public IList<Reading> Readings { get; set; }
    }
}
