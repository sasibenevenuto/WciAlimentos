﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.General
{
    public class BaseModel
    {
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifieldDate { get; set; }
        public int UserID { get; set; }
        public int UserIDLastUpdate { get; set; }
    }
}
