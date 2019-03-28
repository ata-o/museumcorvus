using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choice : MonoBehaviour
{
    public GameObject Question;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject Choice03;

    public int ChoiceMode;

    public GameObject Candle1_f1;

    public GameObject Candle2_f1;

    public GameObject Candle3_f1;

    public GameObject Candle4_f1;

    private int flames = 0;

    private int question_counter = 0;

    void Start()
    {
        Choice01.tag = "Q_true";
        AfterClick();
    }

   

    public void AfterClick()
    {

       

        if (question_counter==0)
        {
            Question.GetComponent<Text>().text = "Çimen ne renktir?";
            Choice01.GetComponentInChildren<Text>().text = "Yeşil";       
            Choice02.GetComponentInChildren<Text>().text = "Sarı";
            Choice03.GetComponentInChildren<Text>().text = "Mavi";
            Choice03.tag = "Q_true";
            Choice01.tag = "Q_false";

        }

        else if (question_counter==1)
        {
            Question.GetComponent<Text>().text = "Question 3";
            Choice01.GetComponentInChildren<Text>().text = "True";
            Choice02.GetComponentInChildren<Text>().text = "False";
            Choice03.GetComponentInChildren<Text>().text = "False";
        }

        else if (question_counter==2)
        {
            Question.GetComponent<Text>().text = "Question 4";
            Choice01.GetComponentInChildren<Text>().text = "True";
            Choice02.GetComponentInChildren<Text>().text = "False";
            Choice03.GetComponentInChildren<Text>().text = "False";
        }

        else if (question_counter==3)
        {
            Question.GetComponent<Text>().text = "Question 5";
            Choice01.GetComponentInChildren<Text>().text = "True";
            Choice02.GetComponentInChildren<Text>().text = "False";
            Choice03.GetComponentInChildren<Text>().text = "False";
        }

        question_counter++;
    }
    public void ChoiceOption01()
    {
       // Question.GetComponent<Text>().text = "First Choice";
        ChoiceMode = 1;
    }
    public void ChoiceOption02()
    {
       //Question.GetComponent<Text>().text = "Second Choice";
        ChoiceMode = 2;
    }
    public void ChoiceOption03()
    {
       // Question.GetComponent<Text>().text = "Third Choice";
        ChoiceMode = 3;
    }
    void Update()
    {
        /*if (ChoiceMode >= 1)
        {
            Choice01.SetActive(false);
            Choice02.SetActive(false);
            Choice03.SetActive(false);
        }*/

        if (ChoiceMode == 1)
        {
            Candle1_f1.SetActive(false);
            Candle2_f1.SetActive(false);
            Candle3_f1.SetActive(false);
            Candle4_f1.SetActive(false);
        }

        
        
    }

    
}
