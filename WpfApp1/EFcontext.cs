using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    [DbConfigurationType(typeof(MySql.Data.EntityFramework.MySqlEFConfiguration))]
    public class EFcontext : DbContext
    {
        public DbSet<tables.user> Users { get; set; }
        public EFcontext() : base("server=localhost; port=3306; user=root; password=FuckingAnime_228; database=1.5")
        {
            System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Database.CreateIfNotExists();
        }
    }
}
