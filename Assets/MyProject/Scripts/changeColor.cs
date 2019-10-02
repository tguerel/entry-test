using UnityEngine;
using UnityEngine.UI;


public class ChangeColor : MonoBehaviour
{





    void Update()
    {
        if (Input.GetKeyDown("space"))
        { 

        //assign a random colour to the colour attribute of the canvas' Image component
        //HSV values assigned in a way that only certain hues come up relatively dark, personal preference
        GetComponent<Image>().color = Random.ColorHSV(0.7f, 1f, 1f, 1f, 0.2f, 0.5f);  

        }
    }
}
