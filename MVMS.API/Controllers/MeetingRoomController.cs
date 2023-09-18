using Microsoft.AspNetCore.Mvc;
using MVMS.Models.Input;
using MVMS.Service.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingRoomController : ControllerBase
    {

        IMeetingRoomServices _meetingRoomService;
        public MeetingRoomController(IMeetingRoomServices meetingRoomService)
        {
            _meetingRoomService = meetingRoomService;
        }
        // GET: api/<MeetingRoomController>
        [HttpGet]
        [ActionName("GetInventoryDetails")]
        public async Task<IActionResult> GetMeetingRoomDetailsAsync()
        {
            return Ok(await _meetingRoomService.GetMeetingRoomDetailsAsync());
        }

        // GET api/<MeetingRoomController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMeetingRoomDetailsByIdAsync(int id)
        {
            return Ok(await _meetingRoomService.GetMeetingRoomDetailsByIdAsync(id));
        }

        // POST api/<MeetingRoomController>
        [HttpPost]
        [ActionName("InsertInventoryDetailsAsync")]
        public async Task<IActionResult> InsertMeetingRoomDetailsAsync([FromBody] MeetingRoomlDTO obj)
        {
            return Ok(await _meetingRoomService.InsertMeetingRoomDetailsAsync(obj));
        }


        // PUT api/<MeetingRoomController>/5
        [HttpPut("{id}")]
        [ActionName("UpdateInventoryDetailsAsync")]
        public async Task<IActionResult> UpdateMeetingRoomDetailsAsync(int id, [FromBody] MeetingRoomlDTO obj)
        {
            obj.RoomId = id;
            return Ok(await _meetingRoomService.UpdateMeetingRoomDetailsAsync(obj));
        }

        // DELETE api/<MeetingRoomController>/5
        [HttpDelete("{id}")]
        [ActionName("DeleteInventoryDetailsByIdAsync")]
        public async Task<IActionResult> DeleteMeetingRoomDetailsByIdAsync(int id)
        {
            return Ok(await _meetingRoomService.DeleteMeetingRoomDetailsByIdAsync(id));
        }
    }
}
