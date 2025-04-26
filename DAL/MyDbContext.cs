using DAl;
using System.Data.Entity;

namespace DAL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=Quanlybida_db") { }

        public DbSet<TaiKhoan> TaiKhoans { get; set; }
    }
}
