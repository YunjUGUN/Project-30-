using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCtrl : MonoBehaviour
{
    public float speed = 3.0f;
    public GameObject Wkey;
    public GameObject Skey;
    public GameObject Akey;
    public GameObject Dkey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
            Wkey.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            Wkey.SetActive(false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
            Skey.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            Skey.SetActive(false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            Akey.SetActive(true);
            //Akey.enabled = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Akey.SetActive(false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            Dkey.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Dkey.SetActive(false);
        }
    }
}
