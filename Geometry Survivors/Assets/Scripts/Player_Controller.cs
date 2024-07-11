using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float Playermovespeed = 20.0f; // Initialize player movespeed
    public Rigidbody2D rb; // Gets player rigidbody

    public GameObject basicbullet; // Gets the bullet object
    public Transform firePoint; // Where the bullets spawn
    public float fireRate = 10f;
    private float fireCountdown = 0f;

    void Start()
    {

    }

    void Update()
    {
        // Move player
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 tempVect = new Vector3(x, y, 0);
        tempVect = tempVect.normalized * Playermovespeed * Time.deltaTime;
        rb.MovePosition(rb.transform.position + tempVect);

        // Rotate Player
        if (Input.GetKeyDown(KeyCode.W))
        {
            // Debug.Log("up");
            transform.rotation = Quaternion.Euler(Vector3.forward * 0);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            // Debug.Log("down");
            transform.rotation = Quaternion.Euler(Vector3.forward * 180);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            // Debug.Log("left");
            transform.rotation = Quaternion.Euler(Vector3.forward * 90);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            // Debug.Log("right");
            transform.rotation = Quaternion.Euler(Vector3.forward * -90);
        }
        
        // Fire Projectile
        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
            
        }
        fireCountdown -= Time.deltaTime;
    }

    void Shoot()
    {
        Debug.Log("Shoot");
        // Create the projectile
        GameObject projectile = (GameObject)Instantiate(basicbullet, firePoint.position, firePoint.rotation);
    }
}
