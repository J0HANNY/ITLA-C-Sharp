
namespace Shop.DAL.Models
{
    public class CategoryCreateUpdateModel
    {
        public int Categoryid { get; set; }
        public string? Categoryname { get; set; }
        public string? Description { get; set; }

        public DateTime CreationDate { get; set; }
        public int CreationUser { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ModifyUser { get; set; }
    }
}