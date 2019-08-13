using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameController gameController;
    void OnTriggerEnter(){
        gameController.winGame();
    }

}
