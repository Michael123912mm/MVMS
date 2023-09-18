using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVMS.Models.Input;
using MVMS.Service.Interface;

namespace MVMS.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        ITeamDetailServices _userDetailsService;

        public TeamController(ITeamDetailServices userDetailsService)
        {
            _userDetailsService = userDetailsService;
        }
        // GET: api/<UserDetailsController>


        /// <summary>
        ///  To Get all the Active User Details 
        /// </summary>
        /// <returns>this will return the user data as object</returns>
        /// 

        /// <remarks>
        /// Sample request:
        ///
        /// POST /Todo
        /// {
        /// "id": 1,
        /// "name": "Item1",
        /// "isComplete": true
        /// }
        ///
        /// </remarks>
        /// 
        /// <response code="201">Returns the newly created item</response>
        /// <response code="202">Update </response>
        /// <response code="203">already exists </response>
        /// <response code="204">faild to update the data </response>
        /// <response code="400">If the item is null</response>
        /// 
        [HttpGet]
        [ActionName("GetUserDetails")]
        public async Task<IActionResult> GetUserDetailsAsync()
        {
            return Ok(await _userDetailsService.GetUserDetailsAsync());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName("GetUserDetailsByIdAsync")]
        public async Task<IActionResult> GetUserDetailsByIdAsync([FromQuery] int id)
        {
            return Ok(await _userDetailsService.GetUserDetailsByIdAsync(id));
        }

        /// <summary>
        ///  To save the user daa to database  
        /// </summary>
        /// <returns>this will return the user data as object</returns>
        /// <remarks>
        /// Sample request:
        ///
        /// POST /Todo
        ///  {
        ///   "id": 0,
        ///  "firstName": "Demo",
        ///  "lastName": "Admin",
        ///   "age": 30,
        ///  "address1": "Athanavoor",
        ///  "address1": "Yelagiri Hills"
        /// }
        /// </remarks> 
        /// <response code="201">Returns the newly created item</response>
        /// <response code="202">Update </response>
        /// <response code="203">already exists </response>
        /// <response code="204">faild to update the data </response>
        /// <response code="400">If the item is null</response>
        // POST api/<UserDetailsController>
        [HttpPost]
        [ActionName("SaveUserDetailsAsync")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SaveUserDetailsAsync([FromBody] TeamDetailDTO obj)
        {
            return Ok(await _userDetailsService.SaveUserDetailsAsync(obj));
        }


        // PUT api/<UserDetailsController>/5
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ActionName("SaveUserDetailsAsync")]

        public async Task<IActionResult> SaveUserDetailsAsync(int id, [FromBody] TeamDetailDTO obj)
        {
            obj.TeamId = id;
            return Ok(await _userDetailsService.SaveUserDetailsAsync(obj));
        }


        // DELETE api/<UserDetailsController>/5 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [ActionName("DeleteByIdAsync")]
        public async Task<IActionResult> DeleteUserDetailsByIdAsync([FromQuery] int id)
        {
            return Ok(await _userDetailsService.DeleteUserDetailsByIdAsync(id));
        }
    }
}
