using MVMS.Models.Input;
using MVMS.Models.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVMS.Repository.Interface
{
   public interface IMeetingRoomRepository
    {
        
            Task<MeetingRoomResul> GetMeetingRoomDetailsAsync();
            Task<MeetingRoomlDTO> GetMeetingRoomDetailsByIdAsync(int Id);
            Task<int> DeleteMeetingRoomDetailsByIdAsync(int Id);
            Task<int> InsertMeetingRoomDetailsAsync(MeetingRoomlDTO Room);
            Task<int> UpdateMeetingRoomDetailsAsync(MeetingRoomlDTO Room);
        
    }
}
