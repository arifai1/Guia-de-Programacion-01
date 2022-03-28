using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio03 : MonoBehaviour
{
    // Start is called before the first frame update
    public string insertuser;
    // Crear una variable pública que permita ingresar texto. Permitir que al ejecutar el programa se muestre en la consola 
    //un mensaje de saludo que incluya el texto de la variable. Por ejemplo, si en la variable se ingresa el texto “Ana”, 
    //el mensaje en consola debe decir “Hola Ana”. 
    void Start()
    {
        Debug.Log("Hola " + insertuser);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
