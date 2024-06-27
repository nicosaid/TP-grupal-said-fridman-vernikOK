using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ComidasScript : MonoBehaviour
{
    public GameObject[] productos;
    int productoRandom;
    GameObject producto;

    Dictionary<GameObject, int> precios = new Dictionary<GameObject, int>();

    public Text randomPlataText;
    public Text txtPrecio1;
    public Text txtPrecio2;
    public Text randomPlataText1;
    int preciototal;
    int plataTotal;
    public GameObject panelcorrecto;
    public GameObject panelincorrecto;


    // Start is called before the first frame update
    void Start()
    {
        panelcorrecto.SetActive(false);
        panelincorrecto.SetActive(false);
        for (int i = 0; i < productos.Length; i++)
        {
            precios.Add(productos[i], Random.Range(1, 25));
        }
        Activate(154.7f, 138.6f, -313.9f);
        txtPrecio1.text = precios[producto].ToString();
        Activate(269f, 138.6f, -313.9f);
        txtPrecio2.text = precios[producto].ToString();
        preciototal = int.Parse(txtPrecio1.text) + int.Parse(txtPrecio2.text);
        plataTotal = Random.Range(5, 25);

        randomPlataText.text = plataTotal.ToString();
    }

    public void alcanza()
    {

        if( plataTotal>preciototal)
        {
            //SceneManager.LoadScene(2); //si sale bien 
            Debug.Log("CORRECT");
            panelcorrecto.SetActive(true);
        }
        else
        {
            //SceneManager.LoadScene(1); //si sale bien  
            Debug.Log("INCORRECT");
            panelincorrecto.SetActive(true);
        }
        //SceneManager.LoadScene(1); //si sale mal 
        //SceneManager.LoadScene(2); //si sale bien
    }
    public void NoAlcanza()
    {
        if (plataTotal<preciototal)
        {
            //SceneManager.LoadScene(2); //si sale bien 
            Debug.Log("CORRECT");
            panelcorrecto.SetActive(true);
        }
        else
        {
            //SceneManager.LoadScene(1); //si sale bien  
            Debug.Log("INCORRECT");
            panelincorrecto.SetActive(true);
        }
    }
    public void alcanzaJusto()
    {
        if (preciototal == plataTotal)
        {
            //SceneManager.LoadScene(2); //si sale bien 
            Debug.Log("CORRECT");
            panelcorrecto.SetActive(true);
        }
        else
        {
            //SceneManager.LoadScene(1); //si sale bien  
            Debug.Log("INCORRECT");
            panelincorrecto.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }

    void Activate(float x, float y, float z)
    {
        productoRandom = Random.Range(0, productos.Length);
        Vector3 posicion = new Vector3(x, y, z);
        producto = productos[productoRandom];
        Instantiate(producto, posicion, Quaternion.identity);
    }
   
}
