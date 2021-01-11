using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YellowCapsule : MonoBehaviour
{
    public GameObject YellowText;
    private int yellowCounter;


    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            yellowCounter++;

            YellowText.GetComponent<Text>().text = "Yellow: " + yellowCounter;

            audioSource.Play();
        }
    }
}
