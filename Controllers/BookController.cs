using Microsoft.AspNetCore.Mvc;
using DeMau.Models;
using DeMau.Data;
using Microsoft.AspNetCore.Authorization;

namespace DeMau.Controllers;

public class BookController : Controller
{
    private ApplicationDbContext db;
    public BookController(ApplicationDbContext dbContext)
    {
        db = dbContext;
    }
    public IActionResult Index()
    {
        var books = db.Books.ToList();
        return View(books);
    }
    [Authorize]
    public IActionResult Detail(int id)
    {
        var book = db.Books.FirstOrDefault(b => b.Id == id);
        return View(book);
    }
}