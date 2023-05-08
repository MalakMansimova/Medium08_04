using Medium08_05.DAL;
using Medium08_05.Models;

MyDbContext db = new MyDbContext();
Author author1 = new Author();
author1.FullName = "Malak Mansimova";
db.Authors.Add(author1);

Author author = db.Authors.Find(1);
Console.WriteLine(author.FullName);