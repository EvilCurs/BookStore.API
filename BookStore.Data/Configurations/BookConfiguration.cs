using BookStore.Core.Models;
using BookStore.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<BookEntity>
    {
        public void Configure(EntityTypeBuilder<BookEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b => b.Title)
                .HasMaxLength(Book.MAX_TITLE_SIZE)
                .IsRequired();

            builder.Property(b => b.Description).IsRequired();

            builder.Property(b => b.Author).IsRequired();

            builder.Property(b => b.Price).IsRequired();
        }
    }
}
