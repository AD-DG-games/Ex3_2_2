using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    KeyCode keyFoword;
    [SerializeField]
    KeyCode keyBack;
    [SerializeField]
    KeyCode keyLeft;
    [SerializeField]
    KeyCode keyRight;
    [SerializeField]
    float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetKey(keyRight));
        if (Input.GetKey(keyRight))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(keyLeft))
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(keyBack))
        {
            transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(keyFoword))
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }
    }

}
