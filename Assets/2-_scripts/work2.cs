using UnityEngine;
public class Multiplier : MonoBehaviour
{
    public void Start()
    {
        int currentHealth = 100;
        int Damage = 30;
        ApplyDamage (currentHealth, Damage);
    }
    private int ApplyDamage(int a, int b)
    {
        return(a - b);
    }
}
