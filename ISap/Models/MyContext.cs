using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ISap.Helpers;
namespace ISap.Models
{
    public class MyContext : DB_ISAPContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(String.Format("Server={0};Database=DB_ISAP;User Id={1};Password={2};", Utils.DB_Server, Utils.DB_User, Utils.DB_Pass));
            }
        }
    }
    
}
