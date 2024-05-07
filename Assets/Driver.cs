using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed;
    [SerializeField] float moveSpeed;
    [SerializeField] float slowSpeed;
    [SerializeField] float boostSpeed;
    //just to see
    [SerializeField] float changedSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Booster")
        {
            moveSpeed = boostSpeed;
            changedSpeed = boostSpeed;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed; 
        changedSpeed = slowSpeed;
    }
}
