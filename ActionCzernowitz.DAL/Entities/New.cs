using ActionCzernowitz.DAL.Interfaces;

namespace ActionCzernowitz.DAL.Entities
{
    public class New : IEntity<Guid>
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public string ImagePath { get; set; }
    }
}
