
namespace Shop.DAL.Models
{
    public class GetCategoryModel
    {
        public int Categoryid { get; set; }
        public string? Categoryname { get; set; }
        public string? Description { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreationUser { get; set; }

    }
}
