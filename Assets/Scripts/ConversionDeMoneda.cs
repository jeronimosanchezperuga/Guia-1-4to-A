using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    //1. Declaración de variables
    public float montoAConvertir;
    public string codigoMoneda;

    float cotizacionMoneda;

    float montoConvertido;

    float cotizacionDolar = 1204.35f;

    float minimoAConvertir = 1000;

    // Start is called before the first frame update
    void Start()
    {
        //2. Ingreso y validación de los datos
        if (montoAConvertir < minimoAConvertir)
        {
            Debug.Log("El monto mínimo es $1000");
            return;
        }

        if (codigoMoneda == "D")
        {
            cotizacionMoneda = cotizacionDolar;
        } else if (codigoMoneda == "E")
        {
            cotizacionMoneda = 1541.11f;
        }else if (codigoMoneda == "R")
        {
            cotizacionMoneda = 201.24f;
        }
        else
        {
            Debug.Log("Opción de moneda extranjera no válida");
            return;
        }

        //3. Procesamiento de los datos

        montoConvertido = montoAConvertir / cotizacionMoneda;

        //4. Salida de los datos
        Debug.Log("Monto convertido: " + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
