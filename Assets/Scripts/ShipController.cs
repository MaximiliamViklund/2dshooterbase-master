using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class ShipController : MonoBehaviour
{
    [SerializeField]
    float speed = 0.02f;

    [SerializeField]
    GameObject boltPrefuck;

    [SerializeField]
    Transform gunPos;

    [SerializeField]
    float timeBetweenShots = 0.5f;
    float timeSinceLastShot = 0;

    [SerializeField]
    int maxHealth;
    public int currentHealth;

    [SerializeField]
    Slider hpBar;

    [SerializeField]
    TMP_Text pointsText;

    static public int points = 0;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        hpBar.maxValue = maxHealth;
        hpBar.value = currentHealth;

        AddPoints(0);
    }

    // Update is called once per frame
    void Update()
    {
        //--------------------------------------------------Movement----------------------------------------------------------------------------------
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");
        Vector2 movement = new Vector2(xInput, yInput);
        if (movement.magnitude > 0)
        {
            movement.Normalize();
        }

        transform.Translate(movement * speed * Time.deltaTime);

        //---------------------------------------------------Shooting-----------------------------------------------------------------------------------

        timeSinceLastShot += Time.deltaTime;

        if (Input.GetAxisRaw("Fire3") > 0 && timeSinceLastShot >= timeBetweenShots)
        {
            timeSinceLastShot = 0;
            Instantiate(boltPrefuck, gunPos.position, Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Fucker"){
            TakeHp();
        }
    }
    public void AddPoints(int amount){
        points+=amount;
        pointsText.text="Score: "+points.ToString();
    }

    public void TakeHp(){
        currentHealth--;
        hpBar.value=currentHealth;
        
        if (currentHealth == 0){
            print("GAYMOVER");
            SceneManager.LoadScene(2);
        }
    }
}
