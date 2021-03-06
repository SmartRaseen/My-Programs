private async Task<string> GenerateHtmlReport()
        {
            double disclosure = CCPAResultInfo.Where(e => e.CategoryId == 1).Select(e => e.Score).FirstOrDefault();
            double consumerRightsAndRequestsScore = CCPAResultInfo.Where(e => e.CategoryId == 2).Select(e => e.Score).FirstOrDefault();
            double riskAssessmentScore = CCPAResultInfo.Where(e => e.CategoryId == 3).Select(e => e.Score).FirstOrDefault();
            double riskMitigationInformationSecurityScore = CCPAResultInfo.Where(e => e.CategoryId == 4).Select(e => e.Score).FirstOrDefault();
            CCPAReadinessScore = disclosure + consumerRightsAndRequestsScore + riskAssessmentScore + riskMitigationInformationSecurityScore;
            CCPAReadinessScore = CCPAReadinessScore / 4;
            CCPAReadinessScore = (double)Math.Round(CCPAReadinessScore, 2);
            var disclosureRecommendations = CCPAResultInfo.Where(e => e.CategoryId == 1).Select(e => e.Recommendation);
            var consumerRightsAndRequestsRecommendations = CCPAResultInfo.Where(e => e.CategoryId == 2).Select(e => e.Recommendation);
            var riskAssessmentRecommendations = CCPAResultInfo.Where(e => e.CategoryId == 3).Select(e => e.Recommendation);
            var riskMitigationInformationSecurityRecommendations = CCPAResultInfo.Where(e => e.CategoryId == 4).Select(e => e.Recommendation);
            string disclosureRecommendation = string.Empty, consumerRightsAndRequestsRecommendation = string.Empty, riskAssessmentRecommendation = string.Empty, riskMitigationInformationSecurityRecommendation = string.Empty;

            foreach (var recommendation in disclosureRecommendations)
            {
                disclosureRecommendation += "<li>" + recommendation + "</li>";
            }

            foreach (var recommendation in consumerRightsAndRequestsRecommendations)
            {
                consumerRightsAndRequestsRecommendation += "<li>" + recommendation + "</li>";
            }

            foreach (var recommendation in riskAssessmentRecommendations)
            {
                riskAssessmentRecommendation += "<li>" + recommendation + "</li>";
            }

            foreach (var recommendation in riskMitigationInformationSecurityRecommendations)
            {
                riskMitigationInformationSecurityRecommendation += "<li>" + recommendation + "</li>";
            }

            var ccpaReport = await FileUploadService.GetHtmlTemplateForCCPAAssessment();

            ccpaReport = ccpaReport
                .Replace("##SURVEY_NAME##", State.SurveyUserName)
                .Replace("##SURVEY_COMPANY##", State.SurveyUserCompany)
                .Replace("##SURVEY_Date##", DateTime.Now.ToString("MM/dd/yyyy"))
                .Replace("###OverallScore###", CCPAReadinessScore.ToString())
                .Replace("###DisclosureScore###", disclosure.ToString())
                .Replace("###ConsumerRightsAndRequestsScore###", consumerRightsAndRequestsScore.ToString())
                .Replace("###RiskAssessmentScore###", riskAssessmentScore.ToString())
                .Replace("###RiskMitigationInformationSecurityScore###", riskMitigationInformationSecurityScore.ToString())
                .Replace("###DisclosureColor###", GetCCPACategoryColor(disclosure))
                .Replace("###ConsumerRightsAndRequestsColor###", GetCCPACategoryColor(consumerRightsAndRequestsScore))
                .Replace("###RiskAssessmentColor###", GetCCPACategoryColor(riskAssessmentScore))
                .Replace("###RiskMitigationInformationSecurityColor###", GetCCPACategoryColor(riskMitigationInformationSecurityScore))
                .Replace("###OverallColor###", GetCCPACategoryColor(CCPAReadinessScore))
                .Replace("###DisclosureRecommendations###", disclosureRecommendation)
                .Replace("###ConsumerRightsandRequestsRecommendations###", consumerRightsAndRequestsRecommendation)
                .Replace("###RiskAssessmentRecommendations###", riskAssessmentRecommendation)
                .Replace("###RiskMitigationInformationSecurityRecommendations###", riskMitigationInformationSecurityRecommendation);

            return await FileUploadService.SaveCCPAAssessmentReport(ccpaReport);
        }
		
-----------------------------------------------------------------------------------------------------------------------------------------------		
		
using System;
using System.Threading.Tasks;
using BlazorInputFile;

namespace MSSurvey.Service
{
    internal interface IFileUploadService
    {
        Task<string> UploadImage(IFileListEntry fileEntry, string previousFileName, bool overwrite = true);

        Task UploadHtmlTemplate(IFileListEntry fileEntry, string templateFileName);

        Task UpdateHtmlTemplate(string fileContent, string templateFileName);

        Task<string> GetHtmlTemplate(string templateFileName);

        Task<string> GetHtmlTemplateForRetailAssessment();

        Task<string> GetHtmlTemplateForTeamsAssessment();

        Task<string> GetHtmlTemplateForCCPAAssessment();

        Task<Tuple<string, string>> SaveHtmlReport(string htmlContent);

        Task<string> SaveRetailAssessmentReport(string htmlContent);

        Task<string> SaveTeamsAssessmentReport(string htmlContent);

        Task<string> SaveCCPAAssessmentReport(string htmlContent);
    }
}

---------------------------------------------------------------------------------------------------------------------------------------------

// <copyright file="FileUploadService.cs" company="VueData">
// Copyright (c) VueData. All rights reserved.
// </copyright>

using System;
using System.IO;
using System.Threading.Tasks;
using BlazorInputFile;
using Microsoft.Extensions.Hosting;
using MSSurvey.Utility;

namespace MSSurvey.Service
{
    public class FileUploadService : IFileUploadService
    {
        private const string RootFolder = @"wwwroot";
        private const string ReportFolder = @"reports";
        private const string RetailAssessmentReportFolder = @"reports\d365\retail";
        private const string TeamsAssessmentReportFolder = @"reports\teams";
        private const string CCPAAssessmentReportFolder = @"reports\ccpa";
        private const string ImageRelativePath = @"wwwroot\images";
        private const string TemplateRelativePath = @"wwwroot\templates";
        private const string RetailTemplateRelativePath = @"wwwroot\templates\d365\retail\retail_template_1.html";
        private const string TeamsTemplateRelativePath = @"wwwroot\templates\teams\template.html";
        private const string CCPATemplateRelativePath = @"wwwroot\templates\ccpa\template.html";

        private readonly string imageDirectory;
        private readonly string reportDirectory;
        private readonly string templateDirectory;
        private readonly string retailTemplateDirectory;
        private readonly string teamsTemplateDirectory;
        private readonly string retailAssessmentReportDirectory;
        private readonly string teamsAssessmentReportDirectory;
        private readonly string ccpaAssessmentReportDirectory;
        private readonly string ccpaTemplateDirectory;

        public FileUploadService(IHostEnvironment environment)
        {
            imageDirectory = Path.Combine(environment.ContentRootPath, ImageRelativePath);
            retailTemplateDirectory = Path.Combine(environment.ContentRootPath, RetailTemplateRelativePath);
            teamsTemplateDirectory = Path.Combine(environment.ContentRootPath, TeamsTemplateRelativePath);
            ccpaTemplateDirectory = Path.Combine(environment.ContentRootPath, CCPATemplateRelativePath);
            retailAssessmentReportDirectory = Path.Combine(environment.ContentRootPath, RootFolder, RetailAssessmentReportFolder);
            teamsAssessmentReportDirectory = Path.Combine(environment.ContentRootPath, RootFolder, TeamsAssessmentReportFolder);
            ccpaAssessmentReportDirectory = Path.Combine(environment.ContentRootPath, RootFolder, CCPAAssessmentReportFolder);

            if (!Directory.Exists(retailAssessmentReportDirectory))
            {
                Directory.CreateDirectory(retailAssessmentReportDirectory);
            }

            if (!Directory.Exists(teamsAssessmentReportDirectory))
            {
                Directory.CreateDirectory(teamsAssessmentReportDirectory);
            }

            if (!Directory.Exists(ccpaAssessmentReportDirectory))
            {
                Directory.CreateDirectory(ccpaAssessmentReportDirectory);
            }

            reportDirectory = Path.Combine(environment.ContentRootPath, RootFolder, ReportFolder);
            if (!Directory.Exists(reportDirectory))
            {
                Directory.CreateDirectory(reportDirectory);
            }

            templateDirectory = Path.Combine(environment.ContentRootPath, TemplateRelativePath);
            if (!Directory.Exists(templateDirectory))
            {
                Directory.CreateDirectory(templateDirectory);
            }
        }

        /// <summary>
        /// Upload the image file to disk and returns the name
        /// </summary>
        /// <param name="fileEntry">Uploaded Image file</param>
        /// <param name="previousFileName">Previous file name</param>
        /// <param name="overwrite">Overwrite previous file</param>
        /// <returns>Returns image path</returns>
        public async Task<string> UploadImage(IFileListEntry fileEntry, string previousFileName, bool overwrite = true)
        {
            // check for previous file
            if (overwrite && !string.IsNullOrWhiteSpace(previousFileName))
            {
                var previousFile = Path.Combine(imageDirectory, previousFileName);
                if (File.Exists(previousFile))
                {
                    File.Delete(previousFile);
                }
            }

            // get file name and file path to be saved to disk
            var filename = Extensions.GetFileName(fileEntry.Name);
            var destinationPath = Path.Combine(imageDirectory, filename);

            // write to image to disk
            await WriteToFile(fileEntry, destinationPath);

            // return generated file name
            return filename;
        }

        /// <summary>
        /// Upload the html template file to disk and returns the content in string
        /// </summary>
        /// <param name="fileEntry">Uploaded Html file</param>
        /// <param name="templateFileName">Html template file name</param>
        /// <returns>Html file content</returns>
        public async Task UploadHtmlTemplate(IFileListEntry fileEntry, string templateFileName)
        {
            var destinationPath = Path.Combine(templateDirectory, templateFileName);
            await WriteToFile(fileEntry, destinationPath);
        }

        /// <summary>
        /// Update the html template file to disk
        /// </summary>
        /// <param name="fileContent">Html template content</param>
        /// <param name="templateFileName">Html template file name</param>
        public async Task UpdateHtmlTemplate(string fileContent, string templateFileName)
        {
            var destinationPath = Path.Combine(templateDirectory, templateFileName);
            await File.WriteAllTextAsync(destinationPath, fileContent);
        }

        /// <summary>
        /// Get the html template content from disk using template file name
        /// </summary>
        /// <param name="templateFileName">Html Template File saved in DB</param>
        /// <returns>Html template path</returns>
        public async Task<string> GetHtmlTemplate(string templateFileName)
        {
            var destinationPath = Path.Combine(templateDirectory, templateFileName);
            if (!File.Exists(destinationPath))
            {
                return null;
            }

            return await File.ReadAllTextAsync(destinationPath);
        }

        /// <summary>
        /// Saves the generated html report to disk
        /// Saves the pdf view html report to disk
        /// </summary>
        /// <param name="htmlContent">html string</param>
        /// <returns>Relative path of report html</returns>
        public async Task<Tuple<string, string>> SaveHtmlReport(string htmlContent)
        {
            var htmlRelativePath = Extensions.GetFileName(Extensions.FileExtension.Html);
            var htmlPdfRelativePath = $"{Path.GetFileNameWithoutExtension(htmlRelativePath)}_pdf.html";

            var htmlDiskReportPath = Path.Combine(reportDirectory, htmlRelativePath);
            var htmlPdfDiskReportPath = Path.Combine(reportDirectory, htmlPdfRelativePath);

            // save the html file
            await File.WriteAllTextAsync(htmlDiskReportPath, htmlContent);

            // hide view part for document generation
            // TODO: apply generic solution
            var htmlToConvert = htmlContent.Replace("class=\"ms-download\"", "class=\"d-none\"");
            htmlToConvert = htmlToConvert.Replace("class=\"ms-view-port\"", "class=\"ms-view-port--disabled\"");
            htmlToConvert = htmlToConvert.Replace("doAnimatePercent = 'do-animate-percent'", "doAnimatePercent = 'false'");
            htmlToConvert = htmlToConvert.Replace("class=\"ms-scenario-cards\"", "class=\"d-none\"");
            htmlToConvert = htmlToConvert.Replace("class=\"pdf-view d-none\"", "class=\"pdf-view \"");

            // save the report view html to convert to pdf
            await File.WriteAllTextAsync(htmlPdfDiskReportPath, htmlToConvert);

            // initiate download request
            var urlToConvert = $"/{ReportFolder}/{htmlPdfRelativePath}";
            var urlToLoadRelative = $"{ReportFolder}/{htmlRelativePath}";

            // return html relative path to load in browser
            return new Tuple<string, string>(urlToLoadRelative, urlToConvert);
        }

        public async Task<string> SaveRetailAssessmentReport(string htmlContent)
        {
            var htmlRelativePath = Extensions.GetFileName(Extensions.FileExtension.Html);
            var htmlDiskReportPath = Path.Combine(retailAssessmentReportDirectory, htmlRelativePath);
            await File.WriteAllTextAsync(htmlDiskReportPath, htmlContent);
            return Path.Combine(RetailAssessmentReportFolder, htmlRelativePath);
        }

        public async Task<string> SaveTeamsAssessmentReport(string htmlContent)
        {
            var htmlRelativePath = Extensions.GetFileName(Extensions.FileExtension.Html);
            var htmlDiskReportPath = Path.Combine(teamsAssessmentReportDirectory, htmlRelativePath);
            await File.WriteAllTextAsync(htmlDiskReportPath, htmlContent);
            return Path.Combine(TeamsAssessmentReportFolder, htmlRelativePath);
        }

        public async Task<string> SaveCCPAAssessmentReport(string htmlContent)
        {
            var htmlRelativePath = Extensions.GetFileName(Extensions.FileExtension.Html);
            var htmlDiskReportPath = Path.Combine(ccpaAssessmentReportDirectory, htmlRelativePath);
            await File.WriteAllTextAsync(htmlDiskReportPath, htmlContent);
            return Path.Combine(CCPAAssessmentReportFolder, htmlRelativePath);
        }

        public async Task<string> GetHtmlTemplateForRetailAssessment()
        {
            return await File.ReadAllTextAsync(retailTemplateDirectory);
        }

        public async Task<string> GetHtmlTemplateForTeamsAssessment()
        {
            return await File.ReadAllTextAsync(teamsTemplateDirectory);
        }

        public async Task<string> GetHtmlTemplateForCCPAAssessment()
        {
            return await File.ReadAllTextAsync(ccpaTemplateDirectory);
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
