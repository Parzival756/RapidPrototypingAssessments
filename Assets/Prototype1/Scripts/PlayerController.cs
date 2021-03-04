using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    private Rigidbody PlayerRB;
    private GameObject FocalPoint;
    public GameObject PowerupIndicator;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
        FocalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        PowerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
        float forwardInput = Input.GetAxis("Vertical");
        PlayerRB.AddForce(FocalPoint.transform.forward * speed * forwardInput);
    }
    
    public bool hasPowerup;
    private float powerupstrength = 15.0f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Powerup"))
        {
            PowerupIndicator.gameObject.SetActive(true);
            hasPowerup = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountDownRoutine());
        }
    }    
    IEnumerator PowerupCountDownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        PowerupIndicator.gameObject.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayfromPlayer = (collision.gameObject.transform.position - transform.position);

            Debug.Log("collided with: " + collision.gameObject.name + " with powerup set to" + hasPowerup);
            enemyRigidbody.AddForce(awayfromPlayer * powerupstrength, ForceMode.Impulse);
        }
    }
}
