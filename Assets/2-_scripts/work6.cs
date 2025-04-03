using UnityEngine;

public class work6 : MonoBehaviour
{
    private void Start()
    {
        int score = 100;
        if (score >= 100)
        {
            Debug.Log("우와 A+입니다!");
        }
        int health = 100;
        if (health >= 70)
        {
            Debug.Log("건강해요");
            if (health > 30)
            {
                Debug.Log("약간 지쳤어요");
            }
            else if (health > 0)
            {
                Debug.Log("위험해요");
            }
            else
            {
                Debug.Log("사망...");
            }
        }
        else
        {
            Debug.Log("사망...");
        }
    }
}
 