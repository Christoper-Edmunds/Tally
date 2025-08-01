﻿namespace Tally.Core.Models.Entities
{
    public class Container : BaseEntity
    {
        // Foreign key
        public int LocationId { get; set; }
        // Navigation property
        public Location? Location { get; set; }
        // Foreign key for Common Category
    }
}
