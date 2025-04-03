using System.IO;
using UnityEngine;

public class Operator : MonoBehaviour
{
    private void Start()
    {
        int score = (10);

        score += 5; Debug.Log(score);
        score -= 5; Debug.Log(score);
        score *= 5; Debug.Log(score);
        score /= 5; Debug.Log(score);
        score %= 5; Debug.Log(score);

        score += 1; Debug.Log(score);
        score++;
        score--;
    }
}
