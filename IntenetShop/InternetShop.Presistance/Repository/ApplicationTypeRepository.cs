﻿using IntenetShop.Domain.Entities;
using InternetShop.Application.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Presistance.Repository
{
    public class ApplicationTypeRepository : GenericRepository<ApplicationType>, IApplicationTypeRepository
    {
        public ApplicationTypeRepository(AppDbContext context) : base(context)
        {
        }
    }
}
