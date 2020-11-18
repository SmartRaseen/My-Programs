<EditForm Model="@userInfo" OnValidSubmit="CreateAdmin">
        <div class="modal popup-alignment" tabindex="-1" role="dialog">
            <div class="modal-dialog unassociate-modal">
                <div class="modal-content" style="width:100%;">
                    <tbody class="tab-content mt-4 mb-2" style="width:100%;display:grid;border-bottom:none;">
                        <div class="mt-2 text-center">
                            <span class="h5 mr-2">Add Admin</span>
                        </div>
                        <div class="row ml-4">
                            <div class="col-md-8 mt-4">
                                <label id="col-form-label" style="display:flex;">
                                    UserName :
                                    <input type="text" class="form-control ml-2" id="form-control3" style="max-width:320px;" @bind="userInfo.Username" required />
                                </label>
                                    <ValidationMessage For="@(() => userInfo.Username)" />
                                @*@{
                                    if(userInfo.Username != null)
                                    {
                                        CheckUserDetail(userInfo.Username);
                                        if (CheckUser)
                                        {
                                            <span class="error"> User name already exist. </span><br />
                                        }
                                    }
                                }*@
                            </div>
                        </div>
                        <div class="row ml-4">
                            <div class="col-md-8 mt-2 ml-2">
                                <label id="col-form-label" style="display:flex;">
                                    Password :
                                    <input type="password" class="form-control ml-2" id="form-control3" style="max-width:320px;" @bind="userInfo.Password" required />
                                </label>
                            </div>
                        </div>
                        <div class="row ml-5">
                            <div class="col-md-8 mt-2 ml-2">
                                <label id="col-form-label" style="display:flex;">
                                    Email :
                                    <input type="email" class="form-control ml-2" id="form-control3" style="max-width:320px;" @bind="userInfo.Email" required />
                                </label>
                                @*@{
                                    if (userInfo.Email != null)
                                    {
                                        CheckUserEmail(userInfo.Email);
                                        if (CheckEmail)
                                        {
                                            <span class="error"> Email already exist. </span><br />
                                        }
                                    }
                                }*@
                            <ValidationMessage For="@(() => userInfo.Email)" />
                            </div>
                        </div>
                        <div class="row ml-4">
                            <div class="col-md-8 mt-2">
                                <label id="col-form-label" style="display:flex;">
                                    Phone No :
                                    <input type="text" class="form-control ml-2" id="form-control3" onkeypress="return isNumberKey(event)" style="max-width:320px;" name="phone" @bind="userInfo.PhoneNumber" required>
                                </label>
                            </div>
                        </div>
                        <div class="row ml-4">
                            <div class="col-md-8 mt-2">
                                <label id="col-form-label" style="display:flex;">
                                    FirstName :
                                    <input type="text" class="form-control ml-2" id="form-control3" style="max-width:320px;" @bind="userInfo.FirstName" required />
                                </label>
                            </div>
                        </div>
                        <div class="row ml-4">
                            <div class="col-md-8 mt-2">
                                <label id="col-form-label" style="display:flex;">
                                    LastName :
                                    <input type="text" class="form-control ml-2" id="form-control3" style="max-width:320px;" @bind="userInfo.LastName" required />
                                </label>
                            </div>
                        </div>
                        <div class="row ml-5 mt-1">
                            <div class="col-md-8 mt-2 ml-1" style="display:flex;margin-top: -0.75rem!important;">
                                <h6 class="mt-4">
                                    Role :
                                </h6>
                                <div class="col-md-8 mt-2">
                                    <div class="form-group mt-2">
                                        <select class="form-control ml-1" name="Role" id="Role-select" style="width:500px;max-width:320px" @bind="userInfo.Role" required>
                                            <option value="SurveyAdmin" selected>Survey Admin</option>
                                            <option value="ReviewerAdmin">Reviewer Admin</option>
                                        </select>
                                    </div>
                                </div>
                            </div>
                        </div>
                            <DataAnnotationsValidator />
                        <div class="mt-2 mb-2 text-center">
                            @if (CheckUser == true || CheckEmail == true)
                            {
                                <button type="button" class="btn btn-primary" value="Save" disabled>
                                    <i class="fa fa-floppy-o" aria-hidden="true"></i>Save
                                </button>
                            }
                            else
                            {
                                <button type="submit" class="btn btn-primary" value="Save">
                                    <i class="fa fa-floppy-o" aria-hidden="true"></i>Save
                                </button>
                            }

                            <button class="btn btn-primary" type="button" id="CloseElement" @onclick="(()=> CancelAddAdmin(userInfo))">
                                <i class="fa fa-close"></i> Cancel
                            </button>
                        </div>
                    </tbody>
                </div>
            </div>
        </div>
    </EditForm>
	


using System.ComponentModel.DataAnnotations;
using MSSurvey.Data;
using MSSurvey.ViewModel;

namespace MSSurvey.Validators
{
    public class UniqueUserName : ValidationAttribute
    {
        private SurveyService SurveyService { get; set; } = new SurveyService();
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var userInfo = (UserInfo)validationContext.ObjectInstance;
            if (userInfo.Id == 0)
            {
                if (SurveyService.CheckUserDetail(value.ToString()) == false)
                    return ValidationResult.Success;
                return new ValidationResult("User name already exists.", new[] { validationContext.MemberName });
            }
            else
            {
                if (SurveyService.CheckUserDetail(value.ToString(), userInfo.Id) == false)
                    return ValidationResult.Success;
                return new ValidationResult("User name already exists.", new[] { validationContext.MemberName });
            }
        }
    }
}


using System.ComponentModel.DataAnnotations;
using MSSurvey.Data;
using MSSurvey.ViewModel;

namespace MSSurvey.Validators
{
    public class UniqueEmail : ValidationAttribute
    {
        private SurveyService SurveyService { get; set; } = new SurveyService();
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var userInfo = (UserInfo)validationContext.ObjectInstance;
            if (userInfo.Id == 0)
            {
                if (SurveyService.CheckUserEmail(value.ToString()) == false)
                    return ValidationResult.Success;
                return new ValidationResult("Email already exists.", new[] { validationContext.MemberName });
            }
            else
            {
                if (SurveyService.CheckUserEmail(value.ToString(), userInfo.Id) == false)
                    return ValidationResult.Success;
                return new ValidationResult("Email already exists.", new[] { validationContext.MemberName });
            }
        }
    }
}


        public bool CheckUserDetail(string username)
        {
            return _dbContext.Users.Any(e => e.Username == username && e.IsDeleted == false);
        }

        public bool CheckUserDetail(string username, int id)
        {
            var currentUserName = GetUserNameByID(id);
            return _dbContext.Users.Any(e => e.Username == username && e.IsDeleted == false && e.Username != currentUserName);
        }

        public bool CheckUserEmail(string email)
        {
            return  _dbContext.Users.Any(e => e.Email == email && e.IsDeleted == false);
        }

        public bool CheckUserEmail(string email, int id)
        {
            var currentEmail = GetEmailById(id);
            return _dbContext.Users.Any(e => e.Email == email && e.IsDeleted == false && e.Email != currentEmail);
        }
