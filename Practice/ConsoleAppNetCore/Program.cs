// See https://aka.ms/new-console-template for more information
using EFDataAccess.Context;
using EFDataAccess.Models;

Console.WriteLine("Hello, World!");

InitialData();

Console.ReadKey();



void InitialData()
{
    var context = new PracticeDataContext();
    var author = new Author
    {
        AuthorName = "First Author"
    };

    context.Authors.Add(author);
    context.SaveChanges();
}