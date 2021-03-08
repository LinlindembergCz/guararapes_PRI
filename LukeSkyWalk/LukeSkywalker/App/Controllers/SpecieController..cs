﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LukeSkywalker.Models;
using LukeSkywalker.Database;
using LukeSkywalker.HATEOAS;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore;
using LukeSkywalker.Domain.Interfaces.Services;

namespace LukeSkywalker.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]

    public class SpecieController : ControllerBase
    {
        private readonly IServiceEntity<Species> service;

        public SpecieController(IServiceEntity<Species> _service)
        {
            this.service = _service;
        }

        [EnableCors("AnotherPolicy")]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var entities = service.Get();
                return Ok(entities);
            }
            catch (Exception e)
            {
                Response.StatusCode = 404;
                return new ObjectResult("deu ruim!");
            }

        }

        [EnableCors("AnotherPolicy")]
        [HttpGet("list/{name}")]
        public IActionResult List(string name)
        {
            try
            {
                var entities = service.List(name);

                return Ok(entities);
            }
            catch (Exception e)
            {
                Response.StatusCode = 404;
                return new ObjectResult("deu ruim!");
            }
        }

        [EnableCors("AnotherPolicy")]
        [HttpGet("{id}")]
        //public async Task<FilmContainer> Get(int id)
        public IActionResult Get(int id)
        {
            try
            {
                Species entityActual = service.GetById(id);
                if (entityActual != null)
                {
                    Response.StatusCode = 302;
                    return Ok(entityActual);
                }
                else
                {
                    Response.StatusCode = 204;//No Content
                    return null;
                }
            }
            catch (Exception e)
            {
                Response.StatusCode = 404;
                return new ObjectResult("deu ruim!");
            }
        }

        [EnableCors("AnotherPolicy")]
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Create([FromBody] Species entity)
        {
            if (ModelState.IsValid)
            {
                if (entity.Id == 0)
                {
                    service.Create(entity);
                    Response.StatusCode = 201;//Created
                    return Ok(new { msg = "criado com sucesso!" });
                }
                else
                {
                    Response.StatusCode = 404;//	Not Acceptable
                    return null;
                }
            }
            else
            {
                Response.StatusCode = 406;//	Not Acceptable
                return new ObjectResult("deu ruim!");
            }
        }

        //[AllowAnonymous]
        [EnableCors("AnotherPolicy")]
        [HttpPut]
        public IActionResult Modify([FromBody] Species entity)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    service.Modify(entity);
                    return Ok(new { msg = "alterado com sucesso!" });
                }
                else
                {
                    Response.StatusCode = 304; //	Not Modified
                    return new ObjectResult("deu ruim!");
                }
            }
            catch (Exception e)
            {
                Response.StatusCode = 406;//	Not Acceptable
                return new ObjectResult("deu ruim!");
            }
        }
        [EnableCors("AnotherPolicy")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                service.Delete(id);
                return Ok();
            }
            catch (Exception e)
            {
                Response.StatusCode = 404;
                return new ObjectResult("deu ruim!");
            }
        }


    }
}