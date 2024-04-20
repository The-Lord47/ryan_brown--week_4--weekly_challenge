using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    PlayerControllerX _pc;
    public TMP_Text score_txt;

    // Start is called before the first frame update
    void Start()
    {
        _pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerX>();
    }

    // Update is called once per frame
    void Update()
    {
        score_txt.text = "Score:" + _pc.score;
    }
}
