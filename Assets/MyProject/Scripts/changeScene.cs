using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void NextScene()
    {   
        //Loads Scene LvL2, Single:Closes all other loaded scenes
        SceneManager.LoadScene("LvL2", LoadSceneMode.Single);
    }

}
