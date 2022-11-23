using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class MoveTest : MonoBehaviour
{
    private float startTime, distance;
    private Vector3 startPosition, targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        //スタート時間をキャッシュ
        startTime = Time.time;
        //スタート位置をキャッシュ
        startPosition = transform.position;
        //到着地点をセット
        targetPosition = new Vector3(0, 1, 10);
        //目的地までの距離を求める
        distance = Vector3.Distance(startPosition, targetPosition);
    }

    // Update is called once per frame
    void Update()
    {
        float interpolatedValue = (Time.time - startTime) / distance;
        //球面線形移動
        transform.position = Vector3.Slerp(startPosition, targetPosition, interpolatedValue);
    }
}
