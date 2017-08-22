namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAll : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Credits = c.Int(nullable: false),
                        DepartmentsID = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departments", t => t.DepartmentsID, cascadeDelete: true)
                .Index(t => t.DepartmentsID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Budget = c.Double(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        InstructorID = c.Int(nullable: false),
                        RowVersion = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Instructors", t => t.InstructorID, cascadeDelete: true)
                .Index(t => t.InstructorID);
            
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        HireDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.People", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        Age = c.Int(nullable: false),
                        Email = c.String(),
                        Phone = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        UnitOrApartmentNumber = c.Int(nullable: false),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        Password = c.String(),
                        Salt = c.String(),
                        IsLocked = c.Boolean(nullable: false),
                        LastLockedDateTime = c.DateTime(nullable: false),
                        FailedAttempts = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                        Description = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CourseID = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.CourseID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        EnrollmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.People", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.OfficeAssignments",
                c => new
                    {
                        InstructorID = c.Int(nullable: false),
                        Location = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.InstructorID)
                .ForeignKey("dbo.Instructors", t => t.InstructorID)
                .Index(t => t.InstructorID);
            
            CreateTable(
                "dbo.InstructorCourses",
                c => new
                    {
                        Instructor_ID = c.Int(nullable: false),
                        Courses_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Instructor_ID, t.Courses_ID })
                .ForeignKey("dbo.Instructors", t => t.Instructor_ID, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Courses_ID, cascadeDelete: false)
                .Index(t => t.Instructor_ID)
                .Index(t => t.Courses_ID);
            
            CreateTable(
                "dbo.RolesPeoples",
                c => new
                    {
                        Roles_ID = c.Int(nullable: false),
                        People_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Roles_ID, t.People_ID })
                .ForeignKey("dbo.Roles", t => t.Roles_ID, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.People_ID, cascadeDelete: true)
                .Index(t => t.Roles_ID)
                .Index(t => t.People_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OfficeAssignments", "InstructorID", "dbo.Instructors");
            DropForeignKey("dbo.Enrollments", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Students", "ID", "dbo.People");
            DropForeignKey("dbo.Enrollments", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.Courses", "DepartmentsID", "dbo.Departments");
            DropForeignKey("dbo.Departments", "InstructorID", "dbo.Instructors");
            DropForeignKey("dbo.Instructors", "ID", "dbo.People");
            DropForeignKey("dbo.RolesPeoples", "People_ID", "dbo.People");
            DropForeignKey("dbo.RolesPeoples", "Roles_ID", "dbo.Roles");
            DropForeignKey("dbo.InstructorCourses", "Courses_ID", "dbo.Courses");
            DropForeignKey("dbo.InstructorCourses", "Instructor_ID", "dbo.Instructors");
            DropIndex("dbo.RolesPeoples", new[] { "People_ID" });
            DropIndex("dbo.RolesPeoples", new[] { "Roles_ID" });
            DropIndex("dbo.InstructorCourses", new[] { "Courses_ID" });
            DropIndex("dbo.InstructorCourses", new[] { "Instructor_ID" });
            DropIndex("dbo.OfficeAssignments", new[] { "InstructorID" });
            DropIndex("dbo.Students", new[] { "ID" });
            DropIndex("dbo.Enrollments", new[] { "StudentID" });
            DropIndex("dbo.Enrollments", new[] { "CourseID" });
            DropIndex("dbo.Instructors", new[] { "ID" });
            DropIndex("dbo.Departments", new[] { "InstructorID" });
            DropIndex("dbo.Courses", new[] { "DepartmentsID" });
            DropTable("dbo.RolesPeoples");
            DropTable("dbo.InstructorCourses");
            DropTable("dbo.OfficeAssignments");
            DropTable("dbo.Students");
            DropTable("dbo.Enrollments");
            DropTable("dbo.Roles");
            DropTable("dbo.People");
            DropTable("dbo.Instructors");
            DropTable("dbo.Departments");
            DropTable("dbo.Courses");
        }
    }
}
