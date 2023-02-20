using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float turnspeed = 45f;
    private Animator animate;
    public int coin;
        

    private void Start()
    {
       animate = GetComponent<Animator>();
    }

    // public void  OnCollisionEnter(Collision other)
    //{
    //  if(other.collider.CompareTag("coin"))
    // {
    //   Destroy(other.gameObject);
    // coin = coin + 1;
    //}
    //}
 //  public void OnTriggerEnter(Collider other)
  // {
   //  if(other.gameObject.tag =="greenobject")
    //   {
      //      coin = coin + 1;
        //    Debug.Log(other.gameObject.name);
          //  Destroy(other.transform.gameObject);
        //}
        //else if (other.gameObject.tag=="redobject")
          //{
           // coin = coin - 1;
            //Debug.Log(other.gameObject.name);
            //Destroy(other.transform.gameObject);
        //}
    //}

    void Update()
    {
        var velocity = Vector3.forward  * Input.GetAxis("Vertical") * speed;
        transform.Translate(velocity * Time.deltaTime);
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * Time.deltaTime* turnspeed);
        animate.SetFloat("speed", velocity.z);



        }
}