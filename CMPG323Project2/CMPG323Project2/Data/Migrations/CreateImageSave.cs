using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMPG323Project2.Data.Migrations;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Diagnostics.CodeAnalysis;

namespace CMPG323Project2.Data.Migrations
{
    public partial class CreateImageSave : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "images",
                columns: table => new
                {
                    Images_ID = table.Column<int>(type: "int", nullable: false),
                    Images_Name = table.Column<string>(type: "varbinary(max)", nullable: true),
                    Images_Path = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images_ID", x => x.Images_ID);
                });
        }
    }
}
