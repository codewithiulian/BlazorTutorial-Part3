// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RecipeManager.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\YouTube\3. RecipeManager-2\Project\before\RecipeManager\RecipeManager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\YouTube\3. RecipeManager-2\Project\before\RecipeManager\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\YouTube\3. RecipeManager-2\Project\before\RecipeManager\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\YouTube\3. RecipeManager-2\Project\before\RecipeManager\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\YouTube\3. RecipeManager-2\Project\before\RecipeManager\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\YouTube\3. RecipeManager-2\Project\before\RecipeManager\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\YouTube\3. RecipeManager-2\Project\before\RecipeManager\RecipeManager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\YouTube\3. RecipeManager-2\Project\before\RecipeManager\RecipeManager\_Imports.razor"
using RecipeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\YouTube\3. RecipeManager-2\Project\before\RecipeManager\RecipeManager\_Imports.razor"
using RecipeManager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\YouTube\3. RecipeManager-2\Project\before\RecipeManager\RecipeManager\Pages\RecipesList.razor"
using DataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\YouTube\3. RecipeManager-2\Project\before\RecipeManager\RecipeManager\Pages\RecipesList.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\Projects\YouTube\3. RecipeManager-2\Project\before\RecipeManager\RecipeManager\Pages\RecipesList.razor"
       
    List<Recipe> Recipes = new List<Recipe>();

    protected override async Task OnInitializedAsync()
    {
        Recipes = RecipeService.List();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecipeService RecipeService { get; set; }
    }
}
#pragma warning restore 1591
