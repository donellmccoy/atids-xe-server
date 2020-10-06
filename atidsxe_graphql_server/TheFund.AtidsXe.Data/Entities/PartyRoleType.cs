using System.Collections.Generic;

namespace TheFund.AtidsXe.Data.Entities
{
    public partial class PartyRoleType
    {
        public PartyRoleType()
        {
            Party = new HashSet<Party>();
        }

        public int PartyRoleTypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Party> Party { get; set; }
    }
}