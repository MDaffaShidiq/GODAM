using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bathroomkey : MonoBehaviour
{
    public GameObject inticon, key;
    public AudioSource pickup;

    void OnTriggerStay(Collider other){
        if (other.CompareTag("MainCamera")){
            inticon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E)){
                key.SetActive(false);
                Bathroom.keyfound = true;
                inticon.SetActive(false);
                pickup.Play();
	        }
	    }
    }
     void OnTriggerExit(Collider other){
        if (other.CompareTag("MainCamera")){
            inticon.SetActive (false);
	    }   
    }
}
