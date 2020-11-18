<div class="d-flex col-md-12 mb-3">
                        @if (@HelpDeskInfo.Attachment != null)
                        {
                            <span class="f-12" style="color:#272773">@HelpDeskInfo.Attachment</span>
                        }
                        else
                        {
                            <label>
                                <i class="fa fa-paperclip">Attachment </i>
                                <InputFile OnChange="UploadAttachment" class="hide-upload" accept="*" />
                            </label>

                        }
                    </div>

protected async Task UploadAttachment(IEnumerable<IFileListEntry> files)
        {
            try
            {
                ShowLoader = true;
                AttachmentFile = files.FirstOrDefault();
                if (AttachmentFile != null)
                {
                    HelpDeskInfo.Attachment = AttachmentFile.Name;
                    HelpDeskInfo.AttachmentFileName = EMSExtension.GetFileName(AttachmentFile.Name);
                    await FileService.UploadAttachment(AttachmentFile, HelpDeskInfo.AttachmentFileName);
                }

                ShowLoader = false;
            }
            catch (Exception ex)
            {
                ErrorComponent.ShowError(ex.Message, ex.StackTrace);
            }
        }
		
protected async Task DownloadAttachment()
        {
            try
            {
                var data = await FileService.DownloadAttachment(HelpDeskInfo.AttachmentFileName);
                await JsRuntime.InvokeAsync<object>(
                                    "saveAsFile",
                                    HelpDeskInfo.Attachment,
                                    Convert.ToBase64String(data));
            }
            catch (Exception ex)
            {
                ErrorComponent.ShowError(ex.Message, ex.StackTrace);
            }
        }
		
namespace BlazorInputFile

protected IFileListEntry AttachmentFile { get; set; }

[Inject]
protected IFileService FileService { get; set; }

------------------------------------------------------------------------------

Javascript
**********

function saveAsFile(filename, bytesBase64) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:application/octet-stream;base64," + bytesBase64;
    document.body.appendChild(link); // Needed for Firefox
    link.click();
    document.body.removeChild(link);
}


------------------------------------------------------------------------------

// <copyright file="IFileService.cs" company="VueData">
// Copyright (c) VueData. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorInputFile;

namespace EMSPortal.Services
{
    public interface IFileService
    {
        Task UploadAttachment(IFileListEntry fileEntry, string templateFileName);

        Task<byte[]> DownloadAttachment(string fileName);
    }
}

------------------------------------------------------------------------------

// <copyright file="FileService.cs" company="VueData">
// Copyright (c) VueData. All rights reserved.
// </copyright>

using System;
using System.IO;
using System.Threading.Tasks;
using BlazorInputFile;
using Microsoft.Extensions.Hosting;

namespace EMSPortal.Services
{
    public class FileService : IFileService
    {
        private const string AttachmentsDirectory = @"wwwroot\attachments";

        private readonly string attachmentsDirectory;

        public FileService(IHostEnvironment environment)
        {
            attachmentsDirectory = Path.Combine(environment.ContentRootPath, AttachmentsDirectory);
            if (!Directory.Exists(attachmentsDirectory))
            {
                Directory.CreateDirectory(attachmentsDirectory);
            }
        }

        public async Task UploadAttachment(IFileListEntry fileEntry, string attachmentsFileName)
        {
            var destinationPath = Path.Combine(attachmentsDirectory, attachmentsFileName);
            await WriteToFile(fileEntry, destinationPath);
        }

        public async Task<byte[]> DownloadAttachment(string fileName)
        {
            var filePath = Path.Combine(attachmentsDirectory, fileName);
            return await File.ReadAllBytesAsync(filePath);
        }

        private static async Task WriteToFile(IFileListEntry fileEntry, string destinationPath)
        {
            var memoryStream = new MemoryStream();
            await fileEntry.Data.CopyToAsync(memoryStream);

            await using var file = new FileStream(destinationPath, FileMode.Create, FileAccess.Write);
            memoryStream.WriteTo(file);
        }
    }
}


------------------------------------------------------------------------------