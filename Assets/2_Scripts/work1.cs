using UnityEngine;
public class GreetManager : MonoBehaviour
{
    void Start()
    {
        Sayhello("ภฬนฮมุ");
        Debug.Log(Sayhello("ภฬนฮมุ"));
    }
    private string Sayhello(string name)
    {
        return name;
    }
}