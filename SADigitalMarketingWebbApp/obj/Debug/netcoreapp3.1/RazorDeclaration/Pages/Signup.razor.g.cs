#pragma checksum "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\Pages\Signup.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bc682d06a1776e87deed3281e1aaf6ddc334a73"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Login_Signup_Layout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/signup")]
    public partial class Signup : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "C:\Users\brend\Downloads\UniversityFinalSem2\CMPG 323\Project2\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbAppRepo\SADigitalMarketingWebbApp\Pages\Signup.razor"
       

    private string Username { get; set; }
    private string Password { get; set; }
    private string FirstName { get; set; }
    private string LastName { get; set; }
    private string Email { get; set; }
    private string DateofBirth { get; set; }
    private string ConfirmPassword { get; set; }
    private string PhoneNumber { get; set; }

    string Color = "black";
    string text = "";

    private void Submit()
    {
        if (Password == ConfirmPassword)
        {
            if (FirstName != "" && LastName != "" && Username != "" && Email != "" && DateofBirth != null && Password != null && ConfirmPassword != null)
            {
                Color = "green";
                text = "Welcome Guest!";

                FirstName = "";
                LastName = "";
                Username = "";
                Email = "";
                DateofBirth = "";
                Password = "";
                ConfirmPassword = "";
                UriHelper.NavigateTo("/");
            }
            else
            {
                Color = "red";
                text = "Please fill in all the fields!";

                FirstName = "";
                LastName = "";
                Username = "";
                Email = "";
                DateofBirth = "";
                Password = "";
                ConfirmPassword = "";

            }

        }
        else
        {
            Color = "red";
            text = "Passwords dont match, retry!";

            FirstName = "";
            LastName = "";
            Username = "";
            Email = "";
            DateofBirth = "";
            Password = "";
            ConfirmPassword = "";

        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591
