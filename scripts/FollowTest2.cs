using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTest2 : MonoBehaviour
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

    public GameObject Flame;
        GameObject Obj;
        GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    public void Dead()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Obj = (GameObject)Instantiate(Flame, this.transform.position, Quaternion.identity);
            Obj.transform.parent = Player.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
