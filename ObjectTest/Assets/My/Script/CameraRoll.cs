using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRoll : MonoBehaviour
{
    public GameObject CenterPos;
    public float RollSpeed=3f;


    Vector3 ChildPos;
    float Roll;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) Roll -= RollSpeed;
        if (Input.GetMouseButton(1)) Roll += RollSpeed;
        transform.Rotate(new Vector3(0, Roll, 0));

        //軸を中心にものを回転させる
        ChildPos = transform.position;
        float Angle = (transform.localEulerAngles.z - 90f) * Mathf.Deg2Rad;
        ChildPos.x += Vector3.Distance(CenterPos.transform.position, transform.position) * Mathf.Cos(Angle);
        ChildPos.y += Vector3.Distance(CenterPos.transform.position, transform.position) * Mathf.Sin(Angle);
        CenterPos.transform.position = ChildPos;
    }
}
