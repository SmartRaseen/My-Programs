Form Email Validation
*********************

[ValidEmail]
public string Email { get; set; }

<EditForm Model="D365Users" OnValidSubmit="AddUserAndTakeSurvey">
                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <input class="segoe-font input-field form-text-field col-sm-12" type="text" placeholder="First Name *" id="first-name" name="FirstName" maxlength="25" required @bind="D365Users.FirstName" />
                                        </div>
                                    </div>

                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <input class="segoe-font input-field form-text-field col-sm-12" placeholder="Last Name *" type="text" id="last-name" name="LastName" maxlength="25" required @bind="D365Users.LastName" />
                                        </div>
                                    </div>

                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <input class="segoe-font input-field form-text-field col-sm-12" placeholder="Email *" type="email" id="email" name="Email" required @bind="D365Users.Email" />
                                            <div class="ml-5">
                                                <ValidationMessage For="@(() => D365Users.Email)" />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <input class="segoe-font input-field form-text-field col-sm-12" type="text" placeholder="Phone Number *" id="work-phone" name="WorkPhone" required @bind="D365Users.PhoneNumber" />
                                            <div class="ml-5">
                                                <ValidationMessage For="@(() => D365Users.PhoneNumber)" />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <input class="segoe-font input-field form-text-field col-sm-12" type="text" placeholder="Company Name *" id="company-name" name="CompanyName" maxlength="35" required @bind="D365Users.CompanyName" />
                                        </div>
                                    </div>

                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <select name="companySize" class="input-field col-sm-12 form-text-field company-size-field" id="company-size-select" required @bind="D365Users.CompanySize">
                                                <option disabled>Company Size (# of PCs) *</option>
                                                <option value="1-10">1 to 10</option>
                                                <option value="11-50">11 to 50</option>
                                                <option value="51-250">51 to 250</option>
                                                <option value="251-500">251 to 500</option>
                                                <option value="500+">500+</option>
                                            </select>
                                        </div>
                                    </div>

                                    <div class="col-md-12">
                                        <div class="col-md-12 p-0" id="privacyPolicyCheckboxDiv" style="margin-bottom: 10px; padding-right: 15px;"></div>

                                        <div class="col-md-12 p-0" id="contactMeCheckboxDiv">
                                            <div>
                                                <p style="font-size: 14px;">
                                                    <input type="checkbox" name="contactMe" id="contactMe" @onclick="e => D365Users.MicrosoftContact = !D365Users.MicrosoftContact"><span id="checkbox-space" class="form-text-field">I would like Microsoft to contact me for more information regarding my assessment.</span>
                                                </p>
                                            </div>
                                        </div>
                                        <div class="col-md-12 p-0" id="partnerContactMeCheckboxDiv">
                                            <div>
                                                <p style="font-size: 14px;">
                                                    <input type="checkbox" name="PartnerContactMe" id="parnterContactMe" @onclick="e => D365Users.MicrosoftPartnersContact = !D365Users.MicrosoftPartnersContact"><span id="checkbox-space" class="form-text-field">I would like Microsoft Partners to contact me for more information regarding my assessment.</span>
                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="text-center col-md-12 mb-2">
                                        <button type="submit" value="Find Your Score" class="btn btn-block py-3 btn-black">Start Assessment</button>
                                    </div>
                                    <div class="col-md-12">
                                        <p style="font-size: 14px; font-weight: 400 !important;" class="form-text-field">
                                            By clicking Find Your Score, I am stating that I have read and agree to the terms of the Microsoft <a id="privacyLink" style="font-weight: 400 !important; text-decoration: underline;" target="_blank" href="http://go.microsoft.com/fwlink/?LinkId=521839">Privacy Statement</a>.
                                        </p>
                                    </div>
                                    <DataAnnotationsValidator />
                                </EditForm>
								
								
bool IsValidEmail(string email)
{
    try {
        var mail = new System.Net.Mail.MailAddress(email);
        return true;
    }
    catch {
        return false;
    }
}