using UnityEngine;

public class Ball : MonoBehaviour
{

    public GameManager gm;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "winplane")
        {
            //win the game
            gm.GameWin();
            
        }
    }
}
