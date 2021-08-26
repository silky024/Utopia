using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Suphawan Phunkhamtan");
;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 r = new Vector3(0, 0.1f, 0);
        GetComponent<Transform>().Rotate(r);
    }
}
