using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public int coincount;
    public Text value;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      value.text=coincount.ToString();  
    }
}
