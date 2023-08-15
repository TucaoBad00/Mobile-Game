using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SOUI : MonoBehaviour
{
    public SOint count;
    public TextMeshProUGUI text;
    void Start()
    {
        text.text = count.Value.ToString();
        count.Value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = count.Value.ToString();
    }
}
