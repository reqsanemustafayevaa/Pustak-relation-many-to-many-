namespace MVC_project_crud_fileupload.Models
{
    public class BookTag:BaseEntity  //3 cu table.
    {
        public int BookId {  get; set; }
        public int TagId {  get; set; }
        public Book Book { get; set; }
        public Tag Tag { get; set; }
    }
}
