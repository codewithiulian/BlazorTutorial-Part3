#pragma checksum "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\Pages\Recipe\RecipesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "405a0e0abc9dae9bf817e8f845b136077a7919cc"
// <auto-generated/>
#pragma warning disable 1591
namespace RecipeManager.Pages.Recipe
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\_Imports.razor"
using RecipeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\_Imports.razor"
using RecipeManager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\Pages\Recipe\RecipesList.razor"
using DataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\Pages\Recipe\RecipesList.razor"
using Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/recipes")]
    public partial class RecipesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Recipes List</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-striped");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, @"<thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Title</th>
            <th scope=""col"">Description</th>
            <th scope=""col"">Date Created</th>
            <th scope=""col"">Date Updated</th>
        </tr>
    </thead>
    ");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 22 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\Pages\Recipe\RecipesList.razor"
         if (!Recipes.Any())
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.AddMarkupContent(8, "<tr>\r\n                <th scope=\"row\" colspan=\"5\">No recipes available</th>\r\n            </tr>\r\n");
#nullable restore
#line 27 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\Pages\Recipe\RecipesList.razor"
        }
        else
        {
            foreach (var recipe in Recipes)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "                ");
            __builder.OpenElement(10, "tr");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\Pages\Recipe\RecipesList.razor"
                              () => RedirectTo(recipe.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "th");
            __builder.AddAttribute(14, "scope", "row");
            __builder.AddContent(15, 
#nullable restore
#line 33 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\Pages\Recipe\RecipesList.razor"
                                     recipe.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 34 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\Pages\Recipe\RecipesList.razor"
                         recipe.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 35 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\Pages\Recipe\RecipesList.razor"
                         recipe.Description.Substring(0, 50)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, " ...");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 36 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\Pages\Recipe\RecipesList.razor"
                         recipe.DateCreated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 37 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\Pages\Recipe\RecipesList.razor"
                         recipe.DateUpdated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 39 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\Pages\Recipe\RecipesList.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\Projects\YouTube\Content\4. RecipeManager-3\Project\after\RecipeManager-tut4\RecipeManager\RecipeManager\Pages\Recipe\RecipesList.razor"
       
    List<Recipe> Recipes = new List<Recipe>();

    protected override async Task OnInitializedAsync()
    {
        Recipes = RecipeService.List();
    }

    private void RedirectTo(int recipeId)
    {
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecipeService RecipeService { get; set; }
    }
}
#pragma warning restore 1591
