using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anime2 : MonoBehaviour
{
    Vector3 Save;

    // Start is called before the first frame update
    void Start()
    {
        Save = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        Save = transform.position;

        float x = transform.position.x - Save.x;
        float y = transform.position.y - Save.y;

        Save = transform.position;
    }
}
