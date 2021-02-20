using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain{set;get;}
        public string PublicId { get; set; }
        public AppUser App{ get;set;}
        public int AppUserId {set;get;}
    }
}