using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using BootstrapBlazor.Components;
using BBIssues1.Shared.Data;
using BBIssues1.Shared.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.Localization;
using Microsoft.JSInterop;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;

namespace BBIssues1.Shared.Pages
{
    public partial class DsIssues
    {
        [Inject,NotNull]
        private DialogService? Ds { get; set; }
        private async Task ShowDs()
        {
            await Ds.Show(new()
            {
                Title = "≤‚ ‘",
                Component = BootstrapDynamicComponent.CreateComponent<DsDemo>()
            });
        }
    }
}