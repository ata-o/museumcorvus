using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasFreezeTrigger : MonoBehaviour
{
    public GameObject QuestionCanvas;
    public GameObject Karacongolos;
    public CharacterController FPSContoller;
    // public GameObject ScriptOnOff;
    //public GameObject FPSContoller;
    //public Animation Anim;
  
     


    private void Start()
    {
        Karacongolos.SetActive(false);
        FPSContoller.GetComponent<CharacterController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Debug.Log("girdi");
            Karacongolos.SetActive(true);
            QuestionCanvas.SetActive(true);
            FPSContoller.enabled = false;
            //FPSContoller = GameObject.FindWithTag("Player");
            //FPSContoller.GetComponent(FirstPersonController).enable = false;
           




        }
    }
}
