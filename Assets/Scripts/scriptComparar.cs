using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class scriptComparar : MonoBehaviour
{
    public Text valorTxt;
    public Text precio1Txt;
    public Text precio2Txt;
    public int valor;
    public int precio1;
    public int precio2; 
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void BotonPresionado()
    {
       
    }
    void tocarBotonAlcanza()
    {
        
    }
    void tocarBotonNoAlcanza()
    {
       
    }
    void tocarBotonAlcanzaJusto()
    {
        valor = Convert.ToInt32(valorTxt.text);
        precio1 = Convert.ToInt32(valorTxt.text);
        precio2 = Convert.ToInt32(valorTxt.text);
        if ((precio1 + precio2) == valor)
        {
            Debug.Log("Alcanza Justo");
        }
    }
    
}
