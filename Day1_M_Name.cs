review1.cs
int d; // elapsed time in days
Correct way:
int elapsedTimeInDays;

review2.cs
var dataFromDb = db.GetFromService().ToList(); // Get List of employees 
Correct way:
var dataFromDb = getEmployeesList.GetFromService().ToList();

review3.cs
int iCounter;
string strFullName;
DateTime dModifiedDate;
Correct way:
int counter;
string fullName;
DateTime modifiedDate;

review4.cs
public bool IsShopOpen(string pDay, int pAmount)
{
    // some logic
}
Correct way:
public bool IsShopOpen(string day, int amount)
{
    // some logic
}

review5.cs
const int DAYS_IN_WEEK = 7;
const int daysInMonth = 30;

var songs = new List<string> { 'Back In Black', 'Stairway to Heaven', 'Hey Jude' };
var Artists = new List<string> { 'ACDC', 'Led Zeppelin', 'The Beatles' };

bool EraseDatabase() {}
bool Restore_database() {}

class animal {}
class Alpaca {}

Correct way:
const int daysInWeek = 7;
const int daysInMonth = 30;

var songs = new List<string> { 'Back In Black', 'Stairway to Heaven', 'Hey Jude' };
var artists = new List<string> { 'ACDC', 'Led Zeppelin', 'The Beatles' };

bool EraseDatabase() {}
bool RestoreDatabase() {}

class Animal {}
class Alpaca {}

review6.cs
public class Employee
{
    public Datetime sWorkDate { get; set; } // get set Start Working Date
    public Datetime modTime { get; set; } // get set Modification Time
}

Correct way:
public class Employee
{
    public Datetime WorkDate { get; set; } // get set Start Working Date
    public Datetime ModTime { get; set; } // get set Modification Time
}

review7.cs
var employeephone;

public double CalculateSalary(int workingdays, int workinghours)
{
    // some logic
}

Correct way:
var employeePhone;

public double CalculateSalary(int workingDays, int workingHours)
{
    // some logic
}



