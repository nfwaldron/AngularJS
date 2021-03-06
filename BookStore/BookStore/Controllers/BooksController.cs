﻿using BookStore.Models;
using BookStore.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookStore.Controllers
{
    public class BooksController : ApiController
    {
        private ApplicationDbContext _db = new ApplicationDbContext();


        // GET: api/Books
        public IEnumerable<Book> Get()
        {
            var x = ConstStrings.Common1;

            return _db.Books.ToList();
        }

        // GET: api/Books/5
        public Book Get(int id)
        {
            return _db.Books.Find(id);
        }

        // POST: api/Books
        public HttpResponseMessage Post(Book book)
        {
            if (ModelState.IsValid) {
                if (book.Id == 0)
                {
                    _db.Books.Add(book);
                    _db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.Created, book);
                }
                else
                {
                    // THe reason they do this is because if the entity has an id the 'create' is counted
                    // as an edit
                    var original = _db.Books.Find(book.Id);
                    original.Title = book.Title;
                    original.Author = book.Author;
                    _db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, book);
                }
                
            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
        }

        // PUT: api/Books/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Books/5
        public void Delete(int id)
        {
            var book = _db.Books.Find(id);
            _db.Books.Remove(book);
            _db.SaveChanges();

        }
    }
}
