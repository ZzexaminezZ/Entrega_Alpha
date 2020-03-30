using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRotate : MonoBehaviour
{
    [SerializeField]
    public bool isPressed = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag== "Player")
        {
            isPressed = true;
            other.GetComponent<MovingTubes>();
            //Debug.Log("presionado");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isPressed = false;
            //Debug.Log("sali");
        }
    }





}
