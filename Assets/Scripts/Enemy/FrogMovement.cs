using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMovement : MonoBehaviour
{
    Animator frogAnim;

    private void Awake()
    {
        frogAnim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        frogAnim.SetBool("Jump", true);
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        frogAnim.SetBool("Jump", false);
    }
}
