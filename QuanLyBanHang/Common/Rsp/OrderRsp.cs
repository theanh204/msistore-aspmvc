﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Rsp
{
    public class OrderRsp
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? UserId { get; set; }
    }
}
