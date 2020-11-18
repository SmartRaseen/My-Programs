

	Copy URL
	********
	
	[Inject] private NavigationManager NavigationMgr { get; set; }
	Using TextCopy;
	
	
	*	Clipboard.SetText(NavigationMgr.BaseUri + "userdetails?Id=" + surveyId);
	
----------------------------------------------------------------------------------------------------------


	Upload Files in Blazor C#
	*************************

	[Inject] IFileUpload FileUpload { get; set; }
	
	public IFileListEntry SubDescriptionIcon { get; set; }
	
	<label class="col-form-label" style="display:flex;">
        <span style="min-width: 180px; margin-right:20px;">SubDescription Icon :</span>

        @if (Survey.SubDescriptionIcon != null)
        {
            <input type="text" class="form-control" @bind="Survey.SubDescriptionIcon" style="min-width: 180px;" disabled />
        }

        <label class="mb-0 btn btn-primary hide-upload-font">
            @(Survey.SubDescriptionIcon == null ? "Add" : "Change")
            <InputFile OnChange="SelectSubDescriptionIcon" class="hide-upload" required="@(Survey.SubDescriptionIcon == null)" accept="image/*" />
        </label>
    </label>

	@{
        if (SubDescriptionIcon != null)
        {
            Survey.SubDescriptionIcon = SubDescriptionIcon.Name;
        }
     }

	protected async Task SelectSubDescriptionIcon(IFileListEntry[] files)
    {
        SubDescriptionIcon = files.FirstOrDefault();
        if (SubDescriptionIcon != null)
        {
            await FileUpload.UploadSubDescriptionAsync(SubDescriptionIcon);
        }
    }
	
	
	IFileUpload.cs
	**************
	
	interface IFileUpload
    {
        Task UploadSubDescriptionAsync(IFileListEntry file);
    }
	
	FileUpload.cs
	*************
	public class FileUpload : IFileUpload
	{
	
		private readonly IWebHostEnvironment _environment;
		
		public async Task UploadSubDescriptionAsync(IFileListEntry fileEntry)
        {
            var destinationPath = Path.Combine(_environment.ContentRootPath, "wwwroot\\images\\Sub Description", fileEntry.Name);
            var memoryStream = new MemoryStream();
            await fileEntry.Data.CopyToAsync(memoryStream);

            using (FileStream file = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
            {
                memoryStream.WriteTo(file);
            }
        }
	}
	


