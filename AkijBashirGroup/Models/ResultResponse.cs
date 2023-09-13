namespace AkijBashirGroup.Models
{
    public class ResultResponse
    {
        public bool isSuccess { get; set; }
        public string? msg { get; set; }
        public dynamic? data { get; set; }
    }
}
