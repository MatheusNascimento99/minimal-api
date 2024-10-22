using Microsoft.EntityFrameworkCore;
public class DbContexto : DbContext
{
    private readonly IConfiguration _conficurationsAppSettings;
    public DbContexto(IConfiguration conficurationsAppSettings)
    {
        _conficurationsAppSettings = conficurationsAppSettings;
    }
    public DbSet<Administrador> Administradores {get; set;} = default!;
    public DbSet<Veiculo> Veiculos {get; set;} = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrador>().HasData(
            new Administrador{
                Id = 1,
                Email = "administrador@teste.com",
                Senha = "123456",
                Perfil = "Adm",
            }
        );
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            var stringConexao = _conficurationsAppSettings.GetConnectionString("MySql")?.ToString();
            if(!string.IsNullOrEmpty(stringConexao))
            {
                optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
            }
        }
    }
}