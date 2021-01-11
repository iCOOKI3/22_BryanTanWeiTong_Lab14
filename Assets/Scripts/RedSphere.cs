using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedSphere : MonoBehaviour
{
    public GameObject RedText;
    private int redCounter;


    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            redCounter++;

            RedText.GetComponent<Text>().text = "Red: " + redCounter;

            audioSource.Play();
        }
    }
}
