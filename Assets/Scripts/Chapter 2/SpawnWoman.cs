using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWoman : MonoBehaviour
{
    public int knockedDoorCount;
    public bool womanSpawned;
    public bool doorOpened;
    // Start is called before the first frame update
    void Start()
    {
        knockedDoorCount = 0;
        womanSpawned = false;
        doorOpened = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (knockedDoorCount > 1 && !womanSpawned)
        {
            womanSpawned = true;
        }
        else if (womanSpawned && !doorOpened)
        {
            foreach (Transform child in transform)
            {
                if (child.gameObject.tag != "KnockedDoor")  // find the not knocked door
                {
                    openDoor(child);
                }
            }
        }
    }
    
    void openDoor(Transform child)
    {
        child.gameObject.GetComponent<Animation>().Play("DoorCellOpen");
        Debug.Log(child.gameObject.name);
        doorOpened = true;

    }

    
}
