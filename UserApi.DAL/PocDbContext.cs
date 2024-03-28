


namespace UserApi.DAL;

public class PocDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public PocDbContext(DbContextOptions option) : base(option) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Config entities

        modelBuilder.Entity<User>(entity =>
        {
            //  configuration d'une propriété name
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200);

            // configuratio  clé primaire
            entity.HasKey(e => e.UserID);

            // configuration table

            entity.ToTable("Users");
        });

        base.OnModelCreating(modelBuilder);
    }
}