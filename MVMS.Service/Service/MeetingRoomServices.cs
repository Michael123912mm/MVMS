using MVMS.Framework;
using MVMS.Models;
using MVMS.Models.Input;
using MVMS.Models.Output;
using MVMS.Repository.Interface;
using MVMS.Service.Interface;

namespace MVMS.Service.Service
{
    public class MeetingRoomServices: IMeetingRoomServices
    {

        IMeetingRoomRepository _Repository;
        public MeetingRoomServices(IMeetingRoomRepository meetingRoomRepository)
        {
            _Repository = meetingRoomRepository;
        }

        public async Task<ResultArgs> DeleteMeetingRoomDetailsByIdAsync(int Id)
        {
            ResultArgs resultArgs = new ResultArgs();

            try
            {
                int result = await _Repository.DeleteMeetingRoomDetailsByIdAsync(Id);
                if (result == 0)
                {
                    resultArgs.StatusCode = MessageCatalog.ErrorCodes.Success;
                    resultArgs.StatusMessage = MessageCatalog.ErrorMessages.Success;
                    resultArgs.MessageTitle = MessageCatalog.MessageTitle.MeetingRoomDetails;
                }
                else
                {
                    resultArgs.StatusCode = MessageCatalog.ErrorCodes.BadRequest;
                    resultArgs.StatusMessage = MessageCatalog.ErrorMessages.BadRequest;
                }
            }
            catch (Exception ex)
            {
               
                
            }

            return resultArgs;

        }

        public async Task<ResultArgs> GetMeetingRoomDetailsAsync()
        {
            ResultArgs resultArgs = new ResultArgs();
            try
            {
                MeetingRoomResul obj = await _Repository.GetMeetingRoomDetailsAsync();

                if (obj != null)
                {
                    resultArgs.StatusCode = MessageCatalog.ErrorCodes.Success;
                    resultArgs.StatusMessage = MessageCatalog.ErrorMessages.Success;
                    resultArgs.MessageTitle = MessageCatalog.MessageTitle.MeetingRoomDetails;
                    resultArgs.ResultData = obj.MeetingRoomlList;

                }
                else
                {
                    resultArgs.StatusCode = MessageCatalog.ErrorCodes.BadRequest;
                    resultArgs.StatusMessage = MessageCatalog.ErrorMessages.BadRequest;
                }
            }
            catch(Exception)
            {

            }
            return resultArgs;
        }

        public async Task<ResultArgs> GetMeetingRoomDetailsByIdAsync(int Id)
        {
            ResultArgs resultArgs = new ResultArgs();
            try
            {

                MeetingRoomlDTO obj = await _Repository.GetMeetingRoomDetailsByIdAsync(Id);
                if (obj != null)
                {
                    resultArgs.StatusCode = MessageCatalog.ErrorCodes.Success;
                    resultArgs.StatusMessage = MessageCatalog.ErrorMessages.Success;
                    resultArgs.MessageTitle = MessageCatalog.MessageTitle.MeetingRoomDetails;
                    resultArgs.ResultData = obj;


                }
                else
                {
                    resultArgs.StatusCode = MessageCatalog.ErrorCodes.BadRequest;
                    resultArgs.StatusMessage = MessageCatalog.ErrorMessages.BadRequest;
                }
            }
            catch(Exception)
            {

            }
            return resultArgs;
        }

        public async Task<ResultArgs> InsertMeetingRoomDetailsAsync(MeetingRoomlDTO Room)
        {
            ResultArgs resultArgs = new ResultArgs();
            try
            {

                int result = await _Repository.InsertMeetingRoomDetailsAsync(Room);
                if (result == 0)
                {
                    resultArgs.StatusCode = MessageCatalog.ErrorCodes.Success;
                    resultArgs.StatusMessage = MessageCatalog.ErrorMessages.Success;
                    resultArgs.MessageTitle = MessageCatalog.MessageTitle.MeetingRoomDetails;
                }
                else
                {
                    resultArgs.StatusCode = MessageCatalog.ErrorCodes.BadRequest;
                    resultArgs.StatusMessage = MessageCatalog.ErrorMessages.BadRequest;
                }
            }
            catch(Exception)
            {

            }
            return resultArgs;
        }

        public async Task<ResultArgs> UpdateMeetingRoomDetailsAsync(MeetingRoomlDTO Room)
        {
            ResultArgs resultArgs = new ResultArgs();
            try
            {
                int result = await _Repository.UpdateMeetingRoomDetailsAsync(Room);
                if (result == 0)
                {

                    resultArgs.StatusCode = MessageCatalog.ErrorCodes.Success;
                    resultArgs.StatusMessage = MessageCatalog.ErrorMessages.Success;
                    resultArgs.MessageTitle = MessageCatalog.MessageTitle.MeetingRoomDetails;
                }
                else
                {

                    resultArgs.StatusCode = MessageCatalog.ErrorCodes.BadRequest;
                    resultArgs.StatusMessage = MessageCatalog.ErrorMessages.BadRequest;
                }
            }
            catch(Exception)
            {

            }
            return resultArgs;
        }
    }
}