using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlAnim : MonoBehaviour
{
    private Animator anim;
    public enum AnimNumber
    {
        MotionFloat, Damage,
        Left1, Left2, Left3,
        Right1, Right2, Right3
    }  
    AnimNumber animCount;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        #region 何もしていない時
        if (!Input.anyKey)
        {
            animCount = AnimNumber.MotionFloat;
            anim.SetBool("IsMotionFloat", true);
        }
        else anim.SetBool("IsMotionFloat", false);
        #endregion

        #region ダメージ時
        if (Input.GetKey(KeyCode.Space))
        {
            animCount = AnimNumber.Damage;
            anim.SetBool("IsDamage", true);
        }
        else anim.SetBool("IsDamage", false);
        #endregion

        #region 左向き開始
        if (Input.GetKey(KeyCode.Alpha1) && animCount != AnimNumber.Left1)
        {
            animCount = AnimNumber.Left1;
            anim.SetBool("IsLeft1_1", true);
        }
        else anim.SetBool("IsLeft1_1", false);

        if (Input.GetKey(KeyCode.Alpha2) && animCount != AnimNumber.Left2)
        {
            animCount = AnimNumber.Left2;
            anim.SetBool("IsLeft2_1", true);
        }
        else anim.SetBool("IsLeft2_1", false);

        if (Input.GetKey(KeyCode.Alpha3) && animCount != AnimNumber.Left3)
        {
            animCount = AnimNumber.Left3;
            anim.SetBool("IsLeft3_1", true);
        }
        else anim.SetBool("IsLeft3_1", false);
        #endregion

        #region 左向き途中
        if (animCount == AnimNumber.Left1) anim.SetBool("IsLeft1_2", true);
        else anim.SetBool("IsLeft1_2", false);

        if (animCount == AnimNumber.Left2) anim.SetBool("IsLeft2_2", true);
        else anim.SetBool("IsLeft2_2", false);

        if (animCount == AnimNumber.Left3) anim.SetBool("IsLeft3_2", true);
        else anim.SetBool("IsLeft3_2", false);
        #endregion

        #region 右向き開始
        if (Input.GetKey(KeyCode.Q) && animCount != AnimNumber.Right1)
        {
            animCount = AnimNumber.Right1;
            anim.SetBool("IsRight1_1", true);
        }
        else anim.SetBool("IsRight1_1", false);

        if (Input.GetKey(KeyCode.W) && animCount != AnimNumber.Right2)
        {
            animCount = AnimNumber.Right2;
            anim.SetBool("IsRight2_1", true);
        }
        else anim.SetBool("IsRight2_1", false);

        if (Input.GetKey(KeyCode.E) && animCount != AnimNumber.Right3)
        {
            animCount = AnimNumber.Right3;
            anim.SetBool("IsRight3_1", true);
        }
        else anim.SetBool("IsRight3_1", false);
        #endregion

        #region 右向き途中
        if (animCount == AnimNumber.Right1) anim.SetBool("IsRight1_2", true);
        else anim.SetBool("IsRight1_2", false);

        if (animCount == AnimNumber.Right2) anim.SetBool("IsRight2_2", true);
        else anim.SetBool("IsRight2_2", false);

        if (animCount == AnimNumber.Right3) anim.SetBool("IsRight3_2", true);
        else anim.SetBool("IsRight3_2", false);
        #endregion

    }
}
