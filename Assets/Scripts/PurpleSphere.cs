using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurpleSphere : MonoBehaviour
{
    public GameObject PurpleText;
    private int purpleCounter;


    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            purpleCounter++;

            PurpleText.GetComponent<Text>().text = "Purple: " + purpleCounter;

            audioSource.Play();
        }
    }
}
