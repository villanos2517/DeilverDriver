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
            Debug.Log("우수 합격");
            }
            else
            {
                Debug.Log("우수 합격");
            }
        }
        else
        {
            Debug.Log("불합격");
        }
        

        int level = 5;
        bool isInBattle = true;
        bool hasSpecialItem = true; 
        if (level > 4)
        {
            if (isInBattle == true && hasSpecialItem == true)
            {
                Debug.Log("아이템 사용 가능");
            }
            else
            {
                Debug.Log("아이템 사용 불가");
            }
        }
    }
    void Update()
    {
    }
}
