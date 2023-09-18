// MIS3033 002
// September 18 2023
// Abigail Pidgeon 113515288

using a;
using System.Text.Json;

Console.WriteLine("Create grades database");

StudentGradeDB db; // complex
db = new StudentGradeDB();//create database connection

var opt = new JsonSerializerOptions();
opt.WriteIndented = true;

string filepath = "data.json";
string jsonstr;

bool checkgrade(StudentGrade x)
{
    if (x.grade >= 80 && x.grade <= 90)
    {
        return true;
    }
    else 
    { 
        return false; 
    }    
    
} 

//lamda expression
{
    //var r = db.StugradesTbl;//collection table, ctrl d
    // var r = db.StugradesTbl.Where(x=>x.Age==20);//collection table 
    //  var r = db.StugradesTbl.Where(checkgrade);//collection table 

    // where() in list, collection, table, list
    // where() work on collection,list,table
    //var r = db.StugradesTbl.Where((s) => s.grade >= 80 && s.grade <= 90);
    // var r = db.StugradesTbl.Where((s) => s.grade >= 80 && s.grade <= 90 && s.Age == 20);
    //var r = db.StugradesTbl.Where((s) => s.grade >= 80 && s.grade <= 90).Where(S => S.Age == 18);
    //var r = db.StugradesTbl.Where(x =>x.grade>90).Where(x=>x.grade<95);
    //var r = db.StugradesTbl.Where(x =>x.grade>90).FirstOrDefault();
    var r = db.StugradesTbl.FirstOrDefault();

    r.Age = 100;

    db.StugradesTbl.Remove(r);

//db.SaveChanges();
//    {
//        if (s.grade >= 80 &&  s.grade <= 90)
//        {
//            return true;
//        } 
//        else
//        {
//            return false;
//        }
//    });//collection table 

    jsonstr = JsonSerializer.Serialize(r,opt);
    File.WriteAllText(filepath,jsonstr);

}

//complex
{
    StudentGrade s1;
    StudentGrade s2;

    s1 = new StudentGrade();
    s2 = new StudentGrade();
    s1 = s2;// 
}


//StudentGradeDB db;
//db = new StudentGradeDB();//create a database connection

//double r1 = db.StugradesTbl.Average(s => s.grade);
//Console.WriteLine( r1);

//double r2 = db.StugradesTbl.Max(s => s.grade);
//Console.WriteLine(r2);

//double r3 = db.StugradesTbl.Min(s => s.grade);
//Console.WriteLine(r3);