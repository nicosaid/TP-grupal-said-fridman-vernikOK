using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CambiarScene : MonoBehaviour
{

    public void ChangeScene(string comida)
    {
        SceneManager.LoadScene(comida);
    }
   
}
