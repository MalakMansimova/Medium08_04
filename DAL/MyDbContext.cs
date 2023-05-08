using Medium08_05.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium08_05.DAL
{
    internal class MyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=CA-R215-PC10\SQLEXPRESS;Database=MediumDb;Trusted_Connection= True");
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>(Model =>
            {

                Model.HasKey(prop => prop.Id);
                Model.Property(prop => prop.Title).HasMaxLength(20).IsRequired(true);
                Model.Property(prop => prop.AuthorId).IsRequired(true); //not null
            });

            {
                modelBuilder.Entity<Topic>(Model =>
                {   
                    Model.HasKey(prop => prop.Id);
                    Model.Property(prop => prop.Title).HasMaxLength(30).IsRequired(true);
                    Model.Property(prop => prop.ParentTopicId).IsRequired(false); //null
                });

            }
            base.OnModelCreating(modelBuilder);
        }
       
        

    }
}
