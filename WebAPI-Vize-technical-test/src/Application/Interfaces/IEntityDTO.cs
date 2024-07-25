namespace WebAPI_Vize_technical_test.src.Application
{
    public interface IEntityDTO
    {
        public Guid Id { get; init; }
        public DateTime CreatedAt { get; init; }
        public DateTime UpdatedAt { get; init; }
    }
}