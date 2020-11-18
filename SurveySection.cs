<EditForm Model="CurrentSubSection" OnValidSubmit="SubmitSection">
            <div class="row section-container" style="margin-top: 50px;">
                <div class="col-md-12">
                    <h1 class="header-text segoe-font" style="font-size: 36px;">@CurrentSubSection.Title</h1>
                    <h3 class="segoe-font sub-header-text mt-4 mb-4" style="font-size: 24px;">@CurrentSubSection.Description</h3>
                    <div class="section-image-container">
                        <img src="images/@(CurrentSubSection.SubSectionIcon)" class="section-image">
                    </div>
                    <div class="question-div">
                        @foreach (var question in CurrentSubSection.Questions.OrderBy(e => e.QuestionsOrder))
                        {
                            <div class="question" style="margin-top: 20px">
                                <div data-ot-stem="true" data-ot-background="#1c1c1c" data-ot-target="#q11" data-ot-tip-joint="bottom left" data-ot="A centralized user information repository helps managing user access and integration of additional services." data-ot-style="dark">
                                    @* <img src="images/question-grey.png" class="question-circle" id="q11"> *@
                                </div>
                                <div>
                                    <i class="fa fa-question-circle"></i>
                                    <p name="answers11" class="label-desc segoe-font" style="display: contents;">@question.Question</p>
                                </div>
                                <ul>
                                    @if (question.QuestionType == ((int)QuestionTypes.TextBox).ToString())
                                    {
                                        <li style="text-align: left">
                                            <label class="label-desc segoe-font">
                                                <input type="text" name="@question.Id" id="@question.Id" @bind="question.SelectedAnswer" required>
                                            </label>
                                        </li>
                                    }
                                    else if (question.QuestionType == ((int)QuestionTypes.RadioButton).ToString())
                                    {
                                        @foreach (var option in question.Options)
                                        {
                                            <li style="text-align: left">
                                                <label class="label-desc segoe-font">
                                                    <input type="radio" name="@question.Id" id="@question.Id" @onclick="e => question.SelectedAnswer = option" required checked="@(question.SelectedAnswer == option)">
                                                    <strong>@option</strong>
                                                </label>
                                            </li>
                                        }
                                    }
                                    else
                                    {
                                        @foreach (var option in question.Options)
                                        {
                                            <li style="text-align: left">
                                                <label class="label-desc segoe-font">
                                                    <input type="checkbox" name="@question.Id" id="@question.Id" @onclick="e => question.SelectedAnswer = AddRemoveOption(question.SelectedAnswer, option)" required="@(question.SelectedAnswer == null || question.SelectedAnswer == string.Empty)" checked="@(question.SelectedAnswer.Split(",").Any(e => e.Equals(option)))">
                                                    <strong>@option</strong>
                                                </label>
                                            </li>
                                        }
                                    }
                                </ul>
                            </div>
                        }
                    </div>

                    <div class="d-flex justify-content-center">
                        @if (CurrentSubSection.Id != FirstSectionId)
                        {
                            <button type="button" value="Previous" style="font-size: 23px" class="segoe-font finish" @onclick="PreviousSection">
                                <i class="fa fa-chevron-circle-left" aria-hidden="true"></i>&nbsp;&nbsp;Previous
                            </button>
                        }

                        @if (CurrentSubSection.Id != LastSectionId && CurrentSubSection.Id != FirstSectionId)
                        {
                            <span class="mx-2"></span>
                        }

                        @if (CurrentSubSection.Id != LastSectionId)
                        {
                            <button type="submit" style="font-size: 23px" class="segoe-font finish">
                                Next&nbsp;&nbsp;<i class="fa fa-chevron-circle-right" aria-hidden="true"></i>
                            </button>
                        }
                        @if (CurrentSubSection.Id == LastSectionId)
                        {
                            <span class="mx-2"></span>
                            <button type="submit" style="font-size: 23px" class="segoe-font finish" value="Finish">
                                Finish&nbsp;&nbsp;<i class="fa fa-chevron-circle-right" aria-hidden="true"></i>
                            </button>
                        }
                    </div>
                    <div class="all-questions">All questions must be completed to proceed.</div>
                </div>
            </div>

        </EditForm>