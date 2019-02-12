using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class MicrowaveOpen : MonoBehaviour
{
    public bool erko = false;
    public bool kari = false;
    public bool kara = false;
    public bool nine = false;

    public bool flag = false;

    public bool enterTwice = false;

    public AudioSource bellSoundSource;

    public GameObject cameraDarken;
    public Animator cameraFade;

    /*public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;*/

    public FirstPersonController fpsScript;

    public GameObject door;
    private DoorScript doorScript;
    


    // Start is called before the first frame update

    void Start()
    {
        
        doorScript = door.GetComponent<DoorScript>();
        cameraFade = GetComponent<Animator>();
    }
    void Update()
    {
        if (!flag)
        {

            if (erko)
            {
                door.GetComponent<BoxCollider>().enabled = false;
                doorScript.ChangeDoorState();
                
                bellSoundSource.Play();
                flag = true;
            }
        }

         
    }


    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.F))
        {

            if (other.gameObject.tag == "ErkebitStatue")
            {
                erko = true;
            }
            if (other.gameObject.tag == "AlkarısıStatue")
            {
                kari = true;
            }
            if (other.gameObject.tag == "KarakoncolosStatue")
            {
                kara = true;
            }
            if (other.gameObject.tag == "ÇayninesiStatue")
            {
                nine = true;
            }



        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="SlowArea")
        {
            
                fpsScript.amISlowed = true;

            if (!enterTwice)
            {
                doorScript.ChangeDoorState();
                enterTwice = true;
            }

            cameraDarken.SetActive(true);
            cameraFade.Play("camera-darken");

        }
    }


    



}
