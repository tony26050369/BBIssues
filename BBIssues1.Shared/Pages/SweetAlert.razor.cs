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
using System.Diagnostics.CodeAnalysis;

namespace BBIssues1.Shared.Pages
{
    public partial class SweetAlert
    {
        [Inject,NotNull]
        private SwalService? ss { get; set; }
        [NotNull]
        private Modal? Modal1 { get; set; }
        private async Task ShowSS()
        {
            var op = new SwalOption()
            {
                Title = "测试",
                Content = "2秒后应该通过后台代码关闭",
                ShowClose = false
            };

            ss?.Show(op);

            await Task.Delay(2000);

            await op.CloseAsync();
        }
    }
}