﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace whnXX.Moldes
{
    public class TouristRoutePicture
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public Guid TouristRouteId { get; set; }

        public TouristRoute TouristRoute{ get; set; }


    }
}
