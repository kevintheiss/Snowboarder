using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") < 0f)
        {
            rb2D.AddTorque(torqueAmount);
        }
        else if(Input.GetAxisRaw("Horizontal") > 0f)
        {
            rb2D.AddTorque(-torqueAmount);
        }
    }
}
