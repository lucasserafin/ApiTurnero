// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ApiTurnero.WebApi.Client.Shared
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
    public partial class Confirmacion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Lucas\Desktop\programacion\programacion\ApiTurnero\ApiTurnero.WebApi\Client\Shared\Confirmacion.razor"
        private bool MostrarConfirmacion = false;
            [Parameter] public bool verCancelar { get; set; } = true;
            [Parameter] public bool verOk { get; set; } = true;
            [Parameter] public string textCancelar { get; set; } = "Cancelar";
            [Parameter] public string textOk { get; set; } = "Ok";
            [Parameter] public string Titulo { get; set; } = "Confirmación";
            [Parameter] public EventCallback onConfirm { get; set; }
            [Parameter] public EventCallback onCancel { get; set; }
            [Parameter] public RenderFragment ChildContent { get; set; }

            public void Mostrar() => MostrarConfirmacion = true;

            public void Ocultar() => MostrarConfirmacion = false;
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591