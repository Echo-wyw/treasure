using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wqwqww : MonoBehaviour
{
    public GameObject i;
  
    // Start is called before the first frame update
    void Start()
    {
        i = GameObject.Find("Image");
        i.SetActive(false);

    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0)) ;
        i.SetActive(true);
    }
}
