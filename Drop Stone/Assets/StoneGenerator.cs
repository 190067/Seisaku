using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneGenerator : MonoBehaviour
{
    public GameObject stonePrefab;

    //時間間隔の最小値
    public float minTime = 0.1f;
    //時間間隔の最大値
    public float maxTime = 0.1f;
    //X座標の最小値
    public float xMinPosition = -5f;
    //X座標の最大値
    public float xMaxPosition = 5f;
    //Y座標の最小値
    public float yMinPosition = 8f;
    //Y座標の最大値
    public float yMaxPosition = 8f;
    //Z座標の最小値
    public float zMinPosition = -5f;
    //Z座標の最大値
    public float zMaxPosition = 5f;
    //Stoneの生成時間間隔
    private float interval;
    //経過時間
    private float time = 0.0f;

    void Start()
    {
        //時間間隔を決定する
        interval = GetRandomTime();
    }

    void Update()
    {
        //時間計測
        time += Time.deltaTime;

        //経過時間が生成時間になったとき(生成時間より大きくなったとき)
        if (time > interval)
        {
            //Stoneをインスタンス化する(生成する)
            GameObject Stone = Instantiate(stonePrefab);
            //生成したStoneの座標を決定する
            Stone.transform.position = GetRandomPosition();
            //経過時間を初期化して再度時間計測を始める
            time = 0f;
            //次に発生する時間間隔を決定する
            interval = GetRandomTime();
        }
    }

    //ランダムな時間を生成する関数
    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }

    //ランダムな位置を生成する関数
    private Vector3 GetRandomPosition()
    {
        //それぞれの座標をランダムに生成する
        float x = Random.Range(xMinPosition, xMaxPosition);
        float y = Random.Range(yMinPosition, yMaxPosition);
        float z = Random.Range(zMinPosition, zMaxPosition);

        //Vector3型のPositionを返す
        return new Vector3(x, y, z);
    }
}
