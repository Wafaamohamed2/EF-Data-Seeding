﻿

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEF
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EFCore; Integrated Security = True");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
       

    }


   

    public class Post
    {
        public int PostId { get; set; }
        public int BlogId { get; set; }

        public string Title { get; set; }   

        public string Content { get; set; }
        public Blog Blog { get; set; }



    }
   
    public class Blog 
    {
        public int BlogId { get; set; }

        public string Url { get; set; }

        public List<Post> Posts { get; set; }   

    }

    
}
