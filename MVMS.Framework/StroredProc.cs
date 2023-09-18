using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVMS.Framework
{
    public class StroredProc
    {
        public class MeetingRoomDetail
        {

            public const string SelectMeetingRoomsSP = "[Room].[SelectMeetingRoomsSP]";
            public const string InsertMeetingRoomsSP = "[Room].[InsertMeetingRoomsSP]";
            public const string SelectByIdMeetingRoomsSP = "[Room].[SelectByIdMeetingRoomsSP]";
            public const string UpdateMeetingRoomsSP = "[Room].[UpdateMeetingRoomsSP]";
            public const string DeleteMeetingRoomsSP = "[Room].[DeleteMeetingRoomsSP]";

        }
    }
}
