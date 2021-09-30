using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneGenerator : MonoBehaviour
{
    public GameObject stonePrefab;

    //���ԊԊu�̍ŏ��l
    public float minTime = 0.1f;
    //���ԊԊu�̍ő�l
    public float maxTime = 0.1f;
    //X���W�̍ŏ��l
    public float xMinPosition = -5f;
    //X���W�̍ő�l
    public float xMaxPosition = 5f;
    //Y���W�̍ŏ��l
    public float yMinPosition = 8f;
    //Y���W�̍ő�l
    public float yMaxPosition = 8f;
    //Z���W�̍ŏ��l
    public float zMinPosition = -5f;
    //Z���W�̍ő�l
    public float zMaxPosition = 5f;
    //Stone�̐������ԊԊu
    private float interval;
    //�o�ߎ���
    private float time = 0.0f;

    void Start()
    {
        //���ԊԊu�����肷��
        interval = GetRandomTime();
    }

    void Update()
    {
        //���Ԍv��
        time += Time.deltaTime;

        //�o�ߎ��Ԃ��������ԂɂȂ����Ƃ�(�������Ԃ��傫���Ȃ����Ƃ�)
        if (time > interval)
        {
            //Stone���C���X�^���X������(��������)
            GameObject Stone = Instantiate(stonePrefab);
            //��������Stone�̍��W�����肷��
            Stone.transform.position = GetRandomPosition();
            //�o�ߎ��Ԃ����������čēx���Ԍv�����n�߂�
            time = 0f;
            //���ɔ������鎞�ԊԊu�����肷��
            interval = GetRandomTime();
        }
    }

    //�����_���Ȏ��Ԃ𐶐�����֐�
    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }

    //�����_���Ȉʒu�𐶐�����֐�
    private Vector3 GetRandomPosition()
    {
        //���ꂼ��̍��W�������_���ɐ�������
        float x = Random.Range(xMinPosition, xMaxPosition);
        float y = Random.Range(yMinPosition, yMaxPosition);
        float z = Random.Range(zMinPosition, zMaxPosition);

        //Vector3�^��Position��Ԃ�
        return new Vector3(x, y, z);
    }
}
