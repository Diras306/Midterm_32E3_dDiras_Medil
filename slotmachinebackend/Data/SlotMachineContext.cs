using Microsoft.EntityFrameworkCore;
using SlotMachineBackend.Models;

public class SlotMachineContext : DbContext
{
    public SlotMachineContext(DbContextOptions<SlotMachineContext> options) : base(options) { }

    public DbSet<Player> Players { get; set; }
    public DbSet<GameResult> GameResults { get; set; }
}