using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoMovingTube : MonoBehaviour
{
    private float speed = 2.5f;
    public ButtonRotate centerRotation;
    public ButtonRotate twocenterRotation;

    public Transform rotTransform;
    [SerializeField]
    public float victoryAngle;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //centerRotation.transform.Rotate
        if (centerRotation.isPressed == true)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                rotTransform.Rotate(0, 90f, 0 * speed * Time.deltaTime);
            }

        }
        else
        {
            if (twocenterRotation.isPressed == true)
            {
                if (Input.GetKeyDown(KeyCode.P))
                {
                    rotTransform.Rotate(0, 90f, 0 * speed * Time.deltaTime);
                }
            }

        }

    }
}
