using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField]
    private GameObject ObjetoNEcesarioParaActivarse;
    [SerializeField]
    private bool presionado = false;

    public bool Presionado { get => presionado; set => presionado = value; }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ObjetoNEcesarioParaActivarse.tag.ToString())
        {
            Presionado = true;                  
        }                    
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == ObjetoNEcesarioParaActivarse.tag.ToString())
        {
            Presionado = false;
        }
             
    }
}
