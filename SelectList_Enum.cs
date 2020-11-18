public enum HelpDeskCategory
    {
        [Description("IT HelpDesk")]
        ITHelpDesk = 1,
        [Description("HR HelpDesk")]
        HRHelpDesk = 2,
        [Description("Employee Information")]
        EmployeeInformation = 3,
    }

protected List<SelectListItem> AssessmentRoles
        {
            get
            {
                return Enum.GetValues(typeof(AssessmentRole))
            .Cast<AssessmentRole>()
            .Select(item => new SelectListItem
            {
                Text = item.GetDescription(),
                Value = ((int)item).ToString(),
            }).ToList();
            }
        }


// Initialize form data
            HelpDeskInfo = new HelpDeskInfo
            {
                EmployeeId = State.EmployeeID,
                ContactName = State.DisplayName,
                Email = State.Email,
                Channel = HelpDeskChannels.First().Value,
                Priority = int.Parse(HelpDeskPriorities.First().Value),
                Status = int.Parse(HelpDeskStatuses.First().Value),
                TicketOwner = long.Parse(TicketOwners.First().Value),
                Category = int.Parse(HelpDeskCategories.First().Value),
            };
			
        public static string GetDescription<T>(this T e)
            where T : IConvertible
        {
            if (e is Enum)
            {
                Type type = e.GetType();
                Array values = Enum.GetValues(type);

                foreach (int val in values)
                {
                    if (val == e.ToInt32(CultureInfo.InvariantCulture))
                    {
                        var memInfo = type.GetMember(type.GetEnumName(val));

                        if (memInfo[0]
                            .GetCustomAttributes(typeof(DescriptionAttribute), false)
                            .FirstOrDefault() is DescriptionAttribute descriptionAttribute)
                        {
                            return descriptionAttribute.Description;
                        }
                    }
                }
            }

            return null; // could also return string.Empty
        }
		
		
		<label for="category" class="label-style col-md-2">Category<span class="required-field">*</span></label>
                        <select class="form-control col-md-4" @bind="HelpDeskInfo.Category" required>
                            @foreach (var option in HelpDeskCategories)
                            {
                                <option value="@option.Value">
                                    @option.Text
                                </option>
                            }
                        </select>
						
						
		// Optional values
		
		<div class="col-md-5">
                                        <h6 class="text-weight-wrap segoe-font form-text-field company-size-label">
                                            Company Size (# of PCs):<span class="star">*</span>
                                        </h6>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-group">
                                            <select name="companySize" class="input-field form-text-field company-size-field" id="company-size-select" required >
                                                <option value="1-10">1 to 10</option>
                                                <option value="11-50">11 to 50</option>
                                                <option value="51-250">51 to 250</option>
                                                <option value="251-500">251 to 500</option>
                                                <option value="500+">500+</option>
                                            </select>
                                        </div>
                                    </div>