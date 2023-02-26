using UnityEngine;

public class BallThrower : MonoBehaviour
{
    public float force = 10f;

    public void Shoot()
    {
        Vector3 direciton = (transform.position - Camera.main.transform.position).normalized;
        GetComponent<Rigidbody>().AddForce(force * direciton, ForceMode.Impulse);
    }
}
