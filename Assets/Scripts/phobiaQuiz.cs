using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class phobiaQuiz : MonoBehaviour
{
    public int personPoint=0;
    
    public void AddPoints()
    {
        personPoint += 10;
    }

    public void SaveSurvey()
    {
        SaveSystem.SaveSurvey(this);
        SceneManager.UnloadScene("PhobiaQuiz");
        SceneManager.LoadScene("MuseumPart", LoadSceneMode.Single);
    }

    public void LoadSurvey()
    {
        SurveyData data = SaveSystem.LoadSurvey();

        personPoint = data.surveyPoints;
    }
}
