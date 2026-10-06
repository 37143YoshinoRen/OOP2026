using Microsoft.EntityFrameworkCore;
using MvcBasicSample.Models;

namespace MvcBasicSample.Data;
public class AppDbContext : DbContext{

    //Program.csで登録した接続設定を受け取る
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) {

    }
    public DbSet<Product> Products => Set<Product>();
}

