using MVMS.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVMS.Models.Output
{
    public class TeamDetailResultDTO
    {
        public TeamDetailDTO? TeamDetail { get; set; }

        public List<TeamDetailDTO>? TeamDetailList { get; set; }
    }
    public class MeetingRoomResul
    {
        public MeetingRoomlDTO? MeetingRoomDetail { get; set; }

        public List<MeetingRoomlDTO>? MeetingRoomlList { get; set; }
    }
}
