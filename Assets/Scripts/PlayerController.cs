using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{

    private float speed = 10.0f;
    private float gravity = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Forward
        if(Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow))
        {
            Forward();
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        //Backward
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Forward();
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        //Left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Forward();
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        //Right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Forward();
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }

    private void Forward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
