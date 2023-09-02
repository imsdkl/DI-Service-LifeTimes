namespace DI_Service_LifeTime.Services
{
    public class ScopedGetGuidService : IScopedGetGuidService
    {
        private readonly Guid id;
        public ScopedGetGuidService()
        {
            id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return id.ToString();
        }
    }
}
