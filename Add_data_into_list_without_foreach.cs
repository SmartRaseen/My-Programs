	how to add data into list without using foreach
	************************************************
	
	Survey.SubSections.FirstOrDefault(e => e.SectionsOrder == currentSubsection)?.Questions.Add(new QuestionInfo() { QuestionType = ((int)QuestionTypes.RadioButtton).ToString(), QuestionsOrder = QuestionId });