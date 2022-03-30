using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio13 : MonoBehaviour
{
    // Start is called before the first frame update
    //13. Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente  manera:  
    //• Si trabaja 40 horas o menos se le paga $16 por hora(crear una constante para almacenar el 16)
    //• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20  por cada hora extra. (crear una constante para almacenar el 20)
    //Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por pantalla el salario correspondiente
    float salario;
    int hora = 16;
    public int horas;
    void Start()
    {
        if(horas <= 40)
        {
            salario = horas * 16;
            Debug.Log("Su salario es: " + salario);
        }
        else if (horas > 40)
        {
            salario = 40 * 16;
           int extra = horas - 40;
            extra = extra * 20;
            salario = salario + extra;
            Debug.Log("Su salario con las horas extra incluidas es de " + salario);
        }
          
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
