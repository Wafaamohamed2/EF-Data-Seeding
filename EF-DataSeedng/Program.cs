using NewEF;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        SeedData();
    }

    public static void SeedData()
    {

        using (var context = new ApplicationDbContext())
        {
            context.Database.EnsureCreated();

            var blog = context.Blogs.FirstOrDefault(b => b.Url == "www.google.com");

            if (blog == null) { context.Blogs.Add(new Blog { Url = " www.google.com" }); }

            context.SaveChanges();
        }

    }
}