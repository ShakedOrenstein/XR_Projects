using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereLocator : MonoBehaviour
{
    public Transform cubeTransform;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cubeTransform.position + new Vector3(2, 0, 0);
    }
}
