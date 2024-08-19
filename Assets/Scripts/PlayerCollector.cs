using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollector : MonoBehaviour
{
    private int count;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        winTextObject.SetActive(false);
        SetCountText();        
    }

    // Update is called once per frame
    //void Update()
    //{

    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText ()
    { 
         countText.text = "Count: " + count.ToString();
        Debug.Log("Count is: " + count); // Add this line to verify the count
        if (count == 8)
        {
            winTextObject.SetActive(true);
            Debug.Log("You Win!"); // Add this line to verify the condition is met
        }
    }
 
}
