using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVMS.Service.Interface
{
    public class IUserDetailsService
    {
        Task<ResultDataArgs> AddUserDetailsAsync(UserDetailsDTO userDetailDTO);

        Task<ResultDataArgs> DeleteUserDetailsAsync(int Id);

        Task<ResultDataArgs> GetUserDetailsAsync();

        Task<ResultDataArgs> GetUserDetailsByIdAsync(int Id);

        Task<ResultDataArgs> UpdateUserDetailsAsync(UserDetailsDTO userDetailDTO);

    }
}
