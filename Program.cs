using EntityFrameworkTestProject;
using EntityFrameworkTestProject.models;
using Microsoft.EntityFrameworkCore;

var localDb = new LocalDataBase();
var user = localDb.Users.Where(u => u.Login.Equals("admin")).First();
Console.WriteLine(user);

