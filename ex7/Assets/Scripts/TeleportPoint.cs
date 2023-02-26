using UnityEngine;


public class TeleportPoint : MonoBehaviour
{
    public GameObject player;
    public GameObject destination;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = destination.transform.position;
        }
    }
}
