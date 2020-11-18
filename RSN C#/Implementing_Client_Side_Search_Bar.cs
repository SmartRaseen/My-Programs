
	Implementing Client Side Search Bar
	***********************************

            <input @bind-value="SearchTerm" @bind-value:event="oninput" />

            <span class="text-muted ml-5">
                Showing @FilteredToDos.Count out of @ToDoItems.Count
            </span>

            <h4 class="mt-4">To Do's</h4>

            <ul>
                @foreach (var toDo in FilteredToDos)
                {
                    <li>@toDo.Name</li>
                }
            </ul>            			
		
        
        // Initialize SearchTerm to "" to prevent null's
        protected string SearchTerm { get; set; } = "";

        // Imagine this was retrieved from an API, just hardcoding for demo purposes
        protected List<ToDoItem> ToDoItems => new List<ToDoItem>
                {
                new ToDoItem { Name = "Garbage" },
                new ToDoItem { Name = "Dishes" },
                new ToDoItem { Name = "Wash clothes" },
                new ToDoItem { Name = "Water flowers" }
                };

        protected List<ToDoItem> FilteredToDos => ToDoItems.Where(i => i.Name.ToLower().Contains(SearchTerm.ToLower())).ToList();

        public class ToDoItem
        {
            public string Name;
        }
			
			@if (timesheet.Status == (int)TimeSheetSubmitStatus.Approved)
                                {
                                    <tr>
                                        <th scope="row">@number</th>
                                        <td>@emsSvc.GetUserById(timesheet.UserId).DisplayName</td>
                                        <td><button type="button" class="btn btn-primary" @onclick="(() => GetTimeSheet(timesheet.UserId, timesheet.Id,timesheet.Status))">TimeSheet</button></td>
                                        <td></td>
                                    </tr>
                                    number++;
                                }