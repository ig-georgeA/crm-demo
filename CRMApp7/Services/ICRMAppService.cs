using CRMApp7.Models.CRMApp;

namespace CRMApp7.CRMApp
{
    public interface ICRMAppService
    {
        Task<List<MeetingsTasksType>> GetMeetingsTasksList();
    }
}
