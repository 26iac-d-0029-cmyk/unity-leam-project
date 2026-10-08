using UnityEngine;

public class playerController : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;

    private Rigidbody rd;

    void Start()
    {
        rd = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
         Debug.Log(verticalInput);

       Vector3 movement = transform . forward * speed *Time.deltaTime * verticalInput;
        rd.MovePosition(rd.position + movement);
       
        float horznatalIout = Input.GetAxis("Horizontal");
        float trun = rotationSpeed * Time.deltaTime * horznatalIout;
        Quaternion turnRotation = Quaternion.Euler(0f, trun, 0f);
        rd.MoveRotation(rd.rotation * turnRotation);
        

            



    }
}
