using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_project_crud_fileupload.Models
{
    public class Book:BaseEntity
    {
        public string Name {  get; set; }
        
        public string Description { get; set; }
        public string Tax { get; set; }
        public string Code { get; set; }
        public bool IsAvailable { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public double DiscountPercent { get; set; }
        public int AuthorId {  get; set; }
        public Author? Author { get; set; }
        public int GenreId {  get; set; }
        public Genre? Genre { get; set; }

        

        public List<BookTag>? BookTags { get; set; }  //ortaq table listi gonderilir
        [NotMapped]
        public List<int>TagIds { get; set; }
    }
}
