// Copyright (c) 2020 Stefan Grimm. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//
// Copyright (c) 2022 Stefan Grimm. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//
using Collares;
using Domain;

namespace App {
  using TocResponse = WebApiCollectionResponse<TocItemResponse, Service>;

  public class ServiceLocation : IServiceLocation {

    public TocResponse GetTocResponse() {
      TocResponse response = new();

      TocItemResponse opteamate = new();
      response.Data.Add(opteamate);
      opteamate.Id = 1;
      opteamate.Data = new Service {
        Name = "opteamate",
        Url = "https://webaepp.dynv6.net:50444",
      };
      opteamate.AddHref(WebTocHrefType.EVENTS, "api/events");
      opteamate.AddHref(WebTocHrefType.OPTIMA, "api/optima");

      TocItemResponse virms = new();
      response.Data.Add(virms);
      virms.Id = 2;
      virms.Data = new Service {
        Name = "virms",
        Url = "https://webaepp.dynv6.net:50445",
      };
      virms.AddHref(WebTocHrefType.MOTIONSYSTEMS, "api/motionsystems");
      virms.AddHref(WebTocHrefType.LIVEIMAGES, "images");

      response.AddHref(HrefType.Get, "api/toc/toc");

      return response;
    }

  }
}
