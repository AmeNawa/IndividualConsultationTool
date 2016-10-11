namespace IndividualConsultationTool.Repository.Mappers.SecureServiceForMappers
{
    public interface EntitySecureService<T> where T : Entity.IEntity
    {
        void DecryptEntity(T source);
        void EncryptEntity(T source);
    }
}
