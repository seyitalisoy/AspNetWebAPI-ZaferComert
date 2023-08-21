using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EfCore.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { Id = 1, Title = "Puslu kitalar atlasi", Price = 90 },
                new Book { Id = 2, Title = "Galiz Kahraman", Price = 85 },
                new Book { Id = 3, Title = "Sultanın Casusları", Price = 94 }
                );
        }
    }
}
