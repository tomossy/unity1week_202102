using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    [SerializeField] GameObject goalObject = null;
    [SerializeField] GameObject dobonObject = null;

    [SerializeField] GameObject panel = null;
    [SerializeField] GameObject retryButton = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == goalObject.name)
        {
            Debug.Log("ゴール");
        }
        else if(collision.gameObject.name == dobonObject.name)
        {
            Debug.Log("ドボン");
            panel.SetActive(true);
            retryButton.SetActive(true);
        }
    }
}
