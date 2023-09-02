namespace DI_Service_LifeTime.Services
{
    public class TransientGetGuidService : ITransientGetGuidService
    {
        private readonly Guid id;
        public TransientGetGuidService()
        {
            id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return id.ToString();
        }
    }
}
