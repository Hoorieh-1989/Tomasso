﻿using Inlämning1Tomasso.Data.DTOs;
using Inlämning1Tomasso.Data.Interface.Services;



using Microsoft.AspNetCore.Mvc;

namespace Inlämning1Tomaso.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpGet]
        public ActionResult<List<CategoryDto>> GetAll()
        {
            return Ok(_categoryService.GetAllCategories());
        }



    }
}

