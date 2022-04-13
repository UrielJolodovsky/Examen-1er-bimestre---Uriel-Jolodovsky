using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    public int cantTaxis;
    public int CantTotalDias;
    public int DiasLluvia;
    
    // Start is called before the first frame update
    void Start()
    {

        if (CantTotalDias < 5 || DiasLluvia < 0 || DiasLluvia > CantTotalDias)
        {
            Debug.Log("Error");
        }
        else
        {

            int KmUnidadTaxi = DiasLluvia * 120 + (CantTotalDias - DiasLluvia) * 90;
            int CombustibleUnidad = KmUnidadTaxi / 15;
            int PrecioCombustibleUnidad = CombustibleUnidad * 130;
            int PrecioTotalTaxis = PrecioCombustibleUnidad * cantTaxis;
            Debug.Log("Una flota de " + cantTaxis + " unidades trabajando durante " + CantTotalDias + " días implicará un gasto de $" + PrecioTotalTaxis + " pesos en concepto de combustible.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
