using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Books;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class BooksController : BaseApiController
    {
        public readonly IMediator _mediator;
        public BooksController(IMediator mediator)
        {
         _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetBooks(){
            return await _mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(Guid id){
            return Ok();
        }
    }
}