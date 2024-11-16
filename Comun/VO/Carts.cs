﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    [DataContract]
    public class Carts
    {
        [DataMember(EmitDefaultValue = false)]
        public int Id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int TotalPrice { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }
    }
}
