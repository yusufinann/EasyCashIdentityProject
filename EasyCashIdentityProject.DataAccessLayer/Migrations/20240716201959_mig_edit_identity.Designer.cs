﻿// <auto-generated />
using System;
using EasyCashIdentityProject.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EasyCashIdentityProject.DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240716201959_mig_edit_identity")]
    partial class mig_edit_identity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EasyCashIdentityProject.EntityLayer.Concrete.CustomerAccount", b =>
                {
                    b.Property<int>("CustomerAccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BankBranch")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("CustomerAccountBalance")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("CustomerAccountCurrency")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CustomerAccountNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CustomerAccountID");

                    b.ToTable("CustomerAccounts");
                });

            modelBuilder.Entity("EasyCashIdentityProject.EntityLayer.Concrete.CustomerAccountProcess", b =>
                {
                    b.Property<int>("CustomerAccountProcessID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("ProcessDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ProcessType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CustomerAccountProcessID");

                    b.ToTable("CustomerAccountProceses");
                });
#pragma warning restore 612, 618
        }
    }
}
