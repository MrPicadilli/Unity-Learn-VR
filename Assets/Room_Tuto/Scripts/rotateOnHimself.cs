using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateOnHimself : MonoBehaviour
{
    // Start is called before the first frame update
    private int x = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up,20.0f);
        x++;
        transform.localEulerAngles = new Vector3(x,0,0);
    }
}
