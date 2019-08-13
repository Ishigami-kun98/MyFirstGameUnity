using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject winlvl;
    public GameObject lostlvl;

    public bool lost = false;
    public bool win = false;
    public void lostGame(){
        if(lost == false){
            lost = true;
            lostlvl.SetActive(true);
        }
    }

    public void winGame(){
        if(win == false){
            win = true;
            winlvl.SetActive(true);
        }
    }
}
