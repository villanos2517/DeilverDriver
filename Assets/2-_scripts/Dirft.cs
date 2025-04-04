using UnityEngine;

public class Dirft : MonoBehaviour
{
    [SerializeField] float accleration = 20f; //전진/후진/가속도
    [SerializeField] float maxspeed = 20f; //최대속도제한
    [SerializeField] float steering = 3f; //조향속도
    [SerializeField] float driftFactor = 0.95f; //더 낮을수록 더 미끄러진다

    [SerializeField] ParticleSystem smokeLeft;
    [SerializeField] ParticleSystem smokeRight;


    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        float speed = Vector2.Dot(rb.linearVelocity, transform.up);
        if (speed < maxspeed)
        {
            rb.AddForce(transform.up * Input.GetAxis("Vertical") * accleration);
        }
        float turnAmount = Input.GetAxis("Horizontal") * steering * Mathf.Clamp(speed / maxspeed, 0.4f, 1f);
        rb.MoveRotation(rb.rotation - turnAmount);
        //Drift
        Vector2 forwardVelocity = transform.up * Vector2.Dot(rb.linearVelocity, transform.up);
        Vector2 sideVelocity = transform.right * Vector2.Dot(rb.linearVelocity, transform.right);
        rb.linearVelocity = forwardVelocity + (sideVelocity * driftFactor);
    }
    private void Update()
    {
        float sidewayVelocity = Vector2.Dot(rb.linearVelocity, transform.right);

        bool isDrifting = rb.linearVelocity.magnitude > 2f;
        if (isDrifting)
        {
            if (!smokeLeft.isPlaying) smokeLeft.Play();
            if (!smokeRight.isPlaying) smokeRight.Play();


        }
        else 
        {
            if (smokeLeft.isPlaying) smokeLeft.Stop();
            if (smokeRight.isPlaying) smokeRight.Stop();
        }
    }
}
