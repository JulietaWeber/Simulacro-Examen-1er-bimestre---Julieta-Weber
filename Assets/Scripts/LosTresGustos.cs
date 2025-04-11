using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosTresGustos : MonoBehaviour
{
    public string saborElegido;
    public int cantidadDeHelado;

    string chocolate = "CHO";
    string frutilla = "FRU";
    string dulceDeLeche = "DDL";

    float valorDelGramo = 1.25f;
    float valorTotal;
    // Start is called before the first frame update
    void Start()
    {
        if (saborElegido != "CHO" && saborElegido != "FRU" && saborElegido != "DDL")
        {
            Debug.Log("Error");
            return;
        }
        if (cantidadDeHelado < 250 || cantidadDeHelado > 3000)
        {
            Debug.Log("Error");
            return;
        }

        if (saborElegido == "CHO" || saborElegido == "DDL")
        {
            valorTotal = valorDelGramo * cantidadDeHelado;
            Debug.Log(valorTotal);
        }else if (saborElegido == "FRU")
        {
            valorTotal = valorDelGramo * (cantidadDeHelado * 0.9f);
            Debug.Log(valorTotal);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
