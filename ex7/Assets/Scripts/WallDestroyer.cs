using UnityEngine;

public class WallDestroyer : MonoBehaviour
{
    private int ballCounter = 0;
    
    public void OnBallEnter()
    {
        ballCounter++;
        if (ballCounter == 2)
        {
            Destroy(gameObject);
        }
    }
    
    public void OnBallExit()
    {
        ballCounter--;
    }
}
