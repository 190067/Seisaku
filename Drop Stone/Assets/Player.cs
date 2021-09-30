using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //消える高さ
    private const float DELETE_Y_POS = -1;

    //移動速度
    public float speed = 3.0f;


    void Start()
    {
        
    }

    void Update()
    {
        //移動
        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("down"))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("right"))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("left"))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }

        //一定値まで落下したら消える
        if (transform.position.y < DELETE_Y_POS)
        {
            Destroy(this.gameObject);
            //シーン再読み込み
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //衝突判定
        if (collision.gameObject.tag == "Stone")
        {
            Destroy(this.gameObject);

            SceneManager.LoadScene("S_Result");
        }
    }
}
