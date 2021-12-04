using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using ServiciosGubernamentales2.Controllers;

namespace ServiciosGubernamentales2.Controllers
{
    [EnableCors(origins: "localhost", headers: "*", methods: "*")]
    public class DefaultController : ApiController
    {
        private const int ARCILLOSO = 1, ARENOSO = 2, CALIZO = 3, MIXTO = 4;
        [HttpGet]
        public IHttpActionResult validarCategoriaPredio(Predio predio)
        {


            switch (predio.PreTipoSuelo)
            {
                case ARCILLOSO:

                    if (predio.PreHectareas <= 100)
                    {
                        if (predio.PreFactorHumedad <= 10.0)
                        {
                            if (predio.PreFactorLluvia < 25.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                return Ok(new { results = "Organico" });

                            }

                            if (predio.PreFactorLluvia < 100.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "No Organico" });

                        }

                        if (predio.PreFactorHumedad < 15.0)
                        {

                            if (predio.PreFactorLluvia < 25.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                return Ok(new { results = "Organico" });

                            }

                            if (predio.PreFactorLluvia < 100.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorLluvia < 25.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            return Ok(new { results = "Organico" });

                        }

                        if (predio.PreFactorLluvia < 100.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "No Organico" });
                        }

                        return Ok(new { results = "Organico" });
                    }

                    if (predio.PreHectareas > 100 && predio.PreHectareas <= 200)
                    {
                        if (predio.PreFactorHumedad <= 10.0)
                        {
                            if (predio.PreFactorLluvia < 25.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                return Ok(new { results = "Organico" });

                            }

                            if (predio.PreFactorLluvia < 100.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            return Ok(new { results = "No Organico" });

                        }

                        if (predio.PreFactorHumedad < 15.0)
                        {

                            if (predio.PreFactorLluvia < 25.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                return Ok(new { results = "Organico" });

                            }

                            if (predio.PreFactorLluvia < 100.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorLluvia < 25.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "Organico" });

                        }

                        if (predio.PreFactorLluvia < 100.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "No Organico" });
                        }

                        return Ok(new { results = "No Organico" });
                    }

                    if (predio.PreFactorHumedad <= 10.0)
                    {
                        if (predio.PreFactorLluvia < 25.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            return Ok(new { results = "Organico" });

                        }

                        if (predio.PreFactorLluvia < 100.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "No Organico" });
                        }

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "No Organico" });
                        }

                        return Ok(new { results = "No Organico" });

                    }

                    if (predio.PreFactorHumedad < 15.0)
                    {

                        if (predio.PreFactorLluvia < 25.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            return Ok(new { results = "Organico" });

                        }

                        if (predio.PreFactorLluvia < 100.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "No Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "No Organico" });
                        }

                        return Ok(new { results = "Organico" });
                    }

                    if (predio.PreFactorLluvia < 25.0)
                    {

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "No Organico" });
                        }

                        return Ok(new { results = "Organico" });

                    }

                    if (predio.PreFactorLluvia < 100.0)
                    {

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "No Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        return Ok(new { results = "Organico" });
                    }

                    if (predio.PreFactorResequedad < 17.3)
                    {
                        return Ok(new { results = "Organico" });
                    }

                    if (predio.PreFactorResequedad < 39.2)
                    {
                        return Ok(new { results = "No Organico" });
                    }

                    return Ok(new { results = "No Organico" });
                case ARENOSO:

                    if (predio.PreHectareas <= 100)
                    {
                        if (predio.PreFactorHumedad <= 10.0)
                        {
                            if (predio.PreFactorLluvia < 25.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                return Ok(new { results = "Organico" });

                            }

                            if (predio.PreFactorLluvia < 100.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "Organico" });

                        }

                        if (predio.PreFactorHumedad < 15.0)
                        {

                            if (predio.PreFactorLluvia < 25.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                return Ok(new { results = "No Organico" });

                            }

                            if (predio.PreFactorLluvia < 100.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorLluvia < 25.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            return Ok(new { results = "Organico" });

                        }

                        if (predio.PreFactorLluvia < 100.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "No Organico" });
                        }

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "No Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        return Ok(new { results = "Organico" });
                    }

                    if (predio.PreHectareas > 100 && predio.PreHectareas <= 200)
                    {
                        if (predio.PreFactorHumedad <= 10.0)
                        {
                            if (predio.PreFactorLluvia < 25.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                return Ok(new { results = "Organico" });

                            }

                            if (predio.PreFactorLluvia < 100.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "Organico" });

                        }

                        if (predio.PreFactorHumedad < 15.0)
                        {

                            if (predio.PreFactorLluvia < 25.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                return Ok(new { results = "No Organico" });

                            }

                            if (predio.PreFactorLluvia < 100.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorLluvia < 25.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            return Ok(new { results = "Organico" });

                        }

                        if (predio.PreFactorLluvia < 100.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            return Ok(new { results = "No Organico" });
                        }

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        return Ok(new { results = "Organico" });
                    }
                    if (predio.PreFactorHumedad <= 10.0)
                    {
                        if (predio.PreFactorLluvia < 25.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "Organico" });

                        }

                        if (predio.PreFactorLluvia < 100.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "No Organico" });
                        }

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        return Ok(new { results = "Organico" });

                    }

                    if (predio.PreFactorHumedad < 15.0)
                    {

                        if (predio.PreFactorLluvia < 25.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "No Organico" });

                        }

                        if (predio.PreFactorLluvia < 100.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "No Organico" });
                        }

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        return Ok(new { results = "Organico" });
                    }

                    if (predio.PreFactorLluvia < 25.0)
                    {

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "No Organico" });
                        }

                        return Ok(new { results = "Organico" });

                    }

                    if (predio.PreFactorLluvia < 100.0)
                    {

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "No Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        return Ok(new { results = "Organico" });
                    }

                    if (predio.PreFactorResequedad < 17.3)
                    {
                        return Ok(new { results = "Organico" });
                    }

                    if (predio.PreFactorResequedad < 39.2)
                    {
                        return Ok(new { results = "Organico" });
                    }

                    return Ok(new { results = "Organico" });
                case CALIZO:
                    if (predio.PreHectareas <= 100)
                    {
                        if (predio.PreFactorHumedad <= 10.0)
                        {
                            if (predio.PreFactorLluvia < 25.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                return Ok(new { results = "Organico" });

                            }

                            if (predio.PreFactorLluvia < 100.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            return Ok(new { results = "Organico" });

                        }

                        if (predio.PreFactorHumedad < 15.0)
                        {

                            if (predio.PreFactorLluvia < 25.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                return Ok(new { results = "Organico" });

                            }

                            if (predio.PreFactorLluvia < 100.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorLluvia < 25.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            return Ok(new { results = "Organico" });

                        }

                        if (predio.PreFactorLluvia < 100.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "No Organico" });
                        }

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        return Ok(new { results = "Organico" });
                    }

                    if (predio.PreHectareas > 100 && predio.PreHectareas <= 200)
                    {
                        if (predio.PreFactorHumedad <= 10.0)
                        {
                            if (predio.PreFactorLluvia < 25.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                return Ok(new { results = "Organico" });

                            }

                            if (predio.PreFactorLluvia < 100.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "Organico" });

                        }

                        if (predio.PreFactorHumedad < 15.0)
                        {

                            if (predio.PreFactorLluvia < 25.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                return Ok(new { results = "Organico" });

                            }

                            if (predio.PreFactorLluvia < 100.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorLluvia < 25.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            return Ok(new { results = "Organico" });

                        }

                        if (predio.PreFactorLluvia < 100.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "No Organico" });
                        }

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        return Ok(new { results = "Organico" });
                    }
                    if (predio.PreFactorHumedad <= 10.0)
                    {
                        if (predio.PreFactorLluvia < 25.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            return Ok(new { results = "Organico" });

                        }

                        if (predio.PreFactorLluvia < 100.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "No Organico" });
                        }

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        return Ok(new { results = "Organico" });

                    }

                    if (predio.PreFactorHumedad < 15.0)
                    {

                        if (predio.PreFactorLluvia < 25.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            return Ok(new { results = "Organico" });

                        }

                        if (predio.PreFactorLluvia < 100.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            return Ok(new { results = "No Organico" });
                        }

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "No Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "No Organico" });
                        }

                        return Ok(new { results = "Organico" });
                    }

                    if (predio.PreFactorLluvia < 25.0)
                    {

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "No Organico" });
                        }

                        return Ok(new { results = "Organico" });

                    }

                    if (predio.PreFactorLluvia < 100.0)
                    {

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "No Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        return Ok(new { results = "Organico" });
                    }

                    if (predio.PreFactorResequedad < 17.3)
                    {
                        return Ok(new { results = "Organico" });
                    }

                    if (predio.PreFactorResequedad < 39.2)
                    {
                        return Ok(new { results = "Organico" });
                    }

                    return Ok(new { results = "Organico" });

                case MIXTO:

                    if (predio.PreHectareas <= 100)
                    {
                        if (predio.PreFactorHumedad <= 10.0)
                        {
                            if (predio.PreFactorLluvia < 25.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                return Ok(new { results = "Organico" });

                            }

                            if (predio.PreFactorLluvia < 100.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "Organico" });

                        }

                        if (predio.PreFactorHumedad < 15.0)
                        {

                            if (predio.PreFactorLluvia < 25.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                return Ok(new { results = "No Organico" });

                            }

                            if (predio.PreFactorLluvia < 100.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorLluvia < 25.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            return Ok(new { results = "Organico" });

                        }

                        if (predio.PreFactorLluvia < 100.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        return Ok(new { results = "Organico" });
                    }

                    if (predio.PreHectareas > 100 && predio.PreHectareas <= 200)
                    {
                        if (predio.PreFactorHumedad <= 10.0)
                        {
                            if (predio.PreFactorLluvia < 25.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                return Ok(new { results = "No Organico" });

                            }

                            if (predio.PreFactorLluvia < 100.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "Organico" });

                        }

                        if (predio.PreFactorHumedad < 15.0)
                        {

                            if (predio.PreFactorLluvia < 25.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                return Ok(new { results = "No Organico" });

                            }

                            if (predio.PreFactorLluvia < 100.0)
                            {

                                if (predio.PreFactorResequedad < 17.3)
                                {
                                    return Ok(new { results = "No Organico" });
                                }

                                if (predio.PreFactorResequedad < 39.2)
                                {
                                    return Ok(new { results = "Organico" });
                                }

                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorLluvia < 25.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            return Ok(new { results = "Organico" });

                        }

                        if (predio.PreFactorLluvia < 100.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "No Organico" });
                        }

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        return Ok(new { results = "Organico" });
                    }
                    if (predio.PreFactorHumedad <= 10.0)
                    {
                        if (predio.PreFactorLluvia < 25.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "Organico" });

                        }

                        if (predio.PreFactorLluvia < 100.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            return Ok(new { results = "No Organico" });
                        }

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        return Ok(new { results = "Organico" });

                    }

                    if (predio.PreFactorHumedad < 15.0)
                    {

                        if (predio.PreFactorLluvia < 25.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            return Ok(new { results = "No Organico" });

                        }

                        if (predio.PreFactorLluvia < 100.0)
                        {

                            if (predio.PreFactorResequedad < 17.3)
                            {
                                return Ok(new { results = "No Organico" });
                            }

                            if (predio.PreFactorResequedad < 39.2)
                            {
                                return Ok(new { results = "Organico" });
                            }

                            return Ok(new { results = "No Organico" });
                        }

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        return Ok(new { results = "Organico" });
                    }

                    if (predio.PreFactorLluvia < 25.0)
                    {

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "Organico" });
                        }

                        return Ok(new { results = "Organico" });

                    }

                    if (predio.PreFactorLluvia < 100.0)
                    {

                        if (predio.PreFactorResequedad < 17.3)
                        {
                            return Ok(new { results = "No Organico" });
                        }

                        if (predio.PreFactorResequedad < 39.2)
                        {
                            return Ok(new { results = "No Organico" });
                        }

                        return Ok(new { results = "No Organico" });
                    }

                    if (predio.PreFactorResequedad < 17.3)
                    {
                        return Ok(new { results = "No Organico" });
                    }

                    if (predio.PreFactorResequedad < 39.2)
                    {
                        return Ok(new { results = "No Organico" });
                    }

                    return Ok(new { results = "No Organico" });
            }

            return Ok(new { results = "No Organico" });
        }
        
    }
}
