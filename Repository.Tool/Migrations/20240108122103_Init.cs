using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Tool.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "主键标识ID"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "用户名"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "使用者姓名"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "密碼"),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "電話"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "信箱"),
                    CreateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, comment: "创建时间"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, comment: "是否删除"),
                    DeleteTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "删除时间"),
                    RowVersion = table.Column<long>(type: "bigint", rowVersion: true, nullable: false, comment: "行版本标记")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                },
                comment: "用戶表");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "主键标识ID"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "品名"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "描述"),
                    Count = table.Column<int>(type: "int", nullable: false, comment: "數量"),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false, comment: "價格"),
                    IsShow = table.Column<bool>(type: "bit", nullable: false, comment: "是否上架"),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "備註"),
                    CreateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, comment: "创建时间"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, comment: "是否删除"),
                    DeleteTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "删除时间"),
                    RowVersion = table.Column<long>(type: "bigint", rowVersion: true, nullable: false, comment: "行版本标记"),
                    UpdateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "更新时间"),
                    CreateUserId = table.Column<long>(type: "bigint", nullable: true, comment: "创建人ID"),
                    UpdateUserId = table.Column<long>(type: "bigint", nullable: true, comment: "编辑人ID"),
                    DeleteUserId = table.Column<long>(type: "bigint", nullable: true, comment: "删除人ID")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_User_CreateUserId",
                        column: x => x.CreateUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_User_DeleteUserId",
                        column: x => x.DeleteUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_User_UpdateUserId",
                        column: x => x.UpdateUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "產品表");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CreateTime",
                table: "Product",
                column: "CreateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CreateUserId",
                table: "Product",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_DeleteTime",
                table: "Product",
                column: "DeleteTime");

            migrationBuilder.CreateIndex(
                name: "IX_Product_DeleteUserId",
                table: "Product",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UpdateTime",
                table: "Product",
                column: "UpdateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UpdateUserId",
                table: "Product",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CreateTime",
                table: "User",
                column: "CreateTime");

            migrationBuilder.CreateIndex(
                name: "IX_User_DeleteTime",
                table: "User",
                column: "DeleteTime");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
