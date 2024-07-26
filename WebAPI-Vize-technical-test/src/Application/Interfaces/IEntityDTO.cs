namespace WebAPI_Vize_technical_test.src.Application
{
    public interface IEntityDTO
    {
        Guid Id { get; }
        DateTime CreatedAt { get; }
        DateTime UpdatedAt { get; }
    }
}