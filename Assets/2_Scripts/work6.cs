using UnityEngine;

public class work6 : MonoBehaviour
{
    private void Start()
    {
        int score = 100;
        if (score >= 100)
        {
            Debug.Log("��� A+�Դϴ�!");
        }
        int health = 100;
        if (health >= 70)
        {
            Debug.Log("�ǰ��ؿ�");
            if (health > 30)
            {
                Debug.Log("�ణ ���ƾ��");
            }
            else if (health > 0)
            {
                Debug.Log("�����ؿ�");
            }
            else
            {
                Debug.Log("���...");
            }
        }
        else
        {
            Debug.Log("���...");
        }
    }
}
 