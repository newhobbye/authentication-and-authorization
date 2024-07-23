namespace authentication_and_authorization_api.Models.Response
{
    public class ResponseModel<T>
    {
        public bool IsSuccessful { get; set; }
        public int StatusCode { get; set; }
        public IEnumerable<PropertyError> Errors { get; set; } = new List<PropertyError>();
        public T? Data { get; set; }
    }

    public class PropertyError
    {
        public string Property { get; set; } = "";
        public IEnumerable<string> ErrorMessages { get; set; } = new List<string>();
    }
}
