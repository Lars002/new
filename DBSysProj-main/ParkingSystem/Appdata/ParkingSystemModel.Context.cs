﻿

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ParkingSystem.Appdata
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class ParkingSystemEntities : DbContext
{
    public ParkingSystemEntities()
        : base("name=ParkingSystemEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public DbSet<Reservation> Reservation { get; set; }

    public DbSet<Role> Role { get; set; }

    public DbSet<SlotTable> SlotTable { get; set; }

    public DbSet<Users> Users { get; set; }

    public DbSet<Vehicle> Vehicle { get; set; }

    public DbSet<vw_Slots> vw_Slots { get; set; }

    public DbSet<slotItems> slotItems { get; set; }

}

}

