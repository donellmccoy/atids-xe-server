using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheFund.AtidsXe.Data.Entities
{
    [Table("FILE_REFERENCE_NOTES")]
    public partial class FileReferenceNotes
    {
        [Column("FILE_REFERENCE_NOTES_ID")]
        public int FileReferenceNotesId { get; set; }
        [Column("FILE_REFERENCE_ID")]
        public int FileReferenceId { get; set; }
        [Required]
        [Column("USER_ID")]
        [StringLength(30)]
        public string UserId { get; set; }
        [Column("TIME_STAMP", TypeName = "datetime")]
        public DateTime TimeStamp { get; set; }
        [Required]
        [Column("MESSAGE")]
        [StringLength(1024)]
        public string Message { get; set; }

        public FileReference FileReference { get; set; }
    }
}