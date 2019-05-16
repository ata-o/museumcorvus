using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class alkarisiFollow : MonoBehaviour
{
    private NavMeshAgent alkarisi;
    private Animator animAlkarisi;
    public GameObject target;

    public void goToDestination() {

        

        alkarisi.destination = target.transform.position;
        
    }

    private void OnEnable()
    {
        alkarisi = GetComponent<NavMeshAgent>();
        animAlkarisi = GetComponent<Animator>();
    }

   
    // Update is called once per frame
    void Update()
    {
        alkarisi.stoppingDistance = 2.3f;

            
            goToDestination();


        if (alkarisi.remainingDistance<=2.3f)
        {
            animAlkarisi.SetBool("Catched", true);
        }

        else
        {
            animAlkarisi.SetBool("Catched", false);
            StartCoroutine(LoadScene());
            

        }
         
        

        
        

    }


    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(15.0f);
        SceneManager.UnloadScene("BurningVillage 1");
            SceneManager.LoadScene("Karacong", LoadSceneMode.Single);
    }
}
