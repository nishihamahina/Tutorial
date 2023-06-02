using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topBound;//������̐���
    [SerializeField] private float lowerBound;//�������̐���
    void Update()
    {
        if(topBound < transform.position.z) {
            Destroy(gameObject);
            //gameObject�Ƃ����͎̂����Ő錾���Ă��Ȃ��Ă��g����
            //����ȗp��ł��B�u���̃X�N���v�g���A�^�b�`����Ă��鎩�����g�v
            //���w���܂��B���������āA�����������Ƃ����Ӗ��ɂȂ�܂�
        }else if(transform.position.z < lowerBound) {
            Destroy(gameObject);
            //�y�]�k�z����Destroy�͏d�������ŁA���ۂɂ̓I�u�W�F�N�g���������A
            //�ꎞ�I�ɔ�\���ɂ��Ďg���܂킷�̂��Q�[���͕��ʂł��B
            //������I�u�W�F�N�g�v�[�����O�iobject pooling�j�Ƃ����܂��B
            //�����A�㋉�e�N�j�b�N�̂ł����ł͕��ʂ�Destroy���܂��B
        }
    }
}
