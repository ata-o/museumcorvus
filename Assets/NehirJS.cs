using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NehirJS : MonoBehaviour
{
    private Animator anim;
    public GameObject trigger;

    private void OnEnable()
    {
        anim = GetComponent<Animator>();
    }
    private IEnumerator WalkInSeconds(float delay)
    {
        yield return new WaitForSeconds(delay);
        PlayJumpScare();
        yield break;
    }

    private void PlayJumpScare()
    {
        anim.Play("Zombie Neck Bite");
    }
 
}
