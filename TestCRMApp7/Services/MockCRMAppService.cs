using CRMApp7.Models.CRMApp;

namespace CRMApp7.CRMApp
{
    public class MockCRMAppService : ICRMAppService
    {
        public Task<List<MeetingsTasksType>> GetMeetingsTasksList()
        {
            return Task.FromResult<List<MeetingsTasksType>>(new());
        }
    }
}
