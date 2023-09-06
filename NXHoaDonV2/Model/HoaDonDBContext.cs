using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NXHoaDonV2.Model
{
    internal class HoaDonDBContext : DbContext
    {
        public HoaDonDBContext() : base("name=ConnectionStringName") { }
        
        public DbSet<HoaDonModel> HoaDonModels { get; set; }
    }
}
