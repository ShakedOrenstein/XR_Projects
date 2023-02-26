using UnityEngine;

public class CrystalTeleporter : MonoBehaviour
{
	public GameObject player;
	public Vector3 destination = Vector3.zero;

	public void Throw()
	{
		player.transform.position = destination;
	}
}
