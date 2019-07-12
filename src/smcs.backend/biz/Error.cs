public class Error
{
    public int Id { get; private set; }
    public string Message { get; private set; }

    public Error(int id, string message)
    {
        this.Id = id;
        this.Message = message;
    }
}