using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockingDoor : MonoBehaviour
{
    public float TheDistance;
   // public GameObject ActionDisplay;
   // public GameObject ActionText;
    public GameObject TheDoor;
    public AudioSource KnockingSound;

    void Update()
    {
       
       TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
           // ActionDisplay.SetActive(true);
           // ActionText.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                Debug.Log("You are near the door");
                // ActionDisplay.SetActive(false);
                // ActionText.SetActive(false);
                TheDoor.GetComponent<Animation>().Play("Knock");
                // TheDoor.GetComponent<Animation>().Play("Knock");
                
                KnockingSound.Play();
            }
        }
    }

   void OnMouseExit()
   {
       //ActionDisplay.SetActive(false);
       //ActionText.SetActive(false);
   }
}
