using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreApp.Models
{
    public class EfBookstoreRespository : IBookstoreRepository
    {
        private BookstoreContext context { get; set; }

        public EfBookstoreRespository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;
    }
}
