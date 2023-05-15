using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenTest : MonoBehaviour
{
    Sequence sequence;
    public bool isPurch = false;
    // Start is called before the first frame update
    void Start()
    {
        //transform.DOMoveX(5, 2);      ��ü�� x�������� 5��ū 2�ʵ��� ���ڴ�.
        //transform.DORotate(new Vector3(0, 0, 180), 2);        //180�� 2�� ȸ��
        //transform.DOScale(new Vector3(3, 3, 3), 2);           //2�� ���� 3�� ũ��
        sequence = DOTween.Sequence();
        sequence.Append(transform.DOMoveX(5, 2).SetEase(Ease.OutBounce));       //SetEase �߰� �ɼ�
        sequence.Append(transform.DORotate(new Vector3(0,0,180),2).OnComplete(SequnceEnd)); //�Ϸ�Ǹ� �Լ� ȣ��
        sequence.Append(transform.DOScale(new Vector3(3,3,3),2));
        sequence.SetLoops(-1, LoopType.Yoyo);

    }

    void SequnceEnd()
    {
        Debug.Log("ȸ�� �Ϸ�");
    }

    void EndPunch()
    {
        isPurch = false;            //��ġ�� ������ �� ���°��� �ٽ� false�� ����
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(isPurch == false)            //��Ī ���� �ƴ� ��
            {
                isPurch = true;            // ��Ī ���̶�� ���°� ����
                transform.DOPunchScale(new Vector3(0.5f,0.5f,0.5f),0.1f,10,1).OnComplete(EndPunch);

                Color color = new Color(Random.value, Random.value, Random.value);  //�������� ���ؼ�
                Renderer renderer = GetComponent<Renderer>();       //Renderer ������Ʈ���� 
                renderer.material.DOColor(color, 0.1f);             // renderer�� tween���� �ݿ�
            }
        }


    }
}
