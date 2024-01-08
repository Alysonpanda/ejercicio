﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Database;

#nullable disable

namespace Repository.Tool.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240108122103_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Repository.Database.TProduct", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasComment("主键标识ID");

                    b.Property<int>("Count")
                        .HasColumnType("int")
                        .HasComment("數量");

                    b.Property<DateTimeOffset>("CreateTime")
                        .HasColumnType("datetimeoffset")
                        .HasComment("创建时间");

                    b.Property<long?>("CreateUserId")
                        .HasColumnType("bigint")
                        .HasComment("创建人ID");

                    b.Property<DateTimeOffset?>("DeleteTime")
                        .HasColumnType("datetimeoffset")
                        .HasComment("删除时间");

                    b.Property<long?>("DeleteUserId")
                        .HasColumnType("bigint")
                        .HasComment("删除人ID");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("描述");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit")
                        .HasComment("是否删除");

                    b.Property<bool>("IsShow")
                        .HasColumnType("bit")
                        .HasComment("是否上架");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("品名");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasComment("價格");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("備註");

                    b.Property<long>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bigint")
                        .HasComment("行版本标记");

                    b.Property<DateTimeOffset?>("UpdateTime")
                        .HasColumnType("datetimeoffset")
                        .HasComment("更新时间");

                    b.Property<long?>("UpdateUserId")
                        .HasColumnType("bigint")
                        .HasComment("编辑人ID");

                    b.HasKey("Id");

                    b.HasIndex("CreateTime");

                    b.HasIndex("CreateUserId");

                    b.HasIndex("DeleteTime");

                    b.HasIndex("DeleteUserId");

                    b.HasIndex("UpdateTime");

                    b.HasIndex("UpdateUserId");

                    b.ToTable("Product", null, t =>
                        {
                            t.HasComment("產品表");
                        });
                });

            modelBuilder.Entity("Repository.Database.TUser", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasComment("主键标识ID");

                    b.Property<DateTimeOffset>("CreateTime")
                        .HasColumnType("datetimeoffset")
                        .HasComment("创建时间");

                    b.Property<DateTimeOffset?>("DeleteTime")
                        .HasColumnType("datetimeoffset")
                        .HasComment("删除时间");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("信箱");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit")
                        .HasComment("是否删除");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("使用者姓名");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("密碼");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("電話");

                    b.Property<long>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bigint")
                        .HasComment("行版本标记");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("用户名");

                    b.HasKey("Id");

                    b.HasIndex("CreateTime");

                    b.HasIndex("DeleteTime");

                    b.ToTable("User", null, t =>
                        {
                            t.HasComment("用戶表");
                        });
                });

            modelBuilder.Entity("Repository.Database.TProduct", b =>
                {
                    b.HasOne("Repository.Database.TUser", "CreateUser")
                        .WithMany()
                        .HasForeignKey("CreateUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Repository.Database.TUser", "DeleteUser")
                        .WithMany()
                        .HasForeignKey("DeleteUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Repository.Database.TUser", "UpdateUser")
                        .WithMany()
                        .HasForeignKey("UpdateUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreateUser");

                    b.Navigation("DeleteUser");

                    b.Navigation("UpdateUser");
                });
#pragma warning restore 612, 618
        }
    }
}