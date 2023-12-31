﻿using System;
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
    public class MeetingRoomlDTO
    {
        public int? RoomId { get; set; }
        public string? RoomNo { get; set; }
        public string? Capacity { get; set; }
        public string? Location { get; set; }
        public string? Amenities { get; set; }
    
     }
}
