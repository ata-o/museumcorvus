using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class phobiaQuiz : MonoBehaviour
{
    public float personPoint=0;
    public GameObject variablePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(personPoint);

        if (personPoint==70)
        {
            SceneManager.UnloadScene("PhobiaQuiz");
            SceneManager.LoadScene("MuseumPart", LoadSceneMode.Single);
        }
    }

    public void buttonOnClick()
    {
        personPoint += 10;
    }
}
