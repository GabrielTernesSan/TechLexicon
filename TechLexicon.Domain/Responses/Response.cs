namespace TechLexicon.Domain.Responses
{
    public class Response<T>
    {
        public T? Result { get; set; }
        public List<string> Errors { get; set; }

        public Response()
        {
            Errors = new List<string>();
        }

        public void AddError(string error)
        {
            Errors.Add(error);
        }
    }
}
