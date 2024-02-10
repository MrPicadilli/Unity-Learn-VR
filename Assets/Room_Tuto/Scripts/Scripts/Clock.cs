using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public class Clock : MonoBehaviour
{
    public GameObject Hour;
    public GameObject Minute;
    public GameObject Second;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        System.DateTime date = System.DateTime.Now;
        float angle_hour = (360.0f / 12.0f) * (float)date.Hour;
        Hour.transform.localEulerAngles = new Vector3(angle_hour,0,0);
        float angle_minute = (360.0f / 60.0f) * (float)date.Minute;
        Minute.transform.localEulerAngles = new Vector3(angle_minute,0,0);
        float angle_second = (360.0f / 60.0f) * (float)date.Second;
        Second.transform.localEulerAngles = new Vector3(angle_second,0,0);

    }
}
