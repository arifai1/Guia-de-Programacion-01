using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio09 : MonoBehaviour
{
    // Start is called before the first frame update
    //9. Realizá un programa que resuelva el siguiente problema:
    //Tres personas aportan diferente capital a una sociedad.Se desea saber qué porcentaje del
    //total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
    //por las tres.
    //Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
    //mostrar lo pedido en el siguiente formato:
    //Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….
    public string nombre1;
    public string nombre2;
    public string nombre3;
    public int capital1;
    public int capital2;
    public int capital3;
    
    void Start()
    {
        int capitaltotal = capital1 + capital2 + capital3;
        int porcentaje1 = capital1 * 100 / capitaltotal;
        int porcentaje2 = capital2 * 100 / capitaltotal;
        int porcentaje3 = capital3 * 100 / capitaltotal;
        Debug.Log("Se aportaron " + capitaltotal + " pesos en total");
        Debug.Log("La persona 1 aportó el capital " + capital1+ " pesos. Aportó un " +porcentaje1+ "% del capital");
        Debug.Log("La persona 2 aportó el capital " + capital2 + " pesos. Aportó un " + porcentaje2 + "% del capital");
        Debug.Log("La persona 3 aportó el capital " + capital3 + " pesos. Aportó un " + porcentaje3 + "% del capital");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
