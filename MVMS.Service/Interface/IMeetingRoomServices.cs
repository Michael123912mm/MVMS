using MVMS.Models;
using MVMS.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVMS.Service.Interface
{
    public interface IMeetingRoomServices
    {
            Task<ResultArgs> GetMeetingRoomDetailsAsync();
            Task<ResultArgs> GetMeetingRoomDetailsByIdAsync(int Id);
            Task<ResultArgs> DeleteMeetingRoomDetailsByIdAsync(int Id);
            Task<ResultArgs> InsertMeetingRoomDetailsAsync(MeetingRoomlDTO Room);
            Task<ResultArgs> UpdateMeetingRoomDetailsAsync(MeetingRoomlDTO Room);
    }
}
