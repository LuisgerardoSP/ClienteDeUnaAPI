﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisorTerremotos.Objetos
{
    internal class Properties
    {
        public double Mag { get; set; }
        public string Place { get; set; }
        public object Time { get; set; }
        public object Updated { get; set; }
        public object Tz { get; set; }
        public string Url { get; set; }
        public string Detail { get; set; }
        public object Felt { get; set; }
        public object Cdi { get; set; }
        public object Mmi { get; set; }
        public object Alert { get; set; }
        public string Status { get; set; }
        public int Tsunami { get; set; }
        public int Sig { get; set; }
        public string Net { get; set; }
        public string Code { get; set; }
        public string Ids { get; set; }
        public string Sources { get; set; }
        public string Types { get; set; }
        public int? Nst { get; set; }
        public double? Dmin { get; set; }
        public double Rms { get; set; }
        public int? Gap { get; set; }
        public string MagType { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
    }
}
