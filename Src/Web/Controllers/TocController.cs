// Copyright (c) 2022 Stefan Grimm. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//
using App;
using Collares;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web {
  using TocResponse = WebApiCollectionResponse<TocItemResponse, Service>;
  class TocItemResponse : WebApiResourceResponse<Service> { }

  [Route("api/[controller]")]
  [ApiController]
  public class TocController : ControllerBase {

    private readonly IServiceLocation _tocService;

    public TocController(IServiceLocation tocService) {
      _tocService = tocService;
    }

    // GET: api/toc
    [HttpGet("toc")]
    [ProducesResponseType(typeof(TocResponse), StatusCodes.Status200OK)]
    public IActionResult GetToc() {
      return Ok(_tocService.GetTocResponse());
    }
    
    [HttpGet("info")]
    public IActionResult GetTocInfo() {
      // Create the response
      WebApiInfoResponse<object> response = new();
      response.AddHref(HrefType.Get, $"api/toc/toc");
      return Ok(response);
    }

  }
}
