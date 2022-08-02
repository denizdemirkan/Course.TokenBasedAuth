using System.Text.Json.Serialization;

namespace Course.TokenBasedAuth.SharedLibrary.DTOs
{
    public class ResponceDTO<T> where T : class
    {
        public T Data { get; set; }

        public ErrorDTO Error { get; set; }

        public int StatusCode { get; set; }

        [JsonIgnore]
        // JsonIgnore for not to open this property to the client and keep it for internal use only.
        public bool IsSuccessful { get; set; }

        public static ResponceDTO<T> Success(T data, int statusCode)
        {
            return new ResponceDTO<T>
            {
                Data = data,
                StatusCode = statusCode,
                IsSuccessful = true
            };
        }

        public static ResponceDTO<T> Success(int statusCode)
        {
            return new ResponceDTO<T>
            {
                Data = null,
                StatusCode = statusCode,
                IsSuccessful = true
            };
        }

        public static ResponceDTO<T> Fail(ErrorDTO error, int statusCode)
        {
            return new ResponceDTO<T>
            {
                Error = error,
                StatusCode = statusCode,
                IsSuccessful = false
            };
        }

        public static ResponceDTO<T> Fail(string error, int statusCode, bool isVisible)
        {
            var errorDto = new ErrorDTO(error, isVisible);

            return new ResponceDTO<T>
            {
                Error = errorDto,
                StatusCode = statusCode,
                IsSuccessful = false
            };
        }
    }
}
