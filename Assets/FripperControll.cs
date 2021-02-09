using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperControll : MonoBehaviour
{   
    //  HingeJointコンポーネントを入れる
    private HingeJoint myHingeJoint;

    //初期の傾き
    private float defaultAngle = 20;
    //弾いた時の傾き
    private float flickAngle = -20;

    // フリッパーの傾きを設定
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }


    void Start()
    {
        // フリッパーにアタッチしているHingeJointコンポーネントをSTART関数で取得
        this.myHingeJoint = GetComponent<HingeJoint>();

        //フリッパーの傾きを設定
        SetAngle(this.defaultAngle);
    }


    void Update()
    {

            //if文の条件式でキーの入力と共に [Tag名を調べる] ことで [フリッパーを識別] し、
            //キーを押した時と離した時に [SetAngle関数を呼び出し]、引数に与えた角度まで回転しています。

            //左矢印キーを押した時に左フリッパーを動かす
            if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag" || Input.GetKeyDown(KeyCode.A) && tag =="LeftFripperTag" || Input.GetKeyDown(KeyCode.S) && tag == "LeftFripperTag" || Input.GetKeyDown(KeyCode.DownArrow) && tag == "LeftFripperTag")
            {
                SetAngle(this.flickAngle);
            }
            //右矢印キーを押した時に右フリッパーを動かす
            if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag" || Input.GetKeyDown(KeyCode.D) && tag == "RightFripperTag" || Input.GetKeyDown(KeyCode.S) && tag == "RightFripperTag" || Input.GetKeyDown(KeyCode.DownArrow) && tag == "RightFripperTag")
            {
                SetAngle(this.flickAngle);
            }

            //矢印キーを離した時に元に戻す
            if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag" || Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag" || Input.GetKeyUp(KeyCode.A) && tag == "LeftFripperTag" || Input.GetKeyUp(KeyCode.D) && tag == "RightFripperTag" || Input.GetKeyUp(KeyCode.S) && tag == "LeftFripperTag" || Input.GetKeyUp(KeyCode.DownArrow) && tag == "LeftFripperTag" || Input.GetKeyUp(KeyCode.S) && tag == "RightFripperTag" || Input.GetKeyUp(KeyCode.DownArrow) && tag == "RightFripperTag")
            {
                SetAngle(this.defaultAngle);
            }

    }

}
