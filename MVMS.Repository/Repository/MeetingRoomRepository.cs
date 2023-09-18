using Dapper;
using MVMS.DBEngine;
using MVMS.Framework;
using MVMS.Models.Input;
using MVMS.Models.Output;
using MVMS.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVMS.Repository.Repository
{
    public class MeetingRoomRepository: IMeetingRoomRepository
    {
        ISQLHandler serverHandler;
        public MeetingRoomRepository(ISQLHandler serverHandler)
        {
            this.serverHandler = serverHandler;
        }

        public async Task<int> DeleteMeetingRoomDetailsByIdAsync(int Id)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add(DBParameter.MeetingRoomDetails.RoomId, Id, DbType.Int16);

                response = await serverHandler.ExecuteScalarAsync<int>(StroredProc.MeetingRoomDetail.DeleteMeetingRoomsSP, dynamicParameters);

            }
            catch (Exception ex)
            {
            }

            return response;
        }

        public async Task<MeetingRoomResul> GetMeetingRoomDetailsAsync()
        {
            MeetingRoomResul userDetailResult = new MeetingRoomResul();
            try
            {
                
                    userDetailResult.MeetingRoomlList = (await serverHandler.QueryAsync<MeetingRoomlDTO>(StroredProc.MeetingRoomDetail.SelectMeetingRoomsSP)).ToList();
                
            }
            catch (Exception)
            {
            }
            return userDetailResult;
        }

        public async Task<MeetingRoomlDTO> GetMeetingRoomDetailsByIdAsync(int Id)
        {
            MeetingRoomlDTO userDetail = new MeetingRoomlDTO();
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add(DBParameter.MeetingRoomDetails.RoomId, Id, DbType.Int16);

                
                    userDetail = (await serverHandler.QuerySingleAsync<MeetingRoomlDTO>(StroredProc.MeetingRoomDetail.SelectByIdMeetingRoomsSP, dynamicParameters));
                
            }
            catch (Exception)
            {
            }
            return userDetail;
        }

        public async Task<int> InsertMeetingRoomDetailsAsync(MeetingRoomlDTO Room)
        {
            int response = 0;
            {
                try
                {
                    DynamicParameters dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add(DBParameter.MeetingRoomDetails.RoomNo, Room.RoomNo, DbType.String);
                    dynamicParameters.Add(DBParameter.MeetingRoomDetails.Capacity, Room.Capacity, DbType.String);
                    dynamicParameters.Add(DBParameter.MeetingRoomDetails.Location, Room.Location, DbType.String);
                    dynamicParameters.Add(DBParameter.MeetingRoomDetails.Amenities, Room.Amenities, DbType.String);
                    
                    response = await serverHandler.ExecuteScalarAsync<int>(StroredProc.MeetingRoomDetail.InsertMeetingRoomsSP, dynamicParameters);
                }
                catch (Exception)
                {

                }
            }
            return response;
        }

        public async Task<int> UpdateMeetingRoomDetailsAsync(MeetingRoomlDTO Room)
        {

            int response = 0;
            {
                try
                {
                    DynamicParameters dynamicParameters = new DynamicParameters();
                    dynamicParameters.Add(DBParameter.MeetingRoomDetails.RoomId, Room.RoomId, DbType.Int32);
                    dynamicParameters.Add(DBParameter.MeetingRoomDetails.RoomNo, Room.RoomNo, DbType.String);
                    dynamicParameters.Add(DBParameter.MeetingRoomDetails.Capacity, Room.Capacity, DbType.String);
                    dynamicParameters.Add(DBParameter.MeetingRoomDetails.Location, Room.Location, DbType.String);
                    dynamicParameters.Add(DBParameter.MeetingRoomDetails.Amenities, Room.Amenities, DbType.String);

                    response = await serverHandler.ExecuteScalarAsync<int>(StroredProc.MeetingRoomDetail.UpdateMeetingRoomsSP, dynamicParameters);
                }
                catch (Exception)
                {

                }
            }
            return response;
        }
    }
}
