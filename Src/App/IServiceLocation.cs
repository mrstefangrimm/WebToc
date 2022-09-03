// Copyright (c) 2022 Stefan Grimm. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//
using Collares;
using Domain;

namespace App {
  using TocResponse = WebApiCollectionResponse<TocItemResponse, Service>;
  public class TocItemResponse : WebApiResourceResponse<Service> { }

  internal class WebTocHrefType : HrefType {
    public static Val2Type<string> ROOT = new Val2Type<string>("ROOT");
    public static Val2Type<string> EVENTS = new Val2Type<string>("EVENTS");
    public static Val2Type<string> OPTIMA = new Val2Type<string>("OPTIMA");
    public static Val2Type<string> MOTIONSYSTEMS = new Val2Type<string>("MOTIONSYSTEMS");
    public static Val2Type<string> LIVEIMAGES = new Val2Type<string>("LIVEIMAGES");
  }

  public interface IServiceLocation {
    TocResponse GetTocResponse();
  }
}
