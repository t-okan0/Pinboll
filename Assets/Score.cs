using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour { 

  //GetScore
    private GameObject getscore;

    //score
    private int score = 0;

    //score表示
    private Text scoreText;

    
    void Start()
    {
       //シーンのオブジェクトの取得
        this.getscore = GameObject.Find("GetScore");
    }

    void Update()
    {
        
     
    }

    void  OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "SmallStarTag")
            {
                this.score += 10;
            }
            
            if (collision.gameObject.tag == "LargeStarTag")
            {
                this.score += 20;
            }
           
            if (collision.gameObject.tag == "SmallCloudTag")
            {
                this.score += 20;
            }
            
            if (collision.gameObject.tag == "LargeCloudTag")
            {
                this.score += 40;
            }

        //スコアのコンポーネントを取得し表示
        this.getscore.GetComponent<Text>().text = "Score" + score;
    }


  


}


