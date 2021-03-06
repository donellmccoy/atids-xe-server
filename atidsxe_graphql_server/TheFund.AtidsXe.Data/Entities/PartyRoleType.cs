﻿using System.Collections.Generic;
using TheFund.AtidsXe.Common.Attributes;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PartyRoleType
    {
        public PartyRoleType()
        {
            Parties = new HashSet<Party>();
        }

        public int PartyRoleTypeId { get; set; }

        [Trim]
        public string Description { get; set; }

        public virtual ICollection<Party> Parties { get; set; }
    }
}