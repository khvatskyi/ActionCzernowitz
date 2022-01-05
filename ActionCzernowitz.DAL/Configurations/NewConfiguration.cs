using ActionCzernowitz.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ActionCzernowitz.DAL.Configurations
{
    internal class NewConfiguration : IEntityTypeConfiguration<New>
    {
        public void Configure(EntityTypeBuilder<New> builder)
        {
            builder.HasData(new[]
            {
                new New
                {
                    Id =  Guid.NewGuid(),
                    Title ="Прем‘єра фільму «Хто ми? Психоаналіз українців»",
                    Description = "10 грудня о 19:00 у культурно-мистецькому центрі імені Івана Миколайчука відбудеться прем‘єра фільму «Хто ми? Психоаналіз українців»...",
                    Date = new DateTime(2021,12,4),
                    ImagePath = "../../../../assets/images/news1.png"
                },
                new New
                {
                    Id =  Guid.NewGuid(),
                    Title ="Прем‘єра фільму «Хто ми? Психоаналіз українців»",
                    Description = "10 грудня о 19:00 у культурно-мистецькому центрі імені Івана Миколайчука відбудеться прем‘єра фільму «Хто ми? Психоаналіз українців»...",
                    Date = new DateTime(2021,12,4),
                    ImagePath = "../../../../assets/images/news2.png"
                },
                new New
                {
                    Id =  Guid.NewGuid(),
                    Title ="Прем‘єра фільму «Хто ми? Психоаналіз українців»",
                    Description = "10 грудня о 19:00 у культурно-мистецькому центрі імені Івана Миколайчука відбудеться прем‘єра фільму «Хто ми? Психоаналіз українців»...",
                    Date = new DateTime(2021,12,4),
                    ImagePath = "../../../../assets/images/news3.png"
                },
            });
        }
    }
}
