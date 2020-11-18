// <copyright file="D365AssessmentBase.razor.cs" company="VueData">
// Copyright (c) VueData. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MSSurvey.Data;
using MSSurvey.Service;
using MSSurvey.Utility;
using MSSurvey.ViewModel;

namespace MSSurvey.Pages
{
    public class D365AssessmentBase : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public SurfaceService SurfaceService { get; set; }

        [Inject]
        public IJSRuntime JsRuntime { get; set; }

        [Inject]
        protected SessionState State { get; set; }

        protected int CurrentSectionId { get; set; }

        protected int FirstSectionId { get; set; }

        protected int LastSectionId { get; set; }

        protected string CurrentSectionTitle { get; set; }

        protected string CurrentSectionHeader { get; set; }

        protected string CurrentSectionIcon { get; set; }

        protected bool ShowLoader { get; set; }

        protected bool ViewAssessment { get; set; }

        protected bool ViewManufacturingAssessment { get; set; }

        protected bool ViewRetailAssessment { get; set; }

        protected bool ViewedEmpowerEmployee { get; set; } = false;

        protected bool ViewedEngagedCustomersSuppliers { get; set; } = false;

        protected bool ViewedOptimizeSupplyChain { get; set; } = false;

        protected RetailAssessmentSection CurrentSection { get; set; }

        protected List<RetailAssessment> RetailAssessment { get; set; } = new List<RetailAssessment>();

        protected List<RetailAssessment> AllRetailAssessment { get; set; }

        protected List<RetailAssessmentInfo> EmpowerEmployee { get; set; } = new List<RetailAssessmentInfo>();

        protected List<RetailAssessmentInfo> EngagedCustomersSuppliers { get; set; } = new List<RetailAssessmentInfo>();

        protected List<RetailAssessmentInfo> OptimizeSupplyChain { get; set; } = new List<RetailAssessmentInfo>();

        private long AssessmentUserId { get; set; }

        [CascadingParameter(Name = "ErrorComponent")]
        private IErrorComponent ErrorComponent { get; set; }

        protected override void OnInitialized()
        {
            try
            {
                var uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
                AssessmentUserId = uri.GetQueryParam<int>("userId");
                if (AssessmentUserId == 0)
                {
                    NavigationManager.NavigateTo("teamhomepage");
                }
                else
                {
                    ViewAssessment = true;
                    AllRetailAssessment = SurfaceService.GetRetailAssessment();
                    RetailAssessment.AddRange(AllRetailAssessment);
                    RetailAssessment = RetailAssessment.Where(e => e.CategoryId == 1).ToList();
                    CurrentSectionTitle = RetailAssessmentSection.EmpowerEmployee.GetDescription();
                    CurrentSectionHeader = RetailAssessment.Select(e => e.SectionHeader).FirstOrDefault();
                    CurrentSectionIcon = RetailAssessment.Select(e => e.IconName).FirstOrDefault();
                    CurrentSection = RetailAssessmentSection.EmpowerEmployee;
                    CurrentSectionId = RetailAssessment.Select(e => e.CategoryId).FirstOrDefault();
                    FirstSectionId = CurrentSectionId;
                    LastSectionId = AllRetailAssessment.Select(e => e.CategoryId).LastOrDefault();
                    ViewedEmpowerEmployee = true;
                }
            }
            catch (Exception e)
            {
                if (AssessmentUserId != 0)
                {
                    ErrorComponent.ShowError(e.Message, e.StackTrace);
                }
            }
        }

        protected void StartAssessment(int assessmentId)
        {
            try
            {
                if (assessmentId == 1)
                {
                    ViewManufacturingAssessment = true;
                }
                else
                {
                    ViewRetailAssessment = true;
                }
            }
            catch (Exception e)
            {
                ErrorComponent.ShowError(e.Message, e.StackTrace);
            }
        }

        protected void NextSection()
        {
            try
            {
                UpdateSubmittedSection();
                CurrentSectionId++;
                RetailAssessment = AllRetailAssessment.Where(e => e.CategoryId == CurrentSectionId).ToList();
                if (CurrentSectionId == 2)
                {
                    CurrentSectionTitle = RetailAssessmentSection.EngagedCustomersSuppliers.GetDescription();
                    CurrentSectionHeader = RetailAssessment.Select(e => e.SectionHeader).FirstOrDefault();
                    CurrentSectionIcon = RetailAssessment.Select(e => e.IconName).FirstOrDefault();
                    CurrentSection = RetailAssessmentSection.EngagedCustomersSuppliers;
                    ViewedEngagedCustomersSuppliers = true;
                }

                if (CurrentSectionId == LastSectionId)
                {
                    CurrentSectionTitle = RetailAssessmentSection.OptimizeSupplyChain.GetDescription();
                    CurrentSectionHeader = RetailAssessment.Select(e => e.SectionHeader).FirstOrDefault();
                    CurrentSectionIcon = RetailAssessment.Select(e => e.IconName).FirstOrDefault();
                    CurrentSection = RetailAssessmentSection.OptimizeSupplyChain;
                    ViewedOptimizeSupplyChain = true;
                }
            }
            catch (Exception e)
            {
                ErrorComponent.ShowError(e.Message, e.StackTrace);
            }
        }

        protected void PrevSection()
        {
            try
            {
                CurrentSectionId--;
                ClearSection();
                RetailAssessment = AllRetailAssessment.Where(e => e.CategoryId == CurrentSectionId).ToList();

                if (CurrentSectionId == FirstSectionId)
                {
                    CurrentSectionTitle = RetailAssessmentSection.EmpowerEmployee.GetDescription();
                    CurrentSectionHeader = RetailAssessment.Select(e => e.SectionHeader).FirstOrDefault();
                    CurrentSectionIcon = RetailAssessment.Select(e => e.IconName).FirstOrDefault();
                    CurrentSection = RetailAssessmentSection.EmpowerEmployee;
                    ViewedEmpowerEmployee = true;
                }

                if (CurrentSectionId == 2)
                {
                    CurrentSectionTitle = RetailAssessmentSection.EngagedCustomersSuppliers.GetDescription();
                    CurrentSectionHeader = RetailAssessment.Select(e => e.SectionHeader).FirstOrDefault();
                    CurrentSectionIcon = RetailAssessment.Select(e => e.IconName).FirstOrDefault();
                    CurrentSection = RetailAssessmentSection.EngagedCustomersSuppliers;
                    ViewedEngagedCustomersSuppliers = true;
                }

                if (CurrentSectionId == LastSectionId)
                {
                    CurrentSectionTitle = RetailAssessmentSection.OptimizeSupplyChain.GetDescription();
                    CurrentSectionHeader = RetailAssessment.Select(e => e.SectionHeader).FirstOrDefault();
                    CurrentSectionIcon = RetailAssessment.Select(e => e.IconName).FirstOrDefault();
                    CurrentSection = RetailAssessmentSection.OptimizeSupplyChain;
                    ViewedOptimizeSupplyChain = true;
                }
            }
            catch (Exception e)
            {
                ErrorComponent.ShowError(e.Message, e.StackTrace);
            }
        }

        protected void SubmitSection()
        {
            if (CurrentSectionId == LastSectionId)
            {
                UpdateSubmittedSection();
                NavigationManager.NavigateTo("dynamic365results");
            }
            else
            {
                NextSection();
            }
        }

        private void UpdateSubmittedSection()
        {
            if (CurrentSectionId == FirstSectionId)
            {
                foreach (var assessment in RetailAssessment)
                {
                    EmpowerEmployee.Add(new RetailAssessmentInfo { Id = assessment.Id, CategoryId = assessment.CategoryId, IconName = assessment.IconName, SectionHeader = assessment.SectionHeader, AssessmentQuestion = assessment.AssessmentQuestion, SurveyQuestion = assessment.SurveyQuestion, SelectedAnswer = assessment.SelectedAnswer, Products = assessment.Products });
                }
            }

            if (CurrentSectionId == 2)
            {
                foreach (var assessment in RetailAssessment)
                {
                    EngagedCustomersSuppliers.Add(new RetailAssessmentInfo { Id = assessment.Id, CategoryId = assessment.CategoryId, IconName = assessment.IconName, SectionHeader = assessment.SectionHeader, AssessmentQuestion = assessment.AssessmentQuestion, SurveyQuestion = assessment.SurveyQuestion, SelectedAnswer = assessment.SelectedAnswer, Products = assessment.Products });
                }
            }

            if (CurrentSectionId == LastSectionId)
            {
                foreach (var assessment in RetailAssessment)
                {
                    OptimizeSupplyChain.Add(new RetailAssessmentInfo { Id = assessment.Id, CategoryId = assessment.CategoryId, IconName = assessment.IconName, SectionHeader = assessment.SectionHeader, AssessmentQuestion = assessment.AssessmentQuestion, SurveyQuestion = assessment.SurveyQuestion, SelectedAnswer = assessment.SelectedAnswer, Products = assessment.Products });
                }
            }
        }

        private void ClearSection()
        {
            if (CurrentSectionId == FirstSectionId)
            {
                EmpowerEmployee.Clear();
            }

            if (CurrentSectionId == 2)
            {
                EngagedCustomersSuppliers.Clear();
            }

            if (CurrentSectionId == LastSectionId)
            {
                OptimizeSupplyChain.Clear();
            }
        }
    }
}
