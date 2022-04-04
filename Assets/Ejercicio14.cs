using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio14 : MonoBehaviour
{
    // Start is called before the first frame update

    //     14. Construir un programa que simule el funcionamiento de una calculadora que puede
    // realizar las cuatro operaciones aritméticas básicas (suma, resta, producto y división) con
    // valores numéricos enteros.
    // Se debe especificar la operación que se desea realizar ingresando una letra por Inspector (s
    // para la suma, r para la resta, p para el producto y d para la división) y luego, deberán
    // ingresarse dos números enteros para así realizar la operación. Informar el resultado por
    // pantalla. Nota: Se recomienda el empleo de una sentencia switch.


    public int num1;
    public int num2;
    public string letra;

    void Start()
    {
        switch (letra)
        {
            case 's':
                Debug.Log("La suma entre ambos numeros es " +num1 + num2);
                break;
            case "r":
                int resta = num1 - num2;
                int resta1 = num2 - num1;
                Debug.Log("La resta entre " + num1 + "-" + num2 + " es igual a " + resta+ "y la resta entre " + num2 + " y" + num1 + " es igual a " + resta1);
                break;
            case 'p':
                Debug.Log("El producto entre ambos numeros es " + num1 * num2);
                break;
            default:
                Debug.Log("La division entre " + num1 + " y" + num2 + " es igual a " + num1 / num2 + " y la division entre " + num2 + " y" + num1 + " es igual a " + num2 / num1 +);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
