using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
namespace Vidly.ViewModals
    
{
    public class RandomMovieViewModal
    {
        public Movie Movie { set; get; }
        public List<Customer> Customers { set; get; }

    }
}