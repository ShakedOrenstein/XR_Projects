using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * speed,
            Space.World);
        if (Vector3.Distance(transform.position, GameObject.Find("XR Origin").transform.position) < 0.01f)
        {
            FindObjectOfType<GameManager>().EndLife();
        }
    }

    public void OnSelect()
    {
        GameManager.score++;
        Debug.Log(GameManager.score);
        Destroy(gameObject);
    }
}