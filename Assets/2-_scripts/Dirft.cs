using UnityEngine;

public class Dirft : MonoBehaviour
{
    [SerializeField] float accleration = 20f; //����/����/���ӵ�
    [SerializeField] float maxspeed = 20f; //�ִ�ӵ�����
    [SerializeField] float steering = 3f; //����ӵ�
    [SerializeField] float driftFactor = 0.95f; //�� �������� �� �̲�������

    [SerializeField] ParticleSystem smokeLeft;
    [SerializeField] ParticleSystem smokeRight;
    [SerializeField] TrailRenderer RightTrail;
    [SerializeField] TrailRenderer LeftTrail;
    [SerializeField] float turnspeed = (0.1f); //���� ����
    [SerializeField] float movespeed = (0.1f); //float,int �������ϱ�
    [SerializeField] float slowSpeedRatio = 0.5f;
    [SerializeField] float boostSpeedRatio = 1.5f;

    float slowSpeed;
    float boostSpeed;

    Rigidbody2D rb;
    AudioSource audioSource;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = rb.GetComponent<AudioSource>();
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

        bool isDrifting = rb.linearVelocity.magnitude > 2f && Mathf.Abs(sidewayVelocity) > 1f;
        if (isDrifting)
        {
            if (!audioSource.isPlaying) audioSource.Play();
            if (!smokeLeft.isPlaying) smokeLeft.Play();
            if (!smokeRight.isPlaying) smokeRight.Play();


        }
        else
        {
            if (audioSource.isPlaying) audioSource.Stop();
            if (smokeLeft.isPlaying) smokeLeft.Stop();
            if (smokeRight.isPlaying) smokeRight.Stop();
        }
        LeftTrail.emitting = isDrifting;
        RightTrail.emitting = isDrifting;
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
