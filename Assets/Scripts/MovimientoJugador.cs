using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float moviemientoEjeX;
    public float moviemientoEjeY;
    public float moviemientoEjeZ;
    public float velocidadMovimiento = 2.5f;
    void Update()
    {
        moviemientoEjeX = - Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;
        moviemientoEjeZ = - Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;
        transform.Translate(moviemientoEjeX, moviemientoEjeY, moviemientoEjeZ);
    }
}
