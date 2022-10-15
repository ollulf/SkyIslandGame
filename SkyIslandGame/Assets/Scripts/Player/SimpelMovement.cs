using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SimpelMovement : MonoBehaviourPunCallbacks
{
    [SerializeField] private float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(-1 * movementSpeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(1 * movementSpeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, 0, 1 * movementSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(0, 0, -1 * movementSpeed * Time.deltaTime);
            }
        }
    }
}
