﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio02 : MonoBehaviour
{
    // Start is called before the first frame update
    // Ejercicio 2. Realizá un programa que, siendo num1 y num2 variables enteras con valores 4 y 5,  respectivamente, 
    //realice la operación correspondiente y muestre el resultado en pantalla: 
    //a.Suma
    // b.Producto

    int num1 = 4;
    int num2 = 5;
    int res;
    int resp;
    void Start()
    {
        res = num1 + num2;
        Debug.Log("El resultado de la suma de num1 y num2 es " + res);
        resp = num1 * num2;
        Debug.Log("El resultado del producto de num1 y num2 es " + resp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
