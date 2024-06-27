using UnityEngine;
using UnityEngine.UI;

public class RandomPrecioGenerator : MonoBehaviour
{
    public Text randomPrecioText;

    void Start()
    {
        int randomNumber = Random.Range(5, 25);

        randomPrecioText.text = randomNumber.ToString();
    }
}