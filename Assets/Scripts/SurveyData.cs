using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SurveyData
{
    public int surveyPoints;

    public SurveyData(phobiaQuiz quiz)
    {
        surveyPoints = quiz.personPoint;
    }
}
