using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasicCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        transform.Rotate(1, 1, 1);
    }
    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "PLAYER")
        {
            GoToBasic();
        }
    }
    public void GoToBasic()
    {
        SceneManager.LoadScene("BASIC");
    }
}
