using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 launchDirection;
    public PROJECTILETYPE projecttiletype = PROJECTILETYPE.PLAYER;
    public enum PROJECTILETYPE
    {
        PLAYER,
        ENEMY
    }

    private void OnCollisionEnter(Collision collision)
    {   //���� �浹�� �ı�
        if(collision.gameObject.tag == "Wall")
        {           
            Destroy(this.gameObject);
        }
        //���Ϳ� �浹��
        if (collision.gameObject.tag == "Monster" && projecttiletype == PROJECTILETYPE.PLAYER)
        {
            //���Ϳ��� �������� �ְ� �������. 
            collision.gameObject.GetComponent<MonsterController>().Damanged(1);
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Player" && projecttiletype == PROJECTILETYPE.ENEMY)
        {
            //���Ϳ��� �������� �ְ� �������. 
            collision.gameObject.GetComponent<PlayerController>().Damanged(1);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)         //Trigger �Լ� 
    {   //���� �浹�� �ı�
        if (other.gameObject.tag == "Player" && projecttiletype == PROJECTILETYPE.ENEMY)             //Name -> Tag �� ��ȯ 
        {
            other.gameObject.GetComponent<PlayerController>().Damanged(1);
           
            Destroy(this.gameObject);
        }
        //���Ϳ� �浹��
        if (other.gameObject.tag == "Monster" && projecttiletype == PROJECTILETYPE.PLAYER)
        {
            //���Ϳ��� �������� �ְ� �������. 
            other.gameObject.GetComponent<MonsterController>().Damanged(1);
            other.transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1);
            Destroy(this.gameObject);
        }
    }

    private void FixedUpdate()
    {
        //�ð���� �̵� �� float ������ ����
        float moveAmount = 3 * Time.fixedDeltaTime;
        //launchDirection �������� �߻�ü �̵� (Translate) �̵� ��Ű�� �Լ�
        transform.Translate(launchDirection * moveAmount);
    }
}