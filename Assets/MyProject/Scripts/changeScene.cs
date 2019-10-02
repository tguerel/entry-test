using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{

    public void NextScene()
    {   
        //Loads Scene LvL_2, Single:Closes all other loaded scenes
        SceneManager.LoadScene("LvL_2", LoadSceneMode.Single);
    }

}
