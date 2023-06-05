using Microsoft.EntityFrameworkCore;

public class StudentContext : DbContext
{
    private const string V1 = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    private const string V = V1;

    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        const string ConnectionString = V;
        DbContextOptionsBuilder dbContextOptionsBuilder = optionsBuilder.UseSqlServer(ConnectionString);
    }
}
