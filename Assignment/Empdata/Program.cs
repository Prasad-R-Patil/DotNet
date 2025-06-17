using System;
using System.Collections.Generic; 

Console.Write("Enter Employee No => ");
int empno = int.Parse(Console.ReadLine());

Console.Write("Enter Employee Dept No => ");
int dept = int.Parse(Console.ReadLine());

Console.Write("Enter Designation Code => ");
char ch = char.Parse(Console.ReadLine());

Dictionary<int, string> set = new Dictionary<int, string>
{
    { 10, "Purchase" },
    { 20, "Sales" },
    { 30, "Production" },
    { 40, "Marketing" },
    { 50, "Accounts" }
};

Dictionary<char, string> set2 = new Dictionary<char, string>
{
    { 'M', "Manager" },
    { 'S', "Supervisor" },
    { 'A', "Analyst" },
    { 's', "Sales Person" },
    { 'a', "Accountant" }
};

string department = set.ContainsKey(dept) ? set[dept] : "Unknown Department";
string designation = set2.ContainsKey(ch) ? set2[ch] : "Unknown Designation";

Console.WriteLine($"Employee No {empno} Department {department} Designation {designation}");
