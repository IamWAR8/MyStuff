namespace PizzaStoreDB.Data
{
    public partial class PizzaStoreContext : DbContext
    {
        public PizzaStoreContext()
        {
        }

        public PizzaStoreContext(DbContextOptions<PizzaStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<PizzaInventory> PizzaInventory { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:ramirez-1234.database.windows.net,1433;Initial Catalog=PizzaStore;Persist Security Info=False;User ID=IamWAR;Password=Rapture1959;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.IdLocation);

                entity.Property(e => e.IdLocation).HasColumnName("idLocation");

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.Property(e => e.IdOrder).HasColumnName("idOrder");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.LocationIdLocation).HasColumnName("Location_IdLocation");

                entity.Property(e => e.LocationUser)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PizzaInventory>(entity =>
            {
                entity.HasKey(e => e.Pizzas);

                entity.Property(e => e.Pizzas)
                    .HasMaxLength(30)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.HasIndex(e => e.LocationIdLocation)
                    .HasName("fk_User_Location_idx");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.LocationIdLocation).HasColumnName("Location_idLocation");

                entity.HasOne(d => d.LocationIdLocationNavigation)
                    .WithMany(p => p.UserInfo)
                    .HasForeignKey(d => d.LocationIdLocation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_User_Location");
            });
        }
    }
}
