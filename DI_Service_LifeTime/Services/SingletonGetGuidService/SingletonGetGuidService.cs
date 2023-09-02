namespace DI_Service_LifeTime.Services
{
    public class SingletonGetGuidService : ISingletonGetGuidService
    {
        private readonly Guid id;
        public SingletonGetGuidService()
        {
            id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return id.ToString();
        }
    }
}
