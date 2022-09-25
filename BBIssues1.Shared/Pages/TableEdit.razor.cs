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
using Microsoft.EntityFrameworkCore;

namespace BBIssues1.Shared.Pages
{
    public partial class TableEdit
    {
        //private List<TodoItem> TodoItems { get; set; } = new();
        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                SetupData();
            }
        }

        private void SetupData()
        {
            using var db = new TodoContext();
            db.TodoItems.Add(new TodoItem
            {
                Id = 1,
                IsComplete = true,
                Name = "Tony",
                Secret = String.Empty
            });

            db.SaveChanges();
        }

        private async Task<QueryData<TodoItem>> GetItems(QueryPageOptions opt)
        {
            using var db = new TodoContext();

            var list = await db.TodoItems.ToListAsync();

            return new QueryData<TodoItem>
            {
                Items = list
            };
        }
        private async Task<bool> SaveEditedItem(TodoItem item, ItemChangedType changeType)
        {
            using var db = new TodoContext();

            db.Entry(item).State = EntityState.Modified;

            await db.SaveChangesAsync();
            return true;
        }
    }
}