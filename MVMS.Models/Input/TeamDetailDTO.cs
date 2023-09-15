using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVMS.Models.Input
{
    public class TeamDetailDTO
    {
        public int? TeamId { get; set; }
        public string? TeamLeader { get; set; }
        public string? TeamName { get; set; }
        public string? TeamMember { get; set; }
    }
}
