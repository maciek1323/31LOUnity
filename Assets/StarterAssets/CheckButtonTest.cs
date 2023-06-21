using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckButtonTest : MonoBehaviour
{
    private bool CanInteract = false;
    public GameObject ObjectToEnable;
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetButtonDown("Submit") && CanInteract==true)
            Debug.Log("OK");
        ObjectToEnable.SetActive(true);

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CanInteract=true;


        }

    }

    void OnTriggerExit (Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CanInteract=false;


        }

    }
}
