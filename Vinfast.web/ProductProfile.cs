﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Vinfast.models;
using Vinfast.web.Pages;

namespace Vinfast.web
{
    public class ProductProfile: Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, EditProductModel>();
            CreateMap<EditProductModel,Product>();

        }
    }
}
