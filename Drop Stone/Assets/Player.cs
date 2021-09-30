using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //�����鍂��
    private const float DELETE_Y_POS = -1;

    //�ړ����x
    public float speed = 3.0f;


    void Start()
    {
        
    }

    void Update()
    {
        //�ړ�
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

        //���l�܂ŗ��������������
        if (transform.position.y < DELETE_Y_POS)
        {
            Destroy(this.gameObject);
            //�V�[���ēǂݍ���
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //�Փ˔���
        if (collision.gameObject.tag == "Stone")
        {
            Destroy(this.gameObject);

            SceneManager.LoadScene("S_Result");
        }
    }
}
