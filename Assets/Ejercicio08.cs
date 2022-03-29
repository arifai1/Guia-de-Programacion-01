using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio08 : MonoBehaviour
{
    // Start is called before the first frame update
    //8. Crear una variable entera que pueda ser modificada desde el Inspector. Suponiendo que
    //el primer día de la semana es el Domingo, mostrar el nombre del día correspondiente al
    //valor de la variable “dia”. Si el día no está en el rango permitido debe emitir por pantalla el
    //mensaje de error &quot;El día ingresado no es válido&quot;.

    public int dia;
    void Start()
    {
        if (dia == 1)
        {
            Debug.Log("El dia es domingo");
        }
        else if (dia == 2)
        {
            Debug.Log("El dia es lunes");
        }
        else if (dia == 3)
        {
            Debug.Log("El dia es martes");
        }
        else if (dia == 4)
        {
            Debug.Log("El dia es miercoles");
        }
        else if (dia == 5)
        {
            Debug.Log("El dia es jueves");
        }
        else if (dia == 6)
        {
            Debug.Log("El dia es viernes");
        }
        else if (dia == 7)
        {
            Debug.Log("El dia es sabado");
        }
        else
        {
            Debug.Log("El dia ingresado no es valido");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
