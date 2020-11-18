
MyTeam with SearchBar
*********************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMSPortal.Services;
using EMSPortal.Models;
using EMSPortal.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Components;

namespace EMSPortal.Pages
{
    public class MyTeamBase : ComponentBase
    {
        [Inject] protected SessionState SessionState { get; set; }
        protected EMSService emsSvc;
        public string SearchTerm { get; set; } = "";
        public List<Users> DBList { get; set; }
        public List<Users> MyTeam => DBList.FindAll(e => e.EmployeeId.ToLower().Contains(SearchTerm.ToLower()) || e.DisplayName.ToLower().Contains(SearchTerm.ToLower())).ToList();
        public bool ShowUsersList = true;
        public bool ShowUserTimeSheet = false;
        public long[] SubmittedWeekIds { get; set; }
        public long CurrentSubmittedWeekId { get; set; }
        public List<TimeSheetInfo> UserTimesheets { get; set; }
        public TimeSheetInfo UserSelectedTimesheet { get; set; }

        protected override void OnInitialized()
        {
            emsSvc = new EMSService();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (SessionState.IsAuthenticated && firstRender)
            {
                DBList = await emsSvc.GetUsersUnderLead(SessionState.UserId);
                DBList.Distinct();
                StateHasChanged();
            }
        }

        protected void ViewTimesheet(long userId)
        {
            ShowUsersList = false;
            ShowUserTimeSheet = true;
            SubmittedWeekIds = emsSvc.GetSubmittedWeekIdsForUser(userId);
            if (SubmittedWeekIds.Count() != 0)
            {
                UserTimesheets = emsSvc.GetTimeSheetForUser(userId).Where(e => e.TimeSheetSubmitStatus == TimeSheetSubmitStatus.Approved).ToList();
                CurrentSubmittedWeekId = SubmittedWeekIds.Max();
                UserSelectedTimesheet = UserTimesheets.Where(e => e.WeekId == CurrentSubmittedWeekId).FirstOrDefault();
            }
        }

        protected void CloseTimesheet()
        {
            ShowUsersList = true;
            ShowUserTimeSheet = false;
        }

        protected void NextTimesheet()
        {
            CurrentSubmittedWeekId++;
            UserSelectedTimesheet = UserTimesheets.Where(e => e.WeekId == CurrentSubmittedWeekId).FirstOrDefault();
        }

        protected void PreviousTimesheet()
        {
            CurrentSubmittedWeekId--;
            UserSelectedTimesheet = UserTimesheets.Where(e => e.WeekId == CurrentSubmittedWeekId).FirstOrDefault();
        }
    }
}



@page "/myteam"

@using EMSPortal.Data
@inherits MyTeamBase
@inject EMSPortal.Data.SessionState state
@inject NavigationManager navigationManager

<h3>My Teams</h3>

@if (SessionState.IsAuthenticated)
{
    @if (DBList == null)
    {
        <div class="loader"></div>
    }
    else
    {
        @if (ShowUsersList)
        {
            <form class="form-inline mb-3">
                <input class="form-control form-control-sm search-box" type="text" placeholder="Name or ID" aria-label="Search" @bind-value="SearchTerm" @bind-value:event="oninput" />
            </form>
            <table class="table desktop-only table-striped">
                <thead>
                    <tr>
                        <th>Employee Id</th>
                        <th>User Name</th>
                        <th>Email</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    @foreach (var user in MyTeam.Where(e => e.Id != SessionState.UserId))
                    {
                        <tr>
                            <td>@user.EmployeeId</td>
                            <td>@user.DisplayName</td>
                            <td>@user.Email</td>
                            <td>
                                <button @onclick="()=> ViewTimesheet(user.Id)" class="btn full" title="Show @user.Username'TimeSheet">TimeSheet</button>
                            </td>
                        </tr>
                    }
                </tbody>
            </table>

            <div class="non-desktop mt-5">
                @foreach (var user in MyTeam)
                {
                    <div class="user-table">
                        <div class="badge mob-user-name">Employee Id:@user.EmployeeId</div>
                        <table>
                            <tr>
                                <td>Display Name</td>
                                <td>@user.DisplayName</td>
                            </tr>
                            <tr>
                                <td>Email</td>
                                <td class="user-email">@user.Email</td>
                            </tr>
                        </table>
                        <div class="action-button">
                            <div>
                                <button @onclick="()=> ViewTimesheet(user.Id)" class="btn full m-1" title="Show @user.Username'TimeSheet">TimeSheet</button>
                            </div>
                        </div>
                    </div>

                }
            </div>
        }

        @if (ShowUserTimeSheet)
        {
            @if (UserTimesheets != null)
            {
                <div class="currentdate">
                    @if (CurrentSubmittedWeekId == SubmittedWeekIds.Min())
                    {
                        <a class="prev" style="color:white; background-color: #C4BEBD; margin-top:40px;" disabled>&#10094;</a>
                    }
                    else
                    {
                        <a class="prev" style="color:white; background-color: #514496; margin-top:40px;" title="Previous TimeSheet " @onclick="PreviousTimesheet">&#10094;</a>
                    }

                    <h5 class="start-time"> @UserSelectedTimesheet.TimeSheetWeekDays[0].Date.ToString("dd-MMM-yyyy") &ensp;-&ensp; @UserSelectedTimesheet.TimeSheetWeekDays[4].Date.ToString("dd-MMM-yyyy")</h5>

                    @if (CurrentSubmittedWeekId == SubmittedWeekIds.Max())
                    {
                        <a class="next" style="color:white; background-color:#C4BEBD; margin-top:40px;" disabled>&#10095;</a>
                    }
                    else
                    {
                        <a class="next" style="color: white; background-color: #514496; margin-top:40px;" title="Next TimeSheet" @onclick="NextTimesheet">&#10095;</a>
                    }
                </div>
                <br>
                <br>
                <div class="timesheet">
                    <table class="table table-bordered">
                        <thead>
                            <tr>
                                <th scope="col">
                                    <div class="task-heading">
                                        <div>
                                            <span>Task Type</span>
                                        </div>
                                    </div>
                                </th>
                                @foreach (var dayOfTheWeek in UserSelectedTimesheet.TimeSheetWeekDays)
                                {
                                    if (dayOfTheWeek.IsHoliday)
                                    {
                                        <th scope="col"><div class="task-heading-col"><span class="day">@dayOfTheWeek.DDD</span><span class="date"></span></div></th>
                                    }
                                    else
                                    {
                                        <th scope="col"><div class="task-heading-col"><span class="day">@dayOfTheWeek.DDD</span><span class="date">@dayOfTheWeek.Day</span></div></th>
                                    }
                                }

                                <th scope="col"><div class="task-heading"><span>Total</span></div></th>
                            </tr>
                        </thead>
                        @foreach (var tasks in UserSelectedTimesheet.Tasks)
                        {
                            <tr>
                                <td>@tasks.TaskName</td>
                                @foreach (var day in tasks.DayTaskInfo.OrderBy(e => e.Date))
                                {
                                    <td class="resize">
                                        <div class="lastweektask-detail">
                                            @if (day.TimeFrame != "0:00")
                                            {
                                                <div class="card" style="height:6rem;">
                                                    <div class="card-body">
                                                        <p class="card-text" style="font-size:12px; line-height:16px;"><strong>@day.TimeFrame</strong> @day.TaskDetail</p>
                                                    </div>
                                                </div>
                                            }
                                            else if (day.TimeFrame != "0:00" && day.TaskDetail != null)
                                            {
                                                <div class="card" style="height:6rem;">
                                                    <div class="card-body">
                                                        <p class="card-text" style="font-size:12px; line-height:16px;"><strong>@day.TimeFrame</strong> Task not updated...</p>
                                                    </div>
                                                </div>
                                            }
                                            else
                                            {
                                                <div class="card" style="width: 8rem; height:6rem;">
                                                    <div class="card-body">
                                                        <p class="card-text" style="font-size:12px; line-height:16px">Task not updated...</p>
                                                    </div>
                                                </div>
                                            }
                                        </div>
                                    </td>
                                }
                                <td class="table-content"></td>
                                <td class="table-content"></td>
                                <td><strong>@tasks.TotalTimeSpentInWeekForTask</strong></td>
                            </tr>
                        }
                        <tr>
                            <th scope="row">
                                Total
                            </th>
                            @foreach (var totalTimeForDay in UserSelectedTimesheet.TotalTimeForDays)
                            {
                                <td>
                                    <strong>@totalTimeForDay</strong>
                                </td>
                            }
                            <td class="table-content"></td>
                            <td class="table-content"></td>
                            <td><strong>@UserSelectedTimesheet.TotalTimeForWeek</strong></td>
                        </tr>
                    </table>
                </div>
                <br />
                <button class="btn full" @onclick="CloseTimesheet">Back To List</button>
            }
            else
            {
                <br>
                <div style="display:flex;">
                    <button disabled style="cursor:default" class="btn-timesheet-status"></button>&nbsp&nbsp<h5><i>No Submitted TimeSheets for user</i></h5>
                </div>
                <br />
                <button class="btn full" @onclick="CloseTimesheet">Back To List</button>
            }
        }
    }
}
