using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlAnim : MonoBehaviour
{
    private Animator anim;
    int animCount = 0;

    public enum AnimNumber
    {
        MotionFloat, Damage,
        Left1, Left2, Left3,
        Right1, Right2, Right3
    }
    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.Alpha7))
        {
            animCount = (int)AnimNumber.Left1;
            anim.SetBool("IsLeft1_1", true);
        }
        else anim.SetBool("IsLeft1_1", false);

        if (Input.GetKey(KeyCode.Alpha4))
        {
            animCount = (int)AnimNumber.Left2;
            anim.SetBool("IsLeft2_1", true);
        }
        else anim.SetBool("IsLeft2_1", false);

        if (Input.GetKey(KeyCode.Alpha1))
        {
            animCount = (int)AnimNumber.Left3;
            anim.SetBool("IsLeft3_1", true);
        }
        else anim.SetBool("IsLeft3_1", false);
    }
}
