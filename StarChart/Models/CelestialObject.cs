﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StarChart.Models
{
    public class CelestialObject
    {
        public int Id;

        public int? OrbitedObjectId { get; set; }

        [Required]
        public string Name { get; set; }

        [NotMapped]
        private List<CelestialObject> Satellites { get; set; }

        public TimeSpan OrbitalPeriod { get; set; }
    }
}