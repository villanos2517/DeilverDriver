using System.Data;
using UnityEngine;

public class work5 : MonoBehaviour
{
    void Start()
    {
        int mathScore = 95;
        int englishScore = 85;
        if (mathScore > 60 && englishScore > 60)
        { 
            if (mathScore + englishScore > 179)
            { 
            Debug.Log("��� �հ�");
            }
            else
            {
                Debug.Log("��� �հ�");
            }
        }
        else
        {
            Debug.Log("���հ�");
        }
        

        int level = 5;
        bool isInBattle = true;
        bool hasSpecialItem = true; 
        if (level > 4)
        {
            if (isInBattle == true && hasSpecialItem == true)
            {
                Debug.Log("������ ��� ����");
            }
            else
            {
                Debug.Log("������ ��� �Ұ�");
            }
        }
    }
    void Update()
    {
    }
}
