namespace SimplVMService.Models
{
    public class CapturedImageDataModel
    {
        public Guid Id { get; set; }
        public string CameraName { get; set; }
        public byte[] ImageData { get; set; }
        public DateTime CapturedAt { get; set; }
        public string CameraType { get; set; }
    }
}
