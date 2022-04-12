using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    public int cantidadDeUnidades;
    public int periodoDeDias;
    public int cantidadDiasLLuvia;
    public int cantidadDiasSol;
    // Start is called before the first frame update
    void Start()
    {
        int costoPeriodoDeDiasSol = (90 / 15) * 130;
        int costoDiasLluvia = (110 / 15) * 130;

        int costoTotal = (cantidadDiasSol * costoPeriodoDeDiasSol) + (cantidadDiasLLuvia * costoDiasLluvia);

        int costoTotalCombustible = costoTotal * cantidadDeUnidades;

        if (periodoDeDias < 5 || cantidadDiasLLuvia >= 0 || cantidadDiasLLuvia + cantidadDiasSol == periodoDeDias)
        {
            Debug.Log("Una flota de " + cantidadDeUnidades + " unidades trabajando durante " + periodoDeDias + " días implicará un gasto de $" + costoTotalCombustible + " pesos en concepto de combustible.");
        }

        else
        {
            Debug.Log("Error, la cantidad de días debe ser mayor a 5, y la cantidad de dias con lluvia no puede ser menor que 0 ");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
