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
    [Migration("20240108125537_CREATE")]
    partial class CREATE
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Repository.Database.TFunction", b =>
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

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit")
                        .HasComment("是否删除");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("名称");

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint")
                        .HasComment("父级信息");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("备注");

                    b.Property<long>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bigint")
                        .HasComment("行版本标记");

                    b.Property<string>("Sign")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("标记");

                    b.Property<int>("Type")
                        .HasColumnType("int")
                        .HasComment("类型");

                    b.HasKey("Id");

                    b.HasIndex("CreateTime");

                    b.HasIndex("DeleteTime");

                    b.HasIndex("ParentId");

                    b.HasIndex("Sign");

                    b.ToTable("Function", null, t =>
                        {
                            t.HasComment("系统功能配置表");
                        });
                });

            modelBuilder.Entity("Repository.Database.TFunctionAuthorize", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasComment("主键标识ID");

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

                    b.Property<long>("FunctionId")
                        .HasColumnType("bigint")
                        .HasComment("功能ID");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit")
                        .HasComment("是否删除");

                    b.Property<long?>("RoleId")
                        .HasColumnType("bigint")
                        .HasComment("角色ID");

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

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint")
                        .HasComment("用户信息");

                    b.HasKey("Id");

                    b.HasIndex("CreateTime");

                    b.HasIndex("CreateUserId");

                    b.HasIndex("DeleteTime");

                    b.HasIndex("DeleteUserId");

                    b.HasIndex("FunctionId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UpdateTime");

                    b.HasIndex("UpdateUserId");

                    b.HasIndex("UserId");

                    b.ToTable("FunctionAuthorize", null, t =>
                        {
                            t.HasComment("功能授权配置表");
                        });
                });

            modelBuilder.Entity("Repository.Database.TFunctionRoute", b =>
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

                    b.Property<long?>("FunctionId")
                        .HasColumnType("bigint")
                        .HasComment("功能信息");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit")
                        .HasComment("是否删除");

                    b.Property<string>("Module")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("模块");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("备注");

                    b.Property<string>("Route")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("路由");

                    b.Property<long>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bigint")
                        .HasComment("行版本标记");

                    b.HasKey("Id");

                    b.HasIndex("CreateTime");

                    b.HasIndex("DeleteTime");

                    b.HasIndex("FunctionId");

                    b.ToTable("FunctionRoute", null, t =>
                        {
                            t.HasComment("功能模块对应路由记录表");
                        });
                });

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

            modelBuilder.Entity("Repository.Database.TRole", b =>
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

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit")
                        .HasComment("是否删除");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("角色名称");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("备注信息");

                    b.Property<long>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bigint")
                        .HasComment("行版本标记");

                    b.HasKey("Id");

                    b.HasIndex("CreateTime");

                    b.HasIndex("DeleteTime");

                    b.ToTable("Role", null, t =>
                        {
                            t.HasComment("角色信息表");
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

            modelBuilder.Entity("Repository.Database.TUserRole", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasComment("主键标识ID");

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

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit")
                        .HasComment("是否删除");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint")
                        .HasComment("角色信息");

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

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasComment("用户信息");

                    b.HasKey("Id");

                    b.HasIndex("CreateTime");

                    b.HasIndex("CreateUserId");

                    b.HasIndex("DeleteTime");

                    b.HasIndex("DeleteUserId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UpdateTime");

                    b.HasIndex("UpdateUserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole", null, t =>
                        {
                            t.HasComment("TUserRole");
                        });
                });

            modelBuilder.Entity("Repository.Database.TUserToken", b =>
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

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit")
                        .HasComment("是否删除");

                    b.Property<long?>("LastId")
                        .HasColumnType("bigint")
                        .HasComment("上一次有效的 tokenid");

                    b.Property<long>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bigint")
                        .HasComment("行版本标记");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasComment("用户ID");

                    b.HasKey("Id");

                    b.HasIndex("CreateTime");

                    b.HasIndex("DeleteTime");

                    b.HasIndex("UserId");

                    b.ToTable("UserToken", null, t =>
                        {
                            t.HasComment("用户Token记录表");
                        });
                });

            modelBuilder.Entity("Repository.Database.TFunction", b =>
                {
                    b.HasOne("Repository.Database.TFunction", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Repository.Database.TFunctionAuthorize", b =>
                {
                    b.HasOne("Repository.Database.TUser", "CreateUser")
                        .WithMany()
                        .HasForeignKey("CreateUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Repository.Database.TUser", "DeleteUser")
                        .WithMany()
                        .HasForeignKey("DeleteUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Repository.Database.TFunction", "Function")
                        .WithMany()
                        .HasForeignKey("FunctionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Repository.Database.TRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Repository.Database.TUser", "UpdateUser")
                        .WithMany()
                        .HasForeignKey("UpdateUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Repository.Database.TUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreateUser");

                    b.Navigation("DeleteUser");

                    b.Navigation("Function");

                    b.Navigation("Role");

                    b.Navigation("UpdateUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Repository.Database.TFunctionRoute", b =>
                {
                    b.HasOne("Repository.Database.TFunction", "Function")
                        .WithMany("TFunctionRoute")
                        .HasForeignKey("FunctionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Function");
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

            modelBuilder.Entity("Repository.Database.TUserRole", b =>
                {
                    b.HasOne("Repository.Database.TUser", "CreateUser")
                        .WithMany()
                        .HasForeignKey("CreateUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Repository.Database.TUser", "DeleteUser")
                        .WithMany()
                        .HasForeignKey("DeleteUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Repository.Database.TRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Repository.Database.TUser", "UpdateUser")
                        .WithMany()
                        .HasForeignKey("UpdateUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Repository.Database.TUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CreateUser");

                    b.Navigation("DeleteUser");

                    b.Navigation("Role");

                    b.Navigation("UpdateUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Repository.Database.TUserToken", b =>
                {
                    b.HasOne("Repository.Database.TUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Repository.Database.TFunction", b =>
                {
                    b.Navigation("TFunctionRoute");
                });
#pragma warning restore 612, 618
        }
    }
}
