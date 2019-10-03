using UnityEngine;
using UnityEngine.UI;

public class HoverDetect : MonoBehaviour
{

    public Text hoverCountText;

    public int hoverCountNumber;

    public void Start()
    {
        hoverCountNumber = 0;
    }

    public void CountHover()

    {
        Debug.Log("hovered.");

        hoverCountNumber = hoverCountNumber + 1;

        Debug.Log(hoverCountNumber);

    }
}
