namespace Tally.Core.Models.DataTransferObjects
{
    public class ContainerDto : BaseDto
    {
        public int RoomId { get; set; }
        public string ContainerType { get; set; } = string.Empty;
        public bool IsRefrigerated { get; set; }
    }
}
