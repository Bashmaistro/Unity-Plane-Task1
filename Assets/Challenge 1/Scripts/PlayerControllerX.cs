using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed ;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    public bool tiltLeft;
    public bool tiltRight;

    public GameObject bombPrefab; 
    public Transform bombSpawnPoint; 
    public float bombLaunchForce = 100f; 
    public float bombUpLaunchForce = 5f; 
    
  
    
    

    // Start is called before the first frame update
    void Start()
    {

     

    }

    // Update is called once per frame
    void FixedUpdate()
    {

       if (Input.GetKeyDown(KeyCode.Space))
        {
           
            GameObject bomb = Instantiate(bombPrefab, bombSpawnPoint.position, bombSpawnPoint.rotation);

            
            Rigidbody bombRb = bomb.GetComponent<Rigidbody>();

            Vector3 forceToAdd = bombSpawnPoint.transform.forward * bombLaunchForce + transform.up * bombUpLaunchForce ;
            
            bombRb.AddForce(forceToAdd, ForceMode.Impulse);
        }
        
        //get the user E and F
        tiltLeft = Input.GetKey(KeyCode.E);
        tiltRight = Input.GetKey(KeyCode.F);
        
        
        
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        
        horizontalInput = Input.GetAxis("Horizontal");
        
        

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

       

        

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime);
        
        transform.Rotate(Vector3.up * rotationSpeed * horizontalInput * Time.deltaTime);


        if (tiltLeft)
        {
            transform.Rotate(Vector3.forward * rotationSpeed  * Time.deltaTime);
        }
        
        if (tiltRight)
        {
            transform.Rotate(Vector3.back * rotationSpeed  * Time.deltaTime);
        }
        
        //transform.Rotate(Vector3.forward * rotationSpeed * horizontalInput * Time.deltaTime);
        
    }

     
}
