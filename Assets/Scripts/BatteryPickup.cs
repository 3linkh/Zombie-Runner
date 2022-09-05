using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float restoreAngle = 90f;
    [SerializeField] float intensityAmount = 3f;
    AudioSource pickUpAudioSource;
    private void Start() 
    {
        pickUpAudioSource = GetComponent<AudioSource>();    
    }
    void OnTriggerEnter(Collider other)
    {
        pickUpAudioSource.Play();
        if(other.gameObject.tag == "Player")
        {
            
            other.GetComponentInChildren<FlashlightSystem>().RestoreLightAngle(restoreAngle);
            other.GetComponentInChildren<FlashlightSystem>().RestoreLightIntensity(intensityAmount);
            
                        
            Destroy(gameObject);
        }    
    }
}
