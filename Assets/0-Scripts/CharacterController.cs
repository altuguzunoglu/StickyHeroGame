using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    public float jumpSpeed = 150.0f;
    public float speed = 20f;
    public float horizontalMove = 0f;
    public bool stands;
    Rigidbody2D rb;
    public Vector2 jump;
    public int point;
    public bool isHit;
    public Text pointsText;
    public Text highScoreText;

    private Vector3 initialPosition;
    private Quaternion initialRotation;
    private float lastPositionX;
    public AudioSource coinSound;
    public bool IsJump;
    public SpriteRenderer playerSpriteRenderer;
    public Sprite jumpSprite;
    public Sprite idleSprite;


    public GameObject[] objects;
    public GameObject[] objects1;
    public GameObject[] objects2;
    public GameObject[] objects3;
    public GameObject[] objects4;
    public GameObject[] objects5;
    public GameObject[] objects6;
    public GameObject[] objects7;
    public GameObject[] objects8;
    public GameObject[] objects9;
    public GameObject[] objects10;
    public GameObject[] objects11;
    public GameObject[] objects12;
    public GameObject[] objects13;
    public GameObject[] objects14;
    public GameObject[] objects15;
    public GameObject[] objects16;

    public GameObject other;
    public GameObject other1;
    public GameObject other2;
    public GameObject other3;
    public GameObject other4;
    public GameObject other5;

    private void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScoreText",0).ToString();
       
        playerSpriteRenderer = GetComponent<SpriteRenderer>();
        initialPosition = transform.position;
        initialRotation = transform.rotation;
        rb = GetComponent<Rigidbody2D>();
        jump = new Vector2(0.0f, 2.0f);
        isHit = false;
    }
    private void OnCollisionStay2D()
    {
        stands = true;
        playerSpriteRenderer.sprite = idleSprite;
    }
    private void OnCollisionExit2D()
    {
        stands = false;
        playerSpriteRenderer.sprite = jumpSprite;
    }

        public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Die();
        }

        if (collision.gameObject.tag == "Coin")
        {
            coinSound.Play();
            DestroyObjects();           
            Destroy(collision.gameObject);
            
            Invoke("SpawnObjects", 2f);
 
        }
    }
    public void SpawnObjects()
    {
        isHit = true;
        point += 100;
        int rand = Random.Range(0, objects.Length);
        Vector2 spawnPoint1 = new Vector2(1, 4);
        Vector2 spawnPoint2 = new Vector2((float)3.69, (float)-2.5);
        Vector2 spawnPoint3 = new Vector2((float)-4.47, (float)-1.06);
        Vector2 spawnPoint4 = new Vector2((float)4.89, (float)1.38);
        Vector2 spawnPoint5 = new Vector2((float)-6.81, (float)-0.1);
        Vector2 spawnPoint6 = new Vector2((float)5.68, (float)3.39);
        Vector2 spawnPoint7 = new Vector2((float)5.73, (float)4.52);
        Vector2 spawnPoint8 = new Vector2((float)0.06, (float)1.14);
        Vector2 spawnPoint9 = new Vector2((float)-6.19, (float)3.99);
        Vector2 spawnPoint10 = new Vector2((float)-0.81, (float)1.27);
        Vector2 spawnPoint11 = new Vector2((float)-1.37, (float)-1.32);
        Vector2 spawnPoint12 = new Vector2((float)-3.35, (float)-0.04);
        Vector2 spawnPoint13 = new Vector2((float)3.2, (float)2.59);
        Vector2 spawnPoint14 = new Vector2((float)-2.85, (float)4.27);
        Vector2 spawnPoint15 = new Vector2((float)-5.75, (float)3.33);
        Vector2 spawnPoint16 = new Vector2((float)2.24, (float)4.00);

        int random1 = Random.Range(0, 2);
        int random2 = Random.Range(0, 2);
        int random3 = Random.Range(0, 2);
        int random4 = Random.Range(0, 2);
        int random5 = Random.Range(0, 2);
        int random6 = Random.Range(0, 2);
        int random7 = Random.Range(0, 2);
        int random8 = Random.Range(0, 2);
        int random9 = Random.Range(0, 2);
        int random10 = Random.Range(0, 2);
        int random11 = Random.Range(0, 2);
        int random12 = Random.Range(0, 2);
        int random13 = Random.Range(0, 2);
        int random14 = Random.Range(0, 2);
        int random15 = Random.Range(0, 2);


        if (random1 == 1)
        {
            Instantiate(objects[rand], spawnPoint1, Quaternion.identity);
        }
        if (random2 == 1)
        {
            Instantiate(objects1[rand], spawnPoint2, Quaternion.identity);
        }
        if (random3 == 1)
        {
            Instantiate(objects2[rand], spawnPoint3, Quaternion.identity);
        }
        if (random4 == 1)
        {
            Instantiate(objects3[rand], spawnPoint4, Quaternion.identity);
        }
        if (random5 == 1)
        {
            Instantiate(objects4[rand], spawnPoint5, Quaternion.identity);
        }
        if (random6 == 1)
        {
            Instantiate(objects5[rand], spawnPoint6, Quaternion.identity);
        }
        if (random7 == 1)
        {
            Instantiate(objects6[rand], spawnPoint7, Quaternion.identity);
        }
        if (random8 == 1)
        {
            Instantiate(objects7[rand], spawnPoint8, Quaternion.identity);
        }
        if (random9 == 1)
        {
            Instantiate(objects8[rand], spawnPoint9, Quaternion.identity);
        }
        if (random10 == 1)
        {
            Instantiate(objects9[rand], spawnPoint10, Quaternion.identity);
        }
        if (random11 == 1)
        {
            Instantiate(objects10[rand], spawnPoint11, Quaternion.identity);
        }
        if (random12 == 1)
        {
            Instantiate(objects11[rand], spawnPoint12, Quaternion.identity);
        }
        if (random13 == 1)
        {
            Instantiate(objects12[rand], spawnPoint13, Quaternion.identity);
        }
        if (random8 == 0)
        {
            Instantiate(objects13[rand], spawnPoint14, Quaternion.identity);
        }
        if (random14 == 1)
        {
            Instantiate(objects14[rand], spawnPoint15, Quaternion.identity);
        }
        if (random15 == 1)
        {
            Instantiate(objects16[rand], spawnPoint16, Quaternion.identity);
        }

    }
    public void Update()
    {
      
        pointsText.text =  point.ToString();
        //horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        if(point >  PlayerPrefs.GetInt("HighScoreText",0))
        {
            PlayerPrefs.SetInt("HighScoreText", point);
            highScoreText.text = point.ToString();
        }
    }
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        rb.AddForce(new Vector3(horizontal * speed, 0, 0));



        if (Input.GetKeyDown(KeyCode.W) && stands)
        {
            rb.AddForce(Vector2.up * jumpSpeed * jump);
            stands = false;
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyUp(KeyCode.A))
        {
            gameObject.GetComponent<Transform>().Rotate(0, -180, 0);
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyUp(KeyCode.D))
        {
            gameObject.GetComponent<Transform>().Rotate(0, 360, 0);
        }

    }
    private void DestroyObjects()
    {
        Destroy(GameObject.Find(other.name));
        Destroy(GameObject.Find(other4.name));
        Destroy(GameObject.FindGameObjectWithTag("Coin"));              
        Destroy(GameObject.Find(other.name + "(Clone)"));
        Destroy(GameObject.Find(other1.name + "(Clone)"));
        Destroy(GameObject.Find(other2.name + "(Clone)"));
        Destroy(GameObject.Find(other3.name + "(Clone)"));
        Destroy(GameObject.Find(other4.name + "(Clone)"));
        Destroy(GameObject.Find(other5.name + "(Clone)"));
    }
    public void Die()
    {
        SceneManager.LoadScene("DieMenu", LoadSceneMode.Single);
        //GameObject.FindGameObjectWithTag("UIController").GetComponent<UIController>().ActivateMainMenu();
    }


}
