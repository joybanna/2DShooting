using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFix : MonoBehaviour
{
    public Rigidbody2D rb;
    public Rigidbody2D hook;
    public GameObject nextBall;
    public static int point = 4;
    public static int Score = 0;
    public int numcatch = 0;
    public float maxDragDistance = 2f;
    private bool isPressed = false;
    public AudioClip player1, player2, Block;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (isPressed && numcatch == 0)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector2.Distance(mousePos, hook.position) > maxDragDistance)
            {
                rb.position = hook.position + (mousePos - hook.position).normalized * maxDragDistance;
            }
            else
            {
                rb.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }

        Debug.Log(BallFix.point);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            audioSource.PlayOneShot(Block);
        }
    }
    void OnMouseDown()
    {
        audioSource.PlayOneShot(player1);
        isPressed = true;
        rb.isKinematic = true;
    }
    void OnMouseUp()
    {
        audioSource.PlayOneShot(player2);
        isPressed = false;
        rb.isKinematic = false;
        numcatch++;
        BallFix.point--;
        StartCoroutine(Release());
    }
    public float releaseTime = .15f;
    IEnumerator Release()
    {
        yield return new WaitForSeconds(releaseTime);
        GetComponent<SpringJoint2D>().enabled = false;
        this.enabled = false;
        yield return new WaitForSeconds(2f);
        if (BallFix.point != 0)
        {
            if (nextBall != null)
            {
                nextBall.SetActive(true);
            }

        }
        else
        {
            Ball.EnermyAlive = 0;
            BallFix.point = 2;
            ChangeScene();
        }

    }
    public void ChangeScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }



}
