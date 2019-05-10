using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetChase : MonoBehaviour
{
    public GameObject Target;
    public Vector3 Pos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 V3 = transform.position;
        V3.x = Target.transform.position.x + Pos.x;
        V3.y = Target.transform.position.y + Pos.y;
        V3.z = Target.transform.position.z + Pos.z;
        transform.position = V3;
    }
}