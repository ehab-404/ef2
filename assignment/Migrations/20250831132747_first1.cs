using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment.Migrations
{
    /// <inheritdoc />
    public partial class first1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst");

            migrationBuilder.RenameColumn(
                name: "Ins_ID",
                table: "Departments",
                newName: "ManagerID");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Stud_Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Stud_Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TopicID",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Course_Inst",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "instID",
                table: "Course_Inst",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course",
                columns: new[] { "Course_ID", "stud_ID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst",
                columns: new[] { "Course_ID", "inst_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentID",
                table: "Students",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Course_CourseID",
                table: "Stud_Course",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Course_StudentID",
                table: "Stud_Course",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerID",
                table: "Departments",
                column: "ManagerID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopicID",
                table: "Courses",
                column: "TopicID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Inst_CourseID",
                table: "Course_Inst",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Inst_instID",
                table: "Course_Inst",
                column: "instID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Courses_CourseID",
                table: "Course_Inst",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Instructors_instID",
                table: "Course_Inst",
                column: "instID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_TopicID",
                table: "Courses",
                column: "TopicID",
                principalTable: "Topics",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_ManagerID",
                table: "Departments",
                column: "ManagerID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Courses_CourseID",
                table: "Stud_Course",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Students_StudentID",
                table: "Stud_Course",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentID",
                table: "Students",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Courses_CourseID",
                table: "Course_Inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Instructors_instID",
                table: "Course_Inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_TopicID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_ManagerID",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Courses_CourseID",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Students_StudentID",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepartmentID",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Course_CourseID",
                table: "Stud_Course");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Course_StudentID",
                table: "Stud_Course");

            migrationBuilder.DropIndex(
                name: "IX_Departments_ManagerID",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TopicID",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst");

            migrationBuilder.DropIndex(
                name: "IX_Course_Inst_CourseID",
                table: "Course_Inst");

            migrationBuilder.DropIndex(
                name: "IX_Course_Inst_instID",
                table: "Course_Inst");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Stud_Course");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Stud_Course");

            migrationBuilder.DropColumn(
                name: "TopicID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Course_Inst");

            migrationBuilder.DropColumn(
                name: "instID",
                table: "Course_Inst");

            migrationBuilder.RenameColumn(
                name: "ManagerID",
                table: "Departments",
                newName: "Ins_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course",
                columns: new[] { "stud_ID", "Course_ID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst",
                columns: new[] { "inst_ID", "Course_ID" });
        }
    }
}
