// MIS3033 002
// September 18 2023
// Abigail Pidgeon 113515288

using a;

Console.WriteLine("Create grades database");

StudentGradeDB db;
db = new StudentGradeDB();//create a database connection

double r1 = db.StugradesTbl.Average(s => s.grade);
Console.WriteLine( r1);

double r2 = db.StugradesTbl.Max(s => s.grade);
Console.WriteLine(r2);

double r3 = db.StugradesTbl.Min(s => s.grade);
Console.WriteLine(r3);