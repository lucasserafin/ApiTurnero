#pragma checksum "C:\Users\Lucas\Desktop\programacion\programacion\ApiTurnero\ApiTurnero.WebApi\Client\Pages\Cliente\ClienteEditar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb995be01de6f8f3164ccd0aa291acc6b3e81a06"
// <auto-generated/>
#pragma warning disable 1591
namespace ApiTurnero.WebApi.Client.Pages.Cliente
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lucas\Desktop\programacion\programacion\ApiTurnero\ApiTurnero.WebApi\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lucas\Desktop\programacion\programacion\ApiTurnero\ApiTurnero.WebApi\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lucas\Desktop\programacion\programacion\ApiTurnero\ApiTurnero.WebApi\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lucas\Desktop\programacion\programacion\ApiTurnero\ApiTurnero.WebApi\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lucas\Desktop\programacion\programacion\ApiTurnero\ApiTurnero.WebApi\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lucas\Desktop\programacion\programacion\ApiTurnero\ApiTurnero.WebApi\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lucas\Desktop\programacion\programacion\ApiTurnero\ApiTurnero.WebApi\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lucas\Desktop\programacion\programacion\ApiTurnero\ApiTurnero.WebApi\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lucas\Desktop\programacion\programacion\ApiTurnero\ApiTurnero.WebApi\Client\_Imports.razor"
using ApiTurnero.WebApi.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lucas\Desktop\programacion\programacion\ApiTurnero\ApiTurnero.WebApi\Client\_Imports.razor"
using ApiTurnero.WebApi.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lucas\Desktop\programacion\programacion\ApiTurnero\ApiTurnero.WebApi\Client\_Imports.razor"
using ApiTurnero.WebApi.Client.Pages.Cliente;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lucas\Desktop\programacion\programacion\ApiTurnero\ApiTurnero.WebApi\Client\_Imports.razor"
using ApiTurnero.WebApi.Comunes.Data.Entidades;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/clientes/editar/{ClienteId:int}/{nombre}/{apellido}/{telefono}")]
    public partial class ClienteEditar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Modificar Cliente</h2>\r\n");
            __builder.OpenComponent<ApiTurnero.WebApi.Client.Pages.Cliente.ClienteFormulario>(1);
            __builder.AddAttribute(2, "onValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 5 "C:\Users\Lucas\Desktop\programacion\programacion\ApiTurnero\ApiTurnero.WebApi\Client\Pages\Cliente\ClienteEditar.razor"
                                  GrabarModificacion

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "Cliente", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ApiTurnero.WebApi.Comunes.Data.Entidades.Cliente>(
#nullable restore
#line 5 "C:\Users\Lucas\Desktop\programacion\programacion\ApiTurnero\ApiTurnero.WebApi\Client\Pages\Cliente\ClienteEditar.razor"
                                                                cliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 5 "C:\Users\Lucas\Desktop\programacion\programacion\ApiTurnero\ApiTurnero.WebApi\Client\Pages\Cliente\ClienteEditar.razor"
                                                                                    Cancelar

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\Lucas\Desktop\programacion\programacion\ApiTurnero\ApiTurnero.WebApi\Client\Pages\Cliente\ClienteEditar.razor"
       
    private Cliente cliente;
    [Parameter] public int ClienteId { get; set; }
    [Parameter] public string nombre { get; set; }
    [Parameter] public string apellido { get; set; }
    [Parameter] public string telefono { get; set; }

    protected async override Task OnInitializedAsync()
    {
        cliente = new()
        {
            Id = ClienteId,
            Nombre = nombre,
            Apellido = apellido,

        };
    }
    private async Task GrabarModificacion()
    {
        Console.WriteLine($"Graba modificacion{cliente.Nombre}");
        navigationManager.NavigateTo("/clientes");
    }
    private async Task Cancelar()
    {
        navigationManager.NavigateTo("/clientes");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
