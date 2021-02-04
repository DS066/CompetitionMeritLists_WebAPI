using Microsoft.EntityFrameworkCore.Migrations;

namespace CompetitionMeritLists_WebAPI.Migrations
{
    public partial class Student_obj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Student_age = table.Column<int>(type: "int", nullable: false),
                    School_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marks_Obtained = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
