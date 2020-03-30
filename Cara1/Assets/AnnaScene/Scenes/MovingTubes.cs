using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTubes : MonoBehaviour
{
    private float speed = 2.5f;
    public ButtonRotate[] centerRotation;
    [SerializeField]
    public float victoryAngle;
    private float currentAngle;

    public float CurrentAngle { get => currentAngle; set => currentAngle = value >= 360 ? value % 360 : (value < 0 ? 360 - ((-value) % 360) : value); }




    // Start is called before the first frame update
    void Start()
    {
        CurrentAngle =(int)transform.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var item in centerRotation)
        {
            if (item.isPressed == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    CurrentAngle += 90;
                    transform.eulerAngles = new Vector3(0, CurrentAngle, 0);
                }
                //print(rotTransform.eulerAngles);

            }
        }
        Debug.Log(transform.eulerAngles.y == victoryAngle,gameObject);
        //centerRotation.transform.Rotate
        

    }
    
}
