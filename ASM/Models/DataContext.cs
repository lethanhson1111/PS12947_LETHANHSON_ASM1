﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {

        }
        public DbSet<MonAn> MonAns { get; set; }
        public DbSet<Nguoidung> Nguoidungs { get; set; }
        public DbSet<Donhang> Donhangs { get; set; }
        public DbSet<Khachhang> Khachhangs { get; set; }
        public DbSet<DonhangChitiet> DonhangChitiets { get; set; }
    }
}
