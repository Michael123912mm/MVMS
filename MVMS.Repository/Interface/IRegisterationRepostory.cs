using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVMS.Repository.Interface
{
    public class IRegisterationRepostory
    {
        Task<UserDetailResult> GetUserDetailsAsync();
        Task<UserDetailsDTO> GetUserDetailsByIdAsync(int Id);

        Task<int> AddUserDetailsAsync(UserDetailsDTO userDetailDTO);

        Task<int> UpdateUserDetailsAsync(UserDetailsDTO userDetailDTO);

        Task<int> DeleteUserDetailsAsync(int Id);

    }
}
