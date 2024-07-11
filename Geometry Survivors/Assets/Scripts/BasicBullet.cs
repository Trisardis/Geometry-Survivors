using UnityEngine;

public class BasicBullet : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    // private Transform target;
    public float projectilespeed = 70f;
    public float duration = 10f;
    // public int damage = 50;
    // public float explosionRadius = 0f;
    // public GameObject impactEffect;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (duration > 0)
        {
            transform.position += transform.up * Time.deltaTime * projectilespeed;
            duration --;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }
}
