using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectorMeta : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaVictoria;

    [SerializeField]
    TextMeshProUGUI textLabelTime;

    float tiempoPartida = 0.0f;
    bool estaJugando = true;

    private void Update()
    {
        if (estaJugando == true)
        {
            tiempoPartida = tiempoPartida + Time.deltaTime;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            pantallaVictoria.SetActive(true);
            other.GetComponent<MovimientoJugador>().enabled = false;
            estaJugando = false;
            textLabelTime.text = tiempoPartida.ToString();
        }
    }
}
