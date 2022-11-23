using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTest : MonoBehaviour
{
    public GameObject target; //追いかけるターゲット
    private Vector3 offset; //ボールからオブジェクトまでの距離

    [SerializeField]
    [Tooltip("生成するGameObject")]
    private GameObject createPrefab;
    [SerializeField]
    [Tooltip("生成する範囲A")]
    private Transform rangeA;
    [SerializeField]
    [Tooltip("生成する範囲B")]
    private Transform rangeB;

    void Start()
    {
        //距離の情報を取得
        offset = transform.position - target.transform.position;
    }

    void LateUpdate()
    {
        float x = Random.Range(rangeA.position.x, rangeB.position.x);
        // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
        float y = Random.Range(rangeA.position.y, rangeB.position.y);
        // rangeAとrangeBのz座標の範囲内でランダムな数値を作成
        float z = Random.Range(rangeA.position.z, rangeB.position.z);

        if (Input.GetMouseButtonDown(0))
        {
            //GameObject obj = (GameObject)Resources.Load("Cube");
            // Cubeプレハブを元に、インスタンスを生成、
            Instantiate(createPrefab, new Vector3(x, y, z), Quaternion.identity);
            //距離を保ちながらオブジェクトを移動
            transform.position = target.transform.position + offset;
        }
    }
}
