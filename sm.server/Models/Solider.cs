using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sm.server.Models
{
    public class Solider
    {
        public string Nick { get; set; }
        public PosVextor3 Pos { get; set; }
        public PosVextor3 Velocity { get; set; }
    }

    public class PosVextor3
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
    }
}
