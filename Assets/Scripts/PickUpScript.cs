using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpScript : MonoBehaviour
{
    public Text puntajeTxt;

    int puntaje = 0;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Food"))
        { 
            puntaje += 1;
            puntajeTxt.text = puntaje.ToString();
            Destroy(col.gameObject);
        }
    }

}
