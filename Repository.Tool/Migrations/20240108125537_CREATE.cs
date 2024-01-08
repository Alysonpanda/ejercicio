using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Tool.Migrations
{
    /// <inheritdoc />
    public partial class CREATE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Function",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "主键标识ID"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "名称"),
                    Sign = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "标记"),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "备注"),
                    ParentId = table.Column<long>(type: "bigint", nullable: true, comment: "父级信息"),
                    Type = table.Column<int>(type: "int", nullable: false, comment: "类型"),
                    CreateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, comment: "创建时间"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, comment: "是否删除"),
                    DeleteTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "删除时间"),
                    RowVersion = table.Column<long>(type: "bigint", rowVersion: true, nullable: false, comment: "行版本标记")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Function", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Function_Function_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Function",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "系统功能配置表");

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "主键标识ID"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "角色名称"),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "备注信息"),
                    CreateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, comment: "创建时间"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, comment: "是否删除"),
                    DeleteTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "删除时间"),
                    RowVersion = table.Column<long>(type: "bigint", rowVersion: true, nullable: false, comment: "行版本标记")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                },
                comment: "角色信息表");

            migrationBuilder.CreateTable(
                name: "UserToken",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "主键标识ID"),
                    UserId = table.Column<long>(type: "bigint", nullable: false, comment: "用户ID"),
                    LastId = table.Column<long>(type: "bigint", nullable: true, comment: "上一次有效的 tokenid"),
                    CreateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, comment: "创建时间"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, comment: "是否删除"),
                    DeleteTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "删除时间"),
                    RowVersion = table.Column<long>(type: "bigint", rowVersion: true, nullable: false, comment: "行版本标记")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserToken_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "用户Token记录表");

            migrationBuilder.CreateTable(
                name: "FunctionRoute",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "主键标识ID"),
                    FunctionId = table.Column<long>(type: "bigint", nullable: true, comment: "功能信息"),
                    Module = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "模块"),
                    Route = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "路由"),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "备注"),
                    CreateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, comment: "创建时间"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, comment: "是否删除"),
                    DeleteTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, comment: "删除时间"),
                    RowVersion = table.Column<long>(type: "bigint", rowVersion: true, nullable: false, comment: "行版本标记")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunctionRoute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FunctionRoute_Function_FunctionId",
                        column: x => x.FunctionId,
                        principalTable: "Function",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "功能模块对应路由记录表");

            migrationBuilder.CreateTable(
                name: "FunctionAuthorize",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "主键标识ID"),
                    FunctionId = table.Column<long>(type: "bigint", nullable: false, comment: "功能ID"),
                    RoleId = table.Column<long>(type: "bigint", nullable: true, comment: "角色ID"),
                    UserId = table.Column<long>(type: "bigint", nullable: true, comment: "用户信息"),
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
                    table.PrimaryKey("PK_FunctionAuthorize", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FunctionAuthorize_Function_FunctionId",
                        column: x => x.FunctionId,
                        principalTable: "Function",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FunctionAuthorize_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FunctionAuthorize_User_CreateUserId",
                        column: x => x.CreateUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FunctionAuthorize_User_DeleteUserId",
                        column: x => x.DeleteUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FunctionAuthorize_User_UpdateUserId",
                        column: x => x.UpdateUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FunctionAuthorize_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "功能授权配置表");

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, comment: "主键标识ID"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false, comment: "角色信息"),
                    UserId = table.Column<long>(type: "bigint", nullable: false, comment: "用户信息"),
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
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRole_User_CreateUserId",
                        column: x => x.CreateUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRole_User_DeleteUserId",
                        column: x => x.DeleteUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UpdateUserId",
                        column: x => x.UpdateUserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "TUserRole");

            migrationBuilder.CreateIndex(
                name: "IX_Function_CreateTime",
                table: "Function",
                column: "CreateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Function_DeleteTime",
                table: "Function",
                column: "DeleteTime");

            migrationBuilder.CreateIndex(
                name: "IX_Function_ParentId",
                table: "Function",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Function_Sign",
                table: "Function",
                column: "Sign");

            migrationBuilder.CreateIndex(
                name: "IX_FunctionAuthorize_CreateTime",
                table: "FunctionAuthorize",
                column: "CreateTime");

            migrationBuilder.CreateIndex(
                name: "IX_FunctionAuthorize_CreateUserId",
                table: "FunctionAuthorize",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FunctionAuthorize_DeleteTime",
                table: "FunctionAuthorize",
                column: "DeleteTime");

            migrationBuilder.CreateIndex(
                name: "IX_FunctionAuthorize_DeleteUserId",
                table: "FunctionAuthorize",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FunctionAuthorize_FunctionId",
                table: "FunctionAuthorize",
                column: "FunctionId");

            migrationBuilder.CreateIndex(
                name: "IX_FunctionAuthorize_RoleId",
                table: "FunctionAuthorize",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_FunctionAuthorize_UpdateTime",
                table: "FunctionAuthorize",
                column: "UpdateTime");

            migrationBuilder.CreateIndex(
                name: "IX_FunctionAuthorize_UpdateUserId",
                table: "FunctionAuthorize",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FunctionAuthorize_UserId",
                table: "FunctionAuthorize",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FunctionRoute_CreateTime",
                table: "FunctionRoute",
                column: "CreateTime");

            migrationBuilder.CreateIndex(
                name: "IX_FunctionRoute_DeleteTime",
                table: "FunctionRoute",
                column: "DeleteTime");

            migrationBuilder.CreateIndex(
                name: "IX_FunctionRoute_FunctionId",
                table: "FunctionRoute",
                column: "FunctionId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_CreateTime",
                table: "Role",
                column: "CreateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Role_DeleteTime",
                table: "Role",
                column: "DeleteTime");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_CreateTime",
                table: "UserRole",
                column: "CreateTime");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_CreateUserId",
                table: "UserRole",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_DeleteTime",
                table: "UserRole",
                column: "DeleteTime");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_DeleteUserId",
                table: "UserRole",
                column: "DeleteUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UpdateTime",
                table: "UserRole",
                column: "UpdateTime");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UpdateUserId",
                table: "UserRole",
                column: "UpdateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserToken_CreateTime",
                table: "UserToken",
                column: "CreateTime");

            migrationBuilder.CreateIndex(
                name: "IX_UserToken_DeleteTime",
                table: "UserToken",
                column: "DeleteTime");

            migrationBuilder.CreateIndex(
                name: "IX_UserToken_UserId",
                table: "UserToken",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FunctionAuthorize");

            migrationBuilder.DropTable(
                name: "FunctionRoute");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "UserToken");

            migrationBuilder.DropTable(
                name: "Function");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
