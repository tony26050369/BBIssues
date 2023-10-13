using global::System;
using global::System.Collections.Generic;
using global::System.Linq;
using global::System.Threading.Tasks;
using global::Microsoft.AspNetCore.Components;
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

namespace BBIssues1.Shared.Pages
{
    public partial class InputNumberDemo
    {
        private StruReq Req { get; set; } = new();
        private class StruReq
        {
            public decimal InputValue { get; set; }
        }
        
    }
}