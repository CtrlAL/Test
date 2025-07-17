namespace Api.Models.Response
{
    public class ApiResponse<T>
    {
        public bool IsSuccess { get; }
        public T Data { get; }
        public string Error { get; }
        public string ErrorProperty { get; }

        private ApiResponse(T data)
        {
            IsSuccess = true;
            Data = data;
            Error = string.Empty;
            ErrorProperty = string.Empty;
        }

        private ApiResponse(string error, string property)
        {
            IsSuccess = false;
            Data = default;
            Error = error ?? "An unknown error occurred.";
            ErrorProperty = property;
        }

        public static ApiResponse<T> Success(T data) => new(data);
        public static ApiResponse<T> Fail(string error, string property = "") => new(error, property);
    }
}
