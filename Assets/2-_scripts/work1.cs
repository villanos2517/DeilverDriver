using UnityEngine;
public class GreetManager : MonoBehaviour
{
    void Start()
    {
        Sayhello("�̹���");
        Debug.Log(Sayhello("�̹���"));
    }
    private string Sayhello(string name)
    {
        return name;
    }
}