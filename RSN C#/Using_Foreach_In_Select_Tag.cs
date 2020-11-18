
Select Tag Foreach Old
**********************

<select class="form-control" @bind="NewTaskTypeIdToBeAdded">
    @foreach (var newTask in UsersCurrentWeekNewTaskTypes)
    {
        <option value="@newTask.Value">
            @newTask.Text
        </option>
    }
</select>

protected int? NewTaskTypeIdToBeAdded { get; set; }

protected List<SelectListItem> UsersCurrentWeekNewTaskTypes;

UsersCurrentWeekNewTaskTypes = GetNewTaskTypesForCurrentWeek(SessionState.UserId);

public List<SelectListItem> GetNewTaskTypesForCurrentWeek(long userId)
{
    var selectList = new List<SelectListItem>();

    foreach (var taskType in emsSvc.GetNewTaskTypesForUser(currentWeekId, userId))
        selectList.Add(new SelectListItem { Text = taskType.TaskType1, Value = taskType.Id.ToString() });

    return selectList.OrderBy(e => e.Text).ToList();
}

public List<TaskType> GetNewTaskTypesForUser(long weekId, long userId)
{
    var result = objDataAccess.GetNewTaskTypesForUser(weekId, userId);
    if (result.Any())
        return result.ToList();
    return new List<TaskType>();
}

public List<TaskType> GetNewTaskTypesForUser(long weekId, long userId)
{
    try
    {
        var existingTaskTypeIds = db.TaskWeekAssociation.Where(e => e.UserId.Equals(userId) && e.WeekId.Equals(weekId)).Select(d => d.TaskTypeId).ToList();
        return existingTaskTypeIds.Any() ? db.TaskType.Where(e => !existingTaskTypeIds.Contains(e.Id)).ToList() : db.TaskType.ToList();
    }
    catch
    {
        throw;
    }
}


-------------------------------------------------------------------------------------------------------------------------------------------

Select Tag Foreach New
**********************

protected int SelectMember { get; set; }

protected List<SelectListItem> GetTheListOfAdmins;

GetTheListOfAdmins = GetTheListOfAvailableAdmins();

public List<SelectListItem> GetTheListOfAvailableAdmins()
{
    var selectList = new List<SelectListItem>();

    foreach (var admin in UserInfo)
	{
		if(admin.GroupId == 0)
		{
			selectList.Add(new SelectListItem { Text = admin.DisplayName, Value = admin.Id.ToString() });
		}
	}

    return selectList.OrderBy(e => e.Text).ToList();
}


<select class="form-control" @bind="SelectMember">
    @foreach (var admin in GetTheListOfAdmins)
    {
        <option value="@admin.Value">
            @admin.Text
        </option>
    }
</select>
