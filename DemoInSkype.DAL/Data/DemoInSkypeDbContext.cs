using DemoInSkype.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoInSkype.DAL.Data
{
    public class DemoInSkypeDbContext:DbContext
    {
        public DemoInSkypeDbContext(DbContextOptions<DemoInSkypeDbContext> options) :base(options)
        {

        }
        public DbSet<Ecole> ecoles { get; set; }
    }
}
