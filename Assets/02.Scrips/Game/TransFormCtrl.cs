using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransFormCtrl : MonoBehaviour
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
        if (collision.gameObject.tag== "PLAYER")
        {
            GoToTran();
            Debug.Log("???Ҵ?");
        }
    }
    public void GoToTran()
    {
        SceneManager.LoadScene("TRANSFORM");
    }
}
