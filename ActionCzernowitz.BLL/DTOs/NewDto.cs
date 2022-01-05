namespace ActionCzernowitz.BLL.DTOs
{
    public class NewDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public string ImagePath { get; set; }
    }
}
