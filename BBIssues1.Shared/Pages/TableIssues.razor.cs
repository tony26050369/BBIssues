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

namespace BBIssues1.Shared.Pages
{
    public partial class TableIssues
    {
        private List<StruTest> TestList { get; set; } = new()
        {new StruTest{Value1 = 10}, new StruTest{Value1 = 20}};
        private class StruTest
        {
            public int Value1 { get; set; } = 10;
            public int AutoValue
            {
                get
                {
                    return Value1 * 10;
                }
            }
        }
    }
}