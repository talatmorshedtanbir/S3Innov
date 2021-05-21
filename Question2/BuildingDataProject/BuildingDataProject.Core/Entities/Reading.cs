using BuildingDataProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BuildingDataProject.Core.Entities
{
    public class Reading : IEntity<int>
    {
        public int Id { get; set; }
        public Int16 BuildingId { get; set; }
        public Byte ObjectId { get; set; }
        public Byte DataFieldId { get; set; }
        [MaxLength(18), MinLength(2)]
        public decimal Value { get; set; }
        public DateTime Timestamp { get; set; }
        public Building Building { get; set; }
        public Object Object { get; set; }
        public DataField DataField { get; set; }
    }
}
