using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrangeCapsule : MonoBehaviour
{
    public GameObject OrangeText;
    private int orangeCounter;


    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            orangeCounter++;

            OrangeText.GetComponent<Text>().text = "Orange: " + orangeCounter;

            audioSource.Play();
        }
    }
}
