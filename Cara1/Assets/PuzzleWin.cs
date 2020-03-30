using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleWin : MonoBehaviour
{
    [SerializeField]
    private GameObject BotonNecesario1;// Boton que va a pedir para mover la puerta


    private void Update()
    {
        MoverPuerta();
    }

    private void MoverPuerta()
    {
        if (BotonNecesario1.gameObject.GetComponent<puzzle>().Win == true)
        {
            if (this.gameObject.transform.position.y <= 7.21)
            {
                this.gameObject.transform.Translate(Vector3.up * Time.deltaTime * 3);
            }


        }
        else
        {
            if (this.gameObject.transform.position.y > 2.50)
            {
                this.gameObject.transform.Translate(Vector3.down * Time.deltaTime * 5);
            }

        }

    }
}
