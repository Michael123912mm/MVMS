using MVMS.Models.Input;
using MVMS.Models.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVMS.Repository.Interface
{
    public interface ITeamRepository
    {
        Task<TeamDetailResultDTO> GetUserDetailsAsync();
        Task<TeamDetailDTO> GetUserDetailsByIdAsync(int Id);
        Task<int> DeleteUserDetailsByIdAsync(int Id);
        Task<int> SaveUserDetailsAsync(TeamDetailDTO user);
    }
}
