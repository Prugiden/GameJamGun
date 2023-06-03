using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vindis : MonoBehaviour
{
    private AudioSource aus;

    private void Start()
    {
        aus = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            aus.volume = 1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            aus.volume = 0;
        }
    }
}
