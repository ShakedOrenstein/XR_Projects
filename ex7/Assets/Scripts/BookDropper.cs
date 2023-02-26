using UnityEngine;

public class BookDropper : MonoBehaviour
{
    public GameObject droppingBook;
    public void OnBookEnter()
    {
        droppingBook.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -150));
    }
}
