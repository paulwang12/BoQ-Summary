﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BoQCore
{
    public class Pier : BaseModel
    {
        public double DimLong;
        public Pier():base()
        {
            DimLong = 0;
        }

        public Pier(double l,double rhorebar, double rhoprerebar) : base(l,rhorebar, rhoprerebar)
        {
        }

        public override void WriteData(ref DataTable dt, string br, int xmh1, int xmh2)
        {
            throw new NotImplementedException();
        }
    }
}
