using UnityEngine;

public class playerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public playerScript player;
    public GameController gc;
    void OnCollisionEnter (Collision colliderinfo){

        if(colliderinfo.collider.tag == "Obstacles"){

            gc.lostGame();
            player.enabled = false;

        }

    }
}
