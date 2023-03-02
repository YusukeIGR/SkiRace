using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class AddForce : MonoBehaviour {
 
    //一秒間に一定の回数呼ばれる
    void FixedUpdate()
    {
        // 入力をxとzに代入
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
 
        //Rigidbodyを取得
        Rigidbody rb = GetComponent<Rigidbody>();
 
        //Rigidbodyに力を加える
        rb.AddForce(x, 0, z);
    }
}