using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotater1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 r = new Vector3(0, 0.1f, 0);
        GetComponent<Transform>().Rotate(r);
    }
}
