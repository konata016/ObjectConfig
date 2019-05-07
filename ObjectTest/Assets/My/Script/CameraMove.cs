using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Vector3 Velocity;

    public float SmoothTime = 0.1f;
    public float End = 1300f;

    Vector3 TargetPos;

    // Start is called before the first frame update
    void Start()
    {
        TargetPos = new Vector3(0f, 0f, End);
    }

    // Update is called once per frame
    void Update()
    {
        //移動
        transform.position =
            Vector3.SmoothDamp(transform.position, TargetPos, ref Velocity, SmoothTime);
    }
}
