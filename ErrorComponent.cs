
Error Component
***************

Things need to cover
********************

[CascadingParameter(Name = "ErrorComponent")]
private IErrorComponent ErrorComponent { get; set; }


// <copyright file="IErrorComponent.cs" company="VueData">
// Copyright (c) VueData. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMSPortal.Data
{
    public interface IErrorComponent
    {
        void ShowError(string title, string message);
    }
}

------------------------------------------------------------------------------------

MainLayout.Razor
****************

    @if (IsErrorActive)
    {
        <div class="alert alert-danger" role="alert" style="z-index:3">
            <button type="button" class="close" data-dismiss="alert" aria-label="Close" @onclick="HideError">
                <span aria-hidden="true">&times;</span>
            </button>
            <h3>@Title</h3>
            <p>@Message</p>
        </div>
    }
    else
    {
        <div class="content px-4">
            <CascadingValue Value="this" Name="ErrorComponent">
                @Body
            </CascadingValue>
        </div>
    }

MainLayout.Razor.cs
*******************

void IErrorComponent.ShowError(string title, string message)
        {
            IsErrorActive = true;
            Title = title;
            Message = message;
            StateHasChanged();
        }
		
------------------------------------------------------------------------------------------------------------------------------------


Change things in all pages
**************************

try
{
	Code...
}
catch (Exception ex)
{
    ErrorComponent.ShowError(ex.Message, ex.StackTrace);
}