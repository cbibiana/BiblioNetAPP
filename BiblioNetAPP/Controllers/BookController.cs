﻿
using BiblioNetAPP.Models;
using BiblioNetAPP.Services;
using Microsoft.AspNetCore.Mvc;

namespace BiblioNetAPP.Controllers
{
    public class BookController : Controller
    {
        private readonly IRepositorieBook repositorieBook;

        public BookController(IRepositorieBook repositorieBook)
        {
            this.repositorieBook = repositorieBook;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }
            return View();

            book.Id = 1;
            book.Price = 1000;
            repositorieBook.Create(book);

            return View();

        }
    }
}
