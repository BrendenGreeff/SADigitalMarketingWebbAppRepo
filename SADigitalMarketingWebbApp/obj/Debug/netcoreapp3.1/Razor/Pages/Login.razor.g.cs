#pragma checksum "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2754f150ab182aba6f531bed48ffaaa6b720019e"
// <auto-generated/>
#pragma warning disable 1591
namespace SADigitalMarketingWebbApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\_Imports.razor"
using SADigitalMarketingWebbApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\_Imports.razor"
using SADigitalMarketingWebbApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\Pages\Login.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\Pages\Login.razor"
using SADigitalMarketingWebbApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\Pages\Login.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Login_Layout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .div {
        margin: auto;
        width: auto;
    }

    label {
        display: block;
        width: 90px;
        text-align: center;
        font-weight: bold;
    }

    .backgroundimg {
        background-image: url(https://images.pexels.com/photos/1103970/pexels-photo-1103970.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260);
        width: 1880px;
        height: 880px;
        background-repeat: no-repeat;
        background-position: center;
        background-size: cover;
    }

    .heading {
        font-size: 150px;
        font-weight: bold;
    }

    .container {
        background-color: aliceblue;
        width: 20%;
        height: 55%;
        text-align: center;
    }
</style>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "div");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "backgroundimg");
            __builder.AddAttribute(6, "align", "center");
            __builder.AddMarkupContent(7, "\r\n        <br>\r\n        <br>\r\n        <br>\r\n        <br>\r\n\r\n\r\n        ");
            __builder.AddMarkupContent(8, "<h3 class=\"heading\">Login</h3>\r\n        <br>\r\n        <br>\r\n        ");
            __builder.AddMarkupContent(9, "<h5>Please enter your user name and password to login or sign up if you dont have an account!</h5>\r\n        <br>\r\n        ");
            __builder.AddMarkupContent(10, "<label>Username</label>\r\n        ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "id", "username");
            __builder.AddAttribute(14, "placeholder", "Enter Username");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 63 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\Pages\Login.razor"
                                                Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Username = __value, Username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        <br>\r\n        <br>\r\n        ");
            __builder.AddMarkupContent(18, "<label>Password</label>\r\n        ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "password");
            __builder.AddAttribute(21, "id", "password");
            __builder.AddAttribute(22, "placeholder", "Enter Password");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 67 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\Pages\Login.razor"
                                                    Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Password = __value, Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n        ");
            __builder.OpenElement(26, "p");
            __builder.AddAttribute(27, "style", "color:" + (
#nullable restore
#line 69 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\Pages\Login.razor"
                         Color

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(28, "b");
            __builder.AddContent(29, 
#nullable restore
#line 69 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\Pages\Login.razor"
                                    text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        <br>\r\n        <br>\r\n        ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "type", "submit");
            __builder.AddAttribute(33, "class", "btn-primary");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\Pages\Login.razor"
                                                            Submit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        <br>\r\n        ");
            __builder.AddMarkupContent(37, "<h4>--------or--------</h4>\r\n        ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "type", "submit");
            __builder.AddAttribute(40, "class", "btn-secondary");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\Pages\Login.razor"
                                                              Navigate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Signup");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\Pages\Login.razor"
      
    private string Username { get; set; }
    private string Password { get; set; }

    string Color = "black";
    string text = "";

    List<UsersModel> users;

    protected override async Task OnInitializedAsync()
    {
        string sql = "SELECT Users_Fname, Users_Username FROM users";
        users = await _data.LoadData<UsersModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
    }

    private void Submit()
    {
        
        if (Username == "Brenden" && Password == "1234567")
        { 
            Color = "green";
            text = "Welcome Guest!";

            Username = "";
            Password = "";

            UriHelper.NavigateTo("/index");

        }
        else
        {
            Color = "red";
            text = "User Password Wrong!";
            Username = "";
            Password = "";

        }
    }

    private void Navigate()
    {
        UriHelper.NavigateTo("/signup");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591
