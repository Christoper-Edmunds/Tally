namespace Tally.Core.Models.DataTransferObjects
{
    public class BaseDto
    {
        /// <summary>
        /// Gets or sets the unique identifier for the DTO.
        /// </summary>
        public required int Id { get; set; }
        /// <summary>
        /// Gets or sets the name of the DTO.
        /// </summary>
        public required string Name { get; set; }
        /// <summary>
        /// Gets or sets the description of the DTO.
        /// </summary>
        public required string Description { get; set; }
        /// <summary>
        /// Gets or sets the creation date of the DTO.
        /// </summary>
        /// 
        public required DateTime CreatedDate { get; set; }
        public required bool IsActive { get; set; }
    }
}
