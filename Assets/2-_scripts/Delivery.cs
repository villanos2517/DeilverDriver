using UnityEngine;


public class Delivery : MonoBehaviour
{
    bool hasChicken = false;
    [SerializeField] float delay = 0.3f;
    [SerializeField] Color NoChickenColor = new Color(1,1,1,1);
    [SerializeField] Color HasChickenColor = new Color(0.9f,0.5f,0.0f,1);
    SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Chicken") && !hasChicken)
        {
            Debug.Log("ġŲ�� �Ⱦ���!");
            hasChicken = true;
            spriteRenderer.color = HasChickenColor;
            Destroy(collision.gameObject, delay);
        }
        if (collision.gameObject.CompareTag("Customer") &&  hasChicken)
        {
            Debug.Log("ġŲ�� �����!");
            hasChicken = false;
            spriteRenderer.color = NoChickenColor;
        }
    }
}
