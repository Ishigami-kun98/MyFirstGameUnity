using UnityEngine;
using UnityEngine.SceneManagement;

public class lostPannel : MonoBehaviour
{
    // Start is called before the first frame update
    public void retry(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void quit(){
        Application.Quit();
    }
}
