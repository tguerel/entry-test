using UnityEngine;
using UnityEngine.UI;

public class HoverDetect : MonoBehaviour
{

    public Text hoverCountText;

    public int hoverCountNumber;

    public void Start()
    {
        //reset our 1
        hoverCountNumber = 0;
    }

    public void CountHover()

    {
        //add 1 to our int 
        hoverCountNumber = hoverCountNumber + 1;
        //set text to our int and convert it to string
        hoverCountText.text = hoverCountNumber.ToString();

    }
}
