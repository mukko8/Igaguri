using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriController : MonoBehaviour
{
    Rigidbody rb;
    public void Shoot(Vector3 dir){
        rb.AddForce(dir);
    }
    void OnCollisionEnter(Collision collision) {
        rb.isKinematic=true;
        GetComponent<ParticleSystem>().Play();
        //Destroy(collision,gameObject);衝突されたものが消える
    }
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate=60;
        rb=GetComponent<Rigidbody>();
        Shoot(new Vector3(0,200,2000));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
