using LastTry.Domain.Models;
using LastTry.Domain.Repositories;
using LastTry.Persistence.Contexts;
using LastTry.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;


namespace LastTry.Resources
{
    public class CategoryResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
	


}