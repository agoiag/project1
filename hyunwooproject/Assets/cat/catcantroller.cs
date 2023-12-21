using UnityEngine;
using UnityEngine.SceneManagement;

public class catcantroller : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    Animator animator;

    void Start()
    {
        Application.targetFrameRate = 60;
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // 점프한다
        if (Input.GetKeyDown(KeyCode.Space) && rigid2D.velocity.y == 0)
        {
            rigid2D.AddForce(transform.up * jumpForce);
        }

        // 좌우 이동
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        // 플레이어 속도
        float speedx = Mathf.Abs(rigid2D.velocity.x);   //Abs : 절대값 구하는 것. 항상 양수가 나오도록 한거임.

        // 스피드 제한
        if (speedx < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }

        if (key != 0)
        {
            SpriteRenderer sprite = GetComponent<SpriteRenderer>();
            //transform.localScale = new Vector3(key, 1, 1);
            if (key == 1)
            {
                sprite.flipX = true;
            }
            else
            {
                sprite.flipX = false;
            }
            animator.speed = speedx / 2f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("충돌함");
        SceneManager.LoadScene("Goyang_04_Clear");//씬 매니저를 통해 씬을 관리, 로드 씬을 통해 씬을 불러옴.
    }
}

            


