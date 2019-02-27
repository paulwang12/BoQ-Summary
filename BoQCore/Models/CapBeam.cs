﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoQCore
{
    public class CapBeam : BaseModel
    {
        public double DimLong,DimVertical;

        public CapBeam():base()
        {
            DimLong = 0;
            DimVertical = 0;            
        }

        public CapBeam(double l, double dl,double dv, double rhorebar, double rhoprerebar)
            : base(l,rhorebar, rhoprerebar)
        {
            DimLong = dl;
            DimVertical = dv;
            Vc = dl * dv * l;
        }

        public override void WriteData(ref DataTable dt, string br, int xmh1, int xmh2)
        {
            throw new NotImplementedException();
        }
    }
}
