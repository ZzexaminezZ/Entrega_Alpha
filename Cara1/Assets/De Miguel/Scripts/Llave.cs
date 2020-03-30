using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{
    [SerializeField]
    private Puerta door;

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "Player")
        {
            door.SumaLlave();
            Destroy(this.gameObject);
        }
    }

}
