using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    [SerializeField]
    private GameObject[] llaves;
    [SerializeField]
    private ContadorVidasUI Ui;

    private int ContLlaves, numeroLlaves;

    public int GetNumLlaves() { return llaves.Length; }
   /* public int CONTLLAVES {
        get { return ContLlaves; }
        set { ContLlaves = value; }
    }*/

    private void Start()
    {
        ContLlaves = 0;
        numeroLlaves = llaves.Length;

    }
    private void Update()
    {
        MoverPuerta();
    }
    public bool SumaLlave()
    {
        Ui.DestruirLlave();
        ContLlaves++;
        return true;
    }
    public void MoverPuerta()
    {
        if (ContLlaves >= numeroLlaves)
        {
            if (this.gameObject.transform.position.y <= 8)
            {
                this.gameObject.transform.Translate(Vector3.up * Time.deltaTime * 5);
            }
        }

    }
}
