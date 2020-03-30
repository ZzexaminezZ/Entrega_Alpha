using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door3Botones : Door
{
    [SerializeField]
    private GameObject BotonNecesario1;// Boton que va a pedir para mover la puerta
    [SerializeField]
    private GameObject BotonNecesario2;// Botton que va a pedir para mover la puerta
    [SerializeField]
    private GameObject BotonNecesario3;// Botton que va a pedir para mover la puerta

    public override void Update()
    {
        MoverPuerta();
    }

    public override void MoverPuerta()
    {
        if (BotonNecesario1.gameObject.GetComponent<Button>().Presionado == true && BotonNecesario2.gameObject.GetComponent<Button>().Presionado == true && BotonNecesario3.gameObject.GetComponent<Button>().Presionado == true)
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
