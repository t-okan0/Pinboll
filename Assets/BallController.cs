﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //　ボールが見える可能性のあるｚ軸の最大値
    private float visiblePosZ = -6.5f;

    // ゲームオーバーを表示するテキスト
    private GameObject gameoverText;

   
 
    void Start()
    {
       
        // シーン中のGameOverTextの取得し定義
        this.gameoverText = GameObject.Find("GameOverText");    
    }

    
    void Update()
    {    

        //ボールが画面外に出た場合
        if(this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバーを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over!";
        }
    }

   
}
