using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTest3 : MonoBehaviour
{
    [SerializeField]
    [Tooltip("生成するGameObject")]
    private GameObject createPrefab;
    [SerializeField]
    [Tooltip("生成する範囲A")]
    private Transform rangeA;
    [SerializeField]
    [Tooltip("生成する範囲B")]
    private Transform rangeB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float x = Random.Range(rangeA.position.x, rangeB.position.x);
        // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
        float y = Random.Range(rangeA.position.y, rangeB.position.y);
        // rangeAとrangeBのz座標の範囲内でランダムな数値を作成
        float z = Random.Range(rangeA.position.z, rangeB.position.z);

        if (Input.GetMouseButtonDown(0))
        {
            // プレハブを取得
            GameObject prefab = (GameObject)Resources.Load("Cube");

            Vector2 pos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
            // プレハブからインスタンスを生成
            GameObject obj = (GameObject)Instantiate(prefab, new Vector3(x, y, z), Quaternion.identity);
            // 作成したオブジェクトを子として登録
            obj.transform.parent = transform;
        }
    }
}
