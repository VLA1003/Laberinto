using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectorColisionMoneda : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI textLabelCoins;

    int numeroMonedas = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            numeroMonedas = numeroMonedas + 1;
            textLabelCoins.text = numeroMonedas.ToString();
        }
    }
}
