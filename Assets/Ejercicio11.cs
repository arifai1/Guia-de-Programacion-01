using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{
    // Start is called before the first frame update

    // 11. Realizá un programa que resuelva el siguiente problema:
    // Deberá ingresarse por Inspector una fecha de compra(String en el siguiente formato:
    //YYYYMMDD), un nombre de comprador, un nombre de producto y una cantidad y precio del
    //producto comprado.Mostrá a modo de ticket, la información ingresada y el monto a pagar.
    //Modelo de Ticket:
    //Fecha de Compra: YYYYMMDD
    //Nombre del Comprador: xxxxx xxxxx
    //Producto solicitado: xxxxx
    //Cantidad solicitada: xx
    //Precio Unitario: $xxx
    //Total a Pagar: $xxxxx
    public int Fecha;
    public string Nombre_del_Comprador;
    public string Producto;
    public int Cantidad;
    float Precio_total;
    public float Precio_unitario;
    void Start()
    {
        Precio_total = Precio_unitario * Cantidad;

        Debug.Log("Fecha de compra: " + Fecha);
        Debug.Log("Nombre del comprador: " + Nombre_del_Comprador);
        Debug.Log("Producto solicitado: " + Producto);
        Debug.Log("Cantidad solicitada: " + Cantidad);
        Debug.Log("Precio unitario: " + Precio_unitario);
        Debug.Log("Total a pagar: " + Precio_total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
