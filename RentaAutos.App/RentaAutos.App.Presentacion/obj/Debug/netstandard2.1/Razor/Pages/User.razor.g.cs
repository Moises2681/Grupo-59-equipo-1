#pragma checksum "D:\MISION TIC 2022\TERCER CICLO\DESARROLLO DE SOFTWARE C3\Repositorio renta de autos\Grupo-59-equipo-1\RentaAutos.App\RentaAutos.App.Presentacion\Pages\User.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8f67132391b8730047ba8e967b38836f5ebfdfe"
// <auto-generated/>
#pragma warning disable 1591
namespace RentaAutos.App.Presentacion.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\MISION TIC 2022\TERCER CICLO\DESARROLLO DE SOFTWARE C3\Repositorio renta de autos\Grupo-59-equipo-1\RentaAutos.App\RentaAutos.App.Presentacion\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MISION TIC 2022\TERCER CICLO\DESARROLLO DE SOFTWARE C3\Repositorio renta de autos\Grupo-59-equipo-1\RentaAutos.App\RentaAutos.App.Presentacion\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MISION TIC 2022\TERCER CICLO\DESARROLLO DE SOFTWARE C3\Repositorio renta de autos\Grupo-59-equipo-1\RentaAutos.App\RentaAutos.App.Presentacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MISION TIC 2022\TERCER CICLO\DESARROLLO DE SOFTWARE C3\Repositorio renta de autos\Grupo-59-equipo-1\RentaAutos.App\RentaAutos.App.Presentacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\MISION TIC 2022\TERCER CICLO\DESARROLLO DE SOFTWARE C3\Repositorio renta de autos\Grupo-59-equipo-1\RentaAutos.App\RentaAutos.App.Presentacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MISION TIC 2022\TERCER CICLO\DESARROLLO DE SOFTWARE C3\Repositorio renta de autos\Grupo-59-equipo-1\RentaAutos.App\RentaAutos.App.Presentacion\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\MISION TIC 2022\TERCER CICLO\DESARROLLO DE SOFTWARE C3\Repositorio renta de autos\Grupo-59-equipo-1\RentaAutos.App\RentaAutos.App.Presentacion\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\MISION TIC 2022\TERCER CICLO\DESARROLLO DE SOFTWARE C3\Repositorio renta de autos\Grupo-59-equipo-1\RentaAutos.App\RentaAutos.App.Presentacion\_Imports.razor"
using RentaAutos.App.Presentacion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\MISION TIC 2022\TERCER CICLO\DESARROLLO DE SOFTWARE C3\Repositorio renta de autos\Grupo-59-equipo-1\RentaAutos.App\RentaAutos.App.Presentacion\_Imports.razor"
using RentaAutos.App.Presentacion.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/user")]
    public partial class User : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "hero");
            __builder.AddAttribute(2, "style", "background-image: url(\'img/hero_1_a.jpg\');");
            __builder.AddMarkupContent(3, "\r\n ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, "\r\n              ");
            __builder.AddMarkupContent(7, "<h1><strong>Renta tu vehículo</strong><br> está al alcance de la mano.</h1>\r\n             \r\n               ");
            __builder.OpenElement(8, "form");
            __builder.AddAttribute(9, "class", "trip-form");
            __builder.AddMarkupContent(10, "\r\n                \r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row align-items-center");
            __builder.AddMarkupContent(13, "\r\n                  \r\n                  ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "mb-3 mb-md-0 col-md-3");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "select");
            __builder.AddAttribute(18, "name", true);
            __builder.AddAttribute(19, "id", true);
            __builder.AddAttribute(20, "class", "custom-select form-control");
            __builder.AddMarkupContent(21, "\r\n                      ");
            __builder.OpenElement(22, "option");
            __builder.AddAttribute(23, "value", true);
            __builder.AddContent(24, "Selecciona el tipo");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                      ");
            __builder.OpenElement(26, "option");
            __builder.AddAttribute(27, "value", true);
            __builder.AddContent(28, "Automovil");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                      ");
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value", true);
            __builder.AddContent(32, "Camioneta");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                      ");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", true);
            __builder.AddContent(36, "Todo Terreno");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                      ");
            __builder.OpenElement(38, "option");
            __builder.AddAttribute(39, "value", true);
            __builder.AddContent(40, "Mico Bus");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                  ");
            __builder.AddMarkupContent(44, @"<div class=""mb-3 mb-md-0 col-md-3"">
                    <div class=""form-control-wrap"">
                      <input type=""text"" id=""cf-3"" placeholder=""Fecha Inicio"" class=""form-control datepicker px-3"">
                      <span class=""icon icon-date_range""></span>

                    </div>
                  </div>
                  ");
            __builder.AddMarkupContent(45, @"<div class=""mb-3 mb-md-0 col-md-3"">
                    <div class=""form-control-wrap"">
                      <input type=""text"" id=""cf-4"" placeholder=""Fecha Final"" class=""form-control datepicker px-3"">
                      <span class=""icon icon-date_range""></span>
                    </div>
                  </div>
                  ");
            __builder.AddMarkupContent(46, "<div class=\"mb-3 mb-md-0 col-md-3\">\r\n                    <input type=\"submit\" value=\"Buscar Ahora\" class=\"btn btn-primary btn-block py-3\">\r\n                  </div>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                \r\n              ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        <br>\r\n        <br>\r\n        <br>\r\n");
            __builder.AddMarkupContent(51, "<h2>Como Trabajamos</h2>\r\n");
            __builder.AddMarkupContent(52, "<h6> 3 Pasos sencillos para empezar</h6>\r\n");
            __builder.AddMarkupContent(53, @"<div class=""row row-cols-1 row-cls-md g-4 mb-3"">
    <div class=""col"">
            <div class=""card border-primary mb-3"" style=""max-width: 18rem;"">
                <div class=""card-header"">1. Primer Paso</div>
                    <div class=""card-body text-primary"">
                    <h5 class=""card-title"">Selecciona tu vehículo </h5>
                    <p class=""card-text"">Escoge el vehículo que se ajuste a tus necesidades</p>
                    </div>
            </div>
            </div>
    <div class=""col"">           
                <div class=""card border-primary mb-3"" style=""max-width: 18rem;"">
                <div class=""card-header"">2.Segundo Paso</div>
                    <div class=""card-body text-primary"">
                    <h5 class=""card-title"">Llena el Formulario</h5>
                    <p class=""card-text"">Son los datos que se requieren para realizar el alquiler.</p>
                    </div>
                </div>
                </div>
    <div class=""col"">           
                <div class=""card border-primary mb-3"" style=""max-width: 18rem;"">
                <div class=""card-header"">3. Tercer Paso</div>
                    <div class=""card-body text-primary"">
                    <h5 class=""card-title"">Realiza tu pago</h5>
                    <p class=""card-text"">Tenemos la facilidad de recibir cualquier tarjeta credito.</p>
                    </div>
                </div>
            </div>
      </div>

  ");
            __builder.AddMarkupContent(54, @"<div class=""site-section"">
        <div class=""container"">
          <div class=""row align-items-center"">
            <div class=""col-lg-7 text-center order-lg-2"">
              <div class=""img-wrap-1 mb-5"">
                <img src=""img/feature_01.png"" alt=""Image"" class=""img-fluid"">
              </div>
            </div>
            <div class=""col-lg-4 ml-auto order-lg-1"">
              <h3 class=""mb-4 section-heading""><strong>Puede aprovechar fácilmente nuestra promoción para alquilar un automóvil.</strong></h3>
              <p class=""mb-5"">Ahorra dinero, muévete con libertad y comodidad por el tiempo que requieras.</p>
              
              <p><a href=""#"" class=""btn btn-primary"">Comunícate con nosotros </a></p>
            </div>
          </div>
        </div>
      </div>   

 ");
            __builder.AddMarkupContent(55, "<div class=\"site-section bg-light\">\r\n      <div class=\"container\">\r\n        <div class=\"row\">\r\n          <div class=\"col-lg-7\">\r\n            <h2 class=\"section-heading\"><strong>Vehículos disponibles para ti.</strong></h2>\r\n            <p class=\"mb-5\">Elige el vehículo de tu preferencia.</p>    \r\n          </div>\r\n        </div>\r\n        \r\n\r\n        <div class=\"row\">\r\n          <div class=\"col-md-6 col-lg-4 mb-4\">\r\n\r\n            <div class=\"listing d-block  align-items-stretch\">\r\n              <div class=\"listing-img h-100 mr-4\">\r\n                <img src=\"img/car1.png\" alt=\"Image\" class=\"img-fluid\">\r\n              </div>\r\n              <div class=\"listing-contents h-100\">\r\n                <h3>Chevrolet Spark</h3>\r\n                <div class=\"rent-price\">\r\n                  <strong>$96.000</strong><span class=\"mx-1\">/</span>Día\r\n                </div>\r\n                <div class=\"d-block d-md-flex mb-3 border-bottom pb-3\">\r\n                  <div class=\"listing-feature pr-4\">\r\n                    <span class=\"caption\">Equipaje:</span>\r\n                    <span class=\"number\">2</span>\r\n                  </div>\r\n                  <div class=\"listing-feature pr-4\">\r\n                    <span class=\"caption\">Puertas:</span>\r\n                    <span class=\"number\">5</span>\r\n                  </div>\r\n                  <div class=\"listing-feature pr-4\">\r\n                    <span class=\"caption\">Pasajeros:</span>\r\n                    <span class=\"number\">5</span>\r\n                  </div>\r\n                </div>\r\n                <div>\r\n                  <p>Línea Economica</p>\r\n                  <p><a href=\"#\" class=\"btn btn-primary btn-sm\">Rentar Ahora</a></p>\r\n                </div>\r\n              </div>\r\n\r\n            </div>\r\n          </div>\r\n\r\n          <div class=\"col-md-6 col-lg-4 mb-4\">\r\n\r\n            <div class=\"listing d-block  align-items-stretch\">\r\n              <div class=\"listing-img h-100 mr-4\">\r\n                <img src=\"img/car2.png\" alt=\"Image\" class=\"img-fluid\">\r\n              </div>\r\n              <div class=\"listing-contents h-100\">\r\n                <h3>Chevrolet Sail</h3>\r\n                <div class=\"rent-price\">\r\n                  <strong>$132.500</strong><span class=\"mx-1\">/</span>Día\r\n                </div>\r\n                <div class=\"d-block d-md-flex mb-3 border-bottom pb-3\">\r\n                  <div class=\"listing-feature pr-4\">\r\n                    <span class=\"caption\">Equipaje:</span>\r\n                    <span class=\"number\">3</span>\r\n                  </div>\r\n                  <div class=\"listing-feature pr-4\">\r\n                    <span class=\"caption\">Puertas:</span>\r\n                    <span class=\"number\">5</span>\r\n                  </div>\r\n                  <div class=\"listing-feature pr-4\">\r\n                    <span class=\"caption\">Pasajeros:</span>\r\n                    <span class=\"number\">5</span>\r\n                  </div>\r\n                </div>\r\n                <div>\r\n                  <p>Compacto Económico.</p>\r\n                  <p><a href=\"#\" class=\"btn btn-primary btn-sm\">Rentar Ahora</a></p>\r\n                </div>\r\n              </div>\r\n\r\n            </div>\r\n          </div>\r\n          \r\n\r\n          <div class=\"col-md-6 col-lg-4 mb-4\">\r\n\r\n            <div class=\"listing d-block  align-items-stretch\">\r\n              <div class=\"listing-img h-100 mr-4\">\r\n                <img src=\"img/car3.png\" alt=\"Image\" class=\"img-fluid\">\r\n              </div>\r\n              <div class=\"listing-contents h-100\">\r\n                <h3>Ford Focus</h3>\r\n                <div class=\"rent-price\">\r\n                  <strong>$195.000</strong><span class=\"mx-1\">/</span>Día\r\n                </div>\r\n                <div class=\"d-block d-md-flex mb-3 border-bottom pb-3\">\r\n                  <div class=\"listing-feature pr-4\">\r\n                    <span class=\"caption\">Equipaje:</span>\r\n                    <span class=\"number\">4</span>\r\n                  </div>\r\n                  <div class=\"listing-feature pr-4\">\r\n                    <span class=\"caption\">Puertas:</span>\r\n                    <span class=\"number\">4</span>\r\n                  </div>\r\n                  <div class=\"listing-feature pr-4\">\r\n                    <span class=\"caption\">Pasajeros:</span>\r\n                    <span class=\"number\">4</span>\r\n                  </div>\r\n                </div>\r\n                <div>\r\n                  <p>Compacto de lujo.</p>\r\n                  <p><a href=\"#\" class=\"btn btn-primary btn-sm\">Rentar Ahora</a></p>\r\n                </div>\r\n              </div>\r\n\r\n            </div>\r\n          </div>\r\n\r\n          <div class=\"col-md-6 col-lg-4 mb-4\">\r\n\r\n            <div class=\"listing d-block  align-items-stretch\">\r\n              <div class=\"listing-img h-100 mr-4\">\r\n                <img src=\"img/car4.png\" alt=\"Image\" class=\"img-fluid\">\r\n              </div>\r\n              <div class=\"listing-contents h-100\">\r\n                <h3>HYUNDAI TUCSON</h3>\r\n                <div class=\"rent-price\">\r\n                  <strong>$232.500</strong><span class=\"mx-1\">/</span>Día\r\n                </div>\r\n                <div class=\"d-block d-md-flex mb-3 border-bottom pb-3\">\r\n                  <div class=\"listing-feature pr-4\">\r\n                    <span class=\"caption\">Equipaje:</span>\r\n                    <span class=\"number\">6</span>\r\n                  </div>\r\n                  <div class=\"listing-feature pr-4\">\r\n                    <span class=\"caption\">Puertas:</span>\r\n                    <span class=\"number\">4</span>\r\n                  </div>\r\n                  <div class=\"listing-feature pr-4\">\r\n                    <span class=\"caption\">Pasajeros:</span>\r\n                    <span class=\"number\">5</span>\r\n                  </div>\r\n                </div>\r\n                <div>\r\n                  <p>Estandar Suv.</p>\r\n                  <p><a href=\"#\" class=\"btn btn-primary btn-sm\">Rentar Ahora</a></p>\r\n                </div>\r\n              </div>\r\n\r\n            </div>\r\n          </div>\r\n\r\n          <div class=\"col-md-6 col-lg-4 mb-4\">\r\n\r\n            <div class=\"listing d-block  align-items-stretch\">\r\n              <div class=\"listing-img h-100 mr-4\">\r\n                <img src=\"img/car5.png\" alt=\"Image\" class=\"img-fluid\">\r\n              </div>\r\n              <div class=\"listing-contents h-100\">\r\n                <h3>WOLSVAGEN TIGUAN</h3>\r\n                <div class=\"rent-price\">\r\n                  <strong>$276.745</strong><span class=\"mx-1\">/</span>Día\r\n                </div>\r\n                <div class=\"d-block d-md-flex mb-3 border-bottom pb-3\">\r\n                  <div class=\"listing-feature pr-4\">\r\n                    <span class=\"caption\">Equipaje:</span>\r\n                    <span class=\"number\">7</span>\r\n                  </div>\r\n                  <div class=\"listing-feature pr-4\">\r\n                    <span class=\"caption\">Puertas:</span>\r\n                    <span class=\"number\">4</span>\r\n                  </div>\r\n                  <div class=\"listing-feature pr-4\">\r\n                    <span class=\"caption\">Pasajeros:</span>\r\n                    <span class=\"number\">5</span>\r\n                  </div>\r\n                </div>\r\n                <div>\r\n                  <p>Estandar Suv.</p>\r\n                  <p><a href=\"#\" class=\"btn btn-primary btn-sm\">Rentar Ahora</a></p>\r\n                </div>\r\n              </div>\r\n\r\n            </div>\r\n          </div>\r\n          \r\n\r\n          <div class=\"col-md-6 col-lg-4 mb-4\">\r\n\r\n            <div class=\"listing d-block  align-items-stretch\">\r\n              <div class=\"listing-img h-100 mr-4\">\r\n                <img src=\"img/car6.png\" alt=\"Image\" class=\"img-fluid\">\r\n              </div>\r\n              <div class=\"listing-contents h-100\">\r\n                <h3>JEEP CHEROKEE</h3>\r\n                <div class=\"rent-price\">\r\n                  <strong>$291.000</strong><span class=\"mx-1\">/</span>Día\r\n                </div>\r\n                <div class=\"d-block d-md-flex mb-3 border-bottom pb-3\">\r\n                  <div class=\"listing-feature pr-4\">\r\n                    <span class=\"caption\">Equipaje:</span>\r\n                    <span class=\"number\">8</span>\r\n                  </div>\r\n                  <div class=\"listing-feature pr-4\">\r\n                    <span class=\"caption\">Puertas:</span>\r\n                    <span class=\"number\">4</span>\r\n                  </div>\r\n                  <div class=\"listing-feature pr-4\">\r\n                    <span class=\"caption\">Pasajero:</span>\r\n                    <span class=\"number\">5</span>\r\n                  </div>\r\n                </div>\r\n                <div>\r\n                  <p>Camioneta 4x4.</p>\r\n                  <p><a href=\"#\" class=\"btn btn-primary btn-sm\">Rentar Ahora</a></p>\r\n                </div>\r\n              </div>\r\n\r\n            </div>\r\n          </div>\r\n\r\n        </div>\r\n      </div>\r\n    </div>\r\n<br>\r\n<br>\r\n<br>\r\n    ");
            __builder.AddMarkupContent(56, "<div class=\"site-section\">\r\n      <div class=\"container\">\r\n        <div class=\"row\">\r\n          <div class=\"col-lg-7\">\r\n            <h2 class=\"section-heading\"><strong>Caracteristicas</strong></h2>\r\n            <p class=\"mb-5\">Alquiler de carros Colombia al mejor precio, las tarifas más bajas en alquiler de carros en Colombia.</p>    \r\n          </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n          <div class=\"col-lg-4 mb-5\">\r\n            <div class=\"service-1 dark\">\r\n              <span class=\"service-1-icon\">\r\n                <span class=\"icon-home\"></span>\r\n              </span>\r\n              <div class=\"service-1-contents\">\r\n                <h3>SERVICIO 24 HORAS</h3>\r\n                <p>Nuestro clientes disponen de una asistencia de 24 horas de emergencia de manera permanente durante los 365 días al año. Así mismo de nuestro contacto center mantenemos sistemas de comunicación bidireccional continua.</p>\r\n               </div>\r\n            </div>\r\n          </div>\r\n          <div class=\"col-lg-4 mb-5\">\r\n            <div class=\"service-1 dark\">\r\n              <span class=\"service-1-icon\">\r\n                <span class=\"icon-gear\"></span>\r\n              </span>\r\n              <div class=\"service-1-contents\">\r\n                <h3>SEGURO PARCIAL</h3>\r\n                <p>Este amparo solo cubre el 80% en caso de siniestro, hurto o cualquier eventualidad ;. ESTE SEGURO BÁSICO ESTA INCLUIDO EN EL VALOR DE LA RENTA. aplica condiciones y restricciones</p>\r\n               </div>\r\n            </div>\r\n          </div>\r\n          <div class=\"col-lg-4 mb-5\">\r\n            <div class=\"service-1 dark\">\r\n              <span class=\"service-1-icon\">\r\n                <span class=\"icon-watch_later\"></span>\r\n              </span>\r\n              <div class=\"service-1-contents\">\r\n                <h3>SEGURO TOTAL</h3>\r\n                <p>Esta SEGURO ampara el 100% DE LA TOTALIDAD DEL VEHÍCULO FRENTE A CUALQUIER SINIESTRO O HURTO. Aplica condiciones y restricciones</p>\r\n               </div>\r\n            </div>\r\n          </div>\r\n\r\n   \r\n          </div>\r\n          <footer>\r\n            Direcciones aquí - © 2021 - Porque Laura dijo\r\n          </footer>\r\n        </div>\r\n    </div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
