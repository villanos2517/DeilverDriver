using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float turnspeed = (0.1f); //변수 이해
    [SerializeField] float movespeed = (0.1f); //float,int 구분잘하기
    [SerializeField] float slowSpeedRatio = 0.5f;
    [SerializeField] float boostSpeedRatio = 1.5f;
    float slowSpeed;
    float boostSpeed;
    void Start()
    {
        slowSpeed = movespeed * slowSpeedRatio;
        boostSpeed = movespeed * boostSpeedRatio;
    }
    void Update()
    {
        //transform.position(0, 0, 0);
        //transform.Rotate(0, 0, 0.1f);
        //transform.Translate(0, 0.01f, 0);

        float turnamount = Input.GetAxis("Horizontal") * turnspeed * Time.deltaTime;
        float moveamount = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
        //float amount = Input.GetAxis("Horizontal");
        //Debug.Log(turnamount);
        //Debug.Log(moveamount);


        transform.Rotate(0, 0, -turnamount);
        transform.Translate(0, moveamount, 0);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Boost"))
        {
            movespeed = boostSpeed;
            Debug.Log("boost!!!!!!!!!!!!!");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        movespeed = slowSpeed;
    }
}