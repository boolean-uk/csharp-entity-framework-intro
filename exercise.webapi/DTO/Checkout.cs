namespace exercise.webapi.DTO
{
    public record CheckoutPost(int BookId);
    public record CheckoutView(int Id, DateTime CheckoutTime, DateTime? ReturnTime, DateTime ExpectedReturnTime, BookInternalAuthorPublisher Book);
    public record CheckoutInternal(int Id, DateTime CheckoutTime, DateTime? ReturnTime, DateTime ExpectedReturnTime);
}
