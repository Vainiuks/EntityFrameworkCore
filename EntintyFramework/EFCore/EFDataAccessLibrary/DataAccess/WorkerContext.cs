using EFDataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace EFDataAccessLibrary.DataAccess
{
    public class WorkerContext: DbContext
    {
        public WorkerContext()
        {

        }
        public WorkerContext(DbContextOptions<WorkerContext> options) : base(options) { }

        public DbSet<Worker> Person { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }




    }
}
 