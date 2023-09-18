using Dapper;
using MVMS.DBEngine;
using MVMS.Models.Input;
using MVMS.Models.Output;
using MVMS.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVMS.Repository.Repository
{
    public class TeamRepository : ITeamRepository
    {
        ISQLHandler _serverHandler;

        public TeamRepository(ISQLHandler serverHandler)
        {
            this._serverHandler = serverHandler;
        }

        public async Task<int> DeleteUserDetailsByIdAsync(int Id)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@TeamId", Id, DbType.Int16);

                response = await _serverHandler.ExecuteScalarAsync<int>("[TEAM].[TeamDelete]", dynamicParameters);

            }
            catch (Exception ex)
            {
            }
            return response;
        }

        public async Task<TeamDetailResultDTO> GetUserDetailsAsync()
        {
            TeamDetailResultDTO teamDetailDTO = new TeamDetailResultDTO();
            try
            {
               
                teamDetailDTO.TeamDetailList = (await _serverHandler.QueryAsync<TeamDetailDTO>("[TEAM].[TeamGet]")).ToList();

                
            }
            catch (Exception)
            {
            }
            return teamDetailDTO;
        }

        public async Task<TeamDetailDTO> GetUserDetailsByIdAsync(int Id)
        {
            TeamDetailDTO userDetail = new TeamDetailDTO();
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@TeamId", Id, DbType.Int16);

               
                    userDetail = (await _serverHandler.QuerySingleAsync<TeamDetailDTO>("[TEAM].[TeamGetById]", dynamicParameters));
                
            }
            catch (Exception ex)
            {
            }
            return userDetail;
        }

        public async Task<int> SaveUserDetailsAsync(TeamDetailDTO user)
        {
            int response = 0;
            try
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@TeamId", user.TeamId, DbType.Int16);
                dynamicParameters.Add("@TeamLeader", user.TeamLeader, DbType.String);
                dynamicParameters.Add("@TeamName", user.TeamName, DbType.String);
                dynamicParameters.Add("@TeamMember", user.TeamMember, DbType.String);


                response = await _serverHandler.ExecuteScalarAsync<int>("[TEAM].[TeamInsertOrUpdate]", dynamicParameters);

            }
            catch (Exception ex)
            {
            }
            return response;
        }
    }
}
