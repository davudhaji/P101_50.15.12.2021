#pragma checksum "C:\Users\tu201806253\source\repos\WebApplication4\WebApplication4\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7948186e2f3e4e1bf413ed81ecf661674be34c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Index), @"mvc.1.0.view", @"/Views/Menu/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\tu201806253\source\repos\WebApplication4\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tu201806253\source\repos\WebApplication4\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7948186e2f3e4e1bf413ed81ecf661674be34c5", @"/Views/Menu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fff4eb847734ec2c3f91807e9b1a08bbda85e45", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\tu201806253\source\repos\WebApplication4\WebApplication4\Views\Menu\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"page-header mb-0\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <h2>Food Menu</h2>\r\n            </div>\r\n            <div class=\"col-12\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 273, "\"", 280, 0);
            EndWriteAttribute();
            WriteLiteral(">Home</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 310, "\"", 317, 0);
            EndWriteAttribute();
            WriteLiteral(@">Menu</a>
            </div>
        </div>
    </div>
</div>
<!-- Page Header End -->
<!-- Food Start -->
<div class=""food mt-0"">
    <div class=""container"">
        <div class=""row align-items-center"">
            <div class=""col-md-4"">
                <div class=""food-item"">
                    <i class=""flaticon-burger""></i>
                    <h2>Burgers</h2>
                    <p>
                        Lorem ipsum dolor sit amet elit. Phasel nec pretium mi. Curabit facilis ornare velit non vulputa. Aliquam metus tortor auctor quis sem.
                    </p>
                    <a");
            BeginWriteAttribute("href", " href=\"", 934, "\"", 941, 0);
            EndWriteAttribute();
            WriteLiteral(@">View Menu</a>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""food-item"">
                    <i class=""flaticon-snack""></i>
                    <h2>Snacks</h2>
                    <p>
                        Lorem ipsum dolor sit amet elit. Phasel nec pretium mi. Curabit facilis ornare velit non vulputa. Aliquam metus tortor auctor quis sem.
                    </p>
                    <a");
            BeginWriteAttribute("href", " href=\"", 1402, "\"", 1409, 0);
            EndWriteAttribute();
            WriteLiteral(@">View Menu</a>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""food-item"">
                    <i class=""flaticon-cocktail""></i>
                    <h2>Beverages</h2>
                    <p>
                        Lorem ipsum dolor sit amet elit. Phasel nec pretium mi. Curabit facilis ornare velit non vulputa. Aliquam metus tortor auctor quis sem.
                    </p>
                    <a");
            BeginWriteAttribute("href", " href=\"", 1876, "\"", 1883, 0);
            EndWriteAttribute();
            WriteLiteral(@">View Menu</a>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Food End -->
<!-- Menu Start -->
<div class=""menu"">
    <div class=""container"">
        <div class=""section-header text-center"">
            <p>Food Menu</p>
            <h2>Delicious Food Menu</h2>
        </div>
        <div class=""menu-tab"">
            <ul class=""nav nav-pills justify-content-center"">
                <li class=""nav-item"">
                    <a class=""nav-link active"" data-toggle=""pill"" href=""#burgers"">Burgers</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" data-toggle=""pill"" href=""#snacks"">Snacks</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" data-toggle=""pill"" href=""#beverages"">Beverages</a>
                </li>
            </ul>
            <div class=""tab-content"">
                <div id=""burgers"" class=""container tab-pane active"">
                   ");
            WriteLiteral(@" <div class=""row"">
                        <div class=""col-lg-7 col-md-12"">
                            <div class=""menu-item"">
                                <div class=""menu-img"">
                                    <img src=""img/menu-burger.jpg"" alt=""Image"">
                                </div>
                                <div class=""menu-text"">
                                    <h3><span>Mini cheese Burger</span> <strong>$9.00</strong></h3>
                                    <p>Lorem ipsum dolor sit amet elit. Phasel nec preti facil</p>
                                </div>
                            </div>
                            <div class=""menu-item"">
                                <div class=""menu-img"">
                                    <img src=""img/menu-burger.jpg"" alt=""Image"">
                                </div>
                                <div class=""menu-text"">
                                    <h3><span>Double size burger</span> <strong>$11.00</strong>");
            WriteLiteral(@"</h3>
                                    <p>Lorem ipsum dolor sit amet elit. Phasel nec preti facil</p>
                                </div>
                            </div>
                            <div class=""menu-item"">
                                <div class=""menu-img"">
                                    <img src=""img/menu-burger.jpg"" alt=""Image"">
                                </div>
                                <div class=""menu-text"">
                                    <h3><span>Bacon, EGG and Cheese</span> <strong>$13.00</strong></h3>
                                    <p>Lorem ipsum dolor sit amet elit. Phasel nec preti facil</p>
                                </div>
                            </div>
                            <div class=""menu-item"">
                                <div class=""menu-img"">
                                    <img src=""img/menu-burger.jpg"" alt=""Image"">
                                </div>
                                <div class=");
            WriteLiteral(@"""menu-text"">
                                    <h3><span>Pulled porx Burger</span> <strong>$18.00</strong></h3>
                                    <p>Lorem ipsum dolor sit amet elit. Phasel nec preti facil</p>
                                </div>
                            </div>
                            <div class=""menu-item"">
                                <div class=""menu-img"">
                                    <img src=""img/menu-burger.jpg"" alt=""Image"">
                                </div>
                                <div class=""menu-text"">
                                    <h3><span>Fried chicken Burger</span> <strong>$22.00</strong></h3>
                                    <p>Lorem ipsum dolor sit amet elit. Phasel nec preti facil</p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-5 d-none d-lg-block"">
                            <img src=""img/menu-burger-img.jpg"" alt=");
            WriteLiteral(@"""Image"">
                        </div>
                    </div>
                </div>
                <div id=""snacks"" class=""container tab-pane fade"">
                    <div class=""row"">
                        <div class=""col-lg-7 col-md-12"">
                            <div class=""menu-item"">
                                <div class=""menu-img"">
                                    <img src=""img/menu-snack.jpg"" alt=""Image"">
                                </div>
                                <div class=""menu-text"">
                                    <h3><span>Corn Tikki - Spicy fried Aloo</span> <strong>$15.00</strong></h3>
                                    <p>Lorem ipsum dolor sit amet elit. Phasel nec preti facil</p>
                                </div>
                            </div>
                            <div class=""menu-item"">
                                <div class=""menu-img"">
                                    <img src=""img/menu-snack.jpg"" alt=""Image"">
  ");
            WriteLiteral(@"                              </div>
                                <div class=""menu-text"">
                                    <h3><span>Bread besan Toast</span> <strong>$35.00</strong></h3>
                                    <p>Lorem ipsum dolor sit amet elit. Phasel nec preti facil</p>
                                </div>
                            </div>
                            <div class=""menu-item"">
                                <div class=""menu-img"">
                                    <img src=""img/menu-snack.jpg"" alt=""Image"">
                                </div>
                                <div class=""menu-text"">
                                    <h3><span>Healthy soya nugget snacks</span> <strong>$20.00</strong></h3>
                                    <p>Lorem ipsum dolor sit amet elit. Phasel nec preti facil</p>
                                </div>
                            </div>
                            <div class=""menu-item"">
                           ");
            WriteLiteral(@"     <div class=""menu-img"">
                                    <img src=""img/menu-snack.jpg"" alt=""Image"">
                                </div>
                                <div class=""menu-text"">
                                    <h3><span>Tandoori Soya Chunks</span> <strong>$30.00</strong></h3>
                                    <p>Lorem ipsum dolor sit amet elit. Phasel nec preti facil</p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-5 d-none d-lg-block"">
                            <img src=""img/menu-snack-img.jpg"" alt=""Image"">
                        </div>
                    </div>
                </div>
                <div id=""beverages"" class=""container tab-pane fade"">
                    <div class=""row"">
                        <div class=""col-lg-7 col-md-12"">
                            <div class=""menu-item"">
                                <div class=""menu-img"">
    ");
            WriteLiteral(@"                                <img src=""img/menu-beverage.jpg"" alt=""Image"">
                                </div>
                                <div class=""menu-text"">
                                    <h3><span>Single Cup Brew</span> <strong>$7.00</strong></h3>
                                    <p>Lorem ipsum dolor sit amet elit. Phasel nec preti facil</p>
                                </div>
                            </div>
                            <div class=""menu-item"">
                                <div class=""menu-img"">
                                    <img src=""img/menu-beverage.jpg"" alt=""Image"">
                                </div>
                                <div class=""menu-text"">
                                    <h3><span>Caffe Americano</span> <strong>$9.00</strong></h3>
                                    <p>Lorem ipsum dolor sit amet elit. Phasel nec preti facil</p>
                                </div>
                            </div>
           ");
            WriteLiteral(@"                 <div class=""menu-item"">
                                <div class=""menu-img"">
                                    <img src=""img/menu-beverage.jpg"" alt=""Image"">
                                </div>
                                <div class=""menu-text"">
                                    <h3><span>Caramel Macchiato</span> <strong>$15.00</strong></h3>
                                    <p>Lorem ipsum dolor sit amet elit. Phasel nec preti facil</p>
                                </div>
                            </div>
                            <div class=""menu-item"">
                                <div class=""menu-img"">
                                    <img src=""img/menu-beverage.jpg"" alt=""Image"">
                                </div>
                                <div class=""menu-text"">
                                    <h3><span>Standard black coffee</span> <strong>$8.00</strong></h3>
                                    <p>Lorem ipsum dolor sit amet elit. Phas");
            WriteLiteral(@"el nec preti facil</p>
                                </div>
                            </div>
                            <div class=""menu-item"">
                                <div class=""menu-img"">
                                    <img src=""img/menu-beverage.jpg"" alt=""Image"">
                                </div>
                                <div class=""menu-text"">
                                    <h3><span>Standard black coffee</span> <strong>$12.00</strong></h3>
                                    <p>Lorem ipsum dolor sit amet elit. Phasel nec preti facil</p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-5 d-none d-lg-block"">
                            <img src=""img/menu-beverage-img.jpg"" alt=""Image"">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
