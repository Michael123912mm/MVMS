using MVMS.Models.Input;
using MVMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVMS.Service.Interface
{
    public interface ITeamDetailServices
    {
        Task<ResultArgs> GetUserDetailsAsync();
        Task<ResultArgs> GetUserDetailsByIdAsync(int Id);
        Task<ResultArgs> DeleteUserDetailsByIdAsync(int Id);
        Task<ResultArgs> SaveUserDetailsAsync(TeamDetailDTO user);
    }
}
