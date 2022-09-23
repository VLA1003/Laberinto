using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorColisionPared : MonoBehaviour
{
    [SerializeField]
    Material materialPorDefecto;

    [SerializeField]
    Material materialEnColision;

    bool paredColision = false;

    float tiempoEnColision = 3f;

    private void Update()
    {
        if(paredColision == true)
        {
            tiempoEnColision = tiempoEnColision - Time.deltaTime;
            if(tiempoEnColision < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = materialPorDefecto;
                paredColision = true;
                tiempoEnColision = 3f;
            }
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material = materialEnColision;
            paredColision = true;
        }

    }
}
