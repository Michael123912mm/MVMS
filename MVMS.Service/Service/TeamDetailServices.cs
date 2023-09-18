using MVMS.Models;
using MVMS.Models.Input;
using MVMS.Models.Output;
using MVMS.Repository.Interface;
using MVMS.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVMS.Service.Service
{
    public class TeamDetailServices : ITeamDetailServices
    {
        ITeamRepository _TeamRepository;


        public TeamDetailServices(ITeamRepository TeamDetail)
        {
            this._TeamRepository = TeamDetail;
        }

        public async Task<ResultArgs> DeleteUserDetailsByIdAsync(int Id)
        {
            ResultArgs resultArgs = new ResultArgs();

            int result = await _TeamRepository.DeleteUserDetailsByIdAsync(Id);
            if (result == 0)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record Deleted Successfully";

            }
            else
            {
                resultArgs.StatusCode = 400;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;
        }

        public async Task<ResultArgs> GetUserDetailsAsync()
        {
            ResultArgs resultArgs = new ResultArgs();
            TeamDetailResultDTO obj = await _TeamRepository.GetUserDetailsAsync();


            if (obj != null)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record load Successfully";
                resultArgs.ResultData = obj.TeamDetailList;

            }
            else
            {
                resultArgs.StatusCode = 400;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;

        }

        public async Task<ResultArgs> GetUserDetailsByIdAsync(int Id)
        {
            ResultArgs resultArgs = new ResultArgs();

            TeamDetailDTO obj = await _TeamRepository.GetUserDetailsByIdAsync(Id);
            if (obj != null)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record load Successfully";
                resultArgs.ResultData = obj;

            }
            else
            {
                resultArgs.StatusCode = 400;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;
        }

        public async Task<ResultArgs> SaveUserDetailsAsync(TeamDetailDTO user)
        {
            ResultArgs resultArgs = new ResultArgs();

            int result = await _TeamRepository.SaveUserDetailsAsync(user);
            if (result == 0)
            {
                resultArgs.StatusCode = 200;
                resultArgs.StatusMessage = "Record Save Successfully";
            }
            else
            {
                resultArgs.StatusCode = 400;
                resultArgs.StatusMessage = "Unable to Save records";
            }
            return resultArgs;

        }
    }
}
