using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio15 : MonoBehaviour
{
    // Start is called before the first frame update

    //   15. Existen dos reglas que identifican dos conjuntos de valores:
    // - El número es de un solo dígito.
    // - El número es impar.
    // A partir de estas reglas, creá un algoritmo que asigne a las variables booleanas estaEnA,
    // estaEnB, estaEnAmbos y noEstaEnNinguno el valor verdadero o falso, según corresponda,
    // para indicar si el valor ingresado pertenece al primer conjunto, al segundo, a ambos o a
    // ninguno, respectivamente. Definí un lote de prueba de varios números y probá el algoritmo,
    // escribiendo los resultados.

    public float num;
    public float num1;
    bool estaEnA = false;
    bool estaEnB = false;
    bool estaEnAmbos = false;
    bool noestaEnNinguno = false;

    void Start()
    {
        if (num < 10 && num1 > 0)
        {
            estaEnA = true;
            Debug.Log("El valor es de un solo digito");
        }
        else if (num % 2 > 0)
        {
            estaEnB = true;
            Debug.Log("El valor es de un solo digito");
        }
        else if (num % 2 > 0 || num < 10 || num1 > 0)
        {
            estaEnAmbos = true;
            Debug.Log("El numero es impar y es de un solo digito");
        }
        else
        {
            noestaEnNinguno = true;
            Debug.Log("El numero no esta en ninguno");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
