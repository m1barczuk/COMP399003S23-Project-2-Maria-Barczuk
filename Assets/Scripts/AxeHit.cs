using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AxeHit : MonoBehaviour
{
    // public int score = 0;
    // public TMP_Text scoreText;
    public void OnTriggerEnter(Collider other)
    {
        // void Start()
        // {
        //     score = 0;
        // }
        // Destroy(other.gameObject);
        // score++;
        // scoreText.text = "Score: " + score;
        if(other.name == "SteelSpherePoint1")
        {
            Destroy(other.gameObject);
            // score++;
            // scoreText.text = "Score: " + score;
        } else if(other.name == "SteelSpherePoint2")
        {
            Destroy(other.gameObject);
            // score++;
            // scoreText.text = "Score: " + score;
        } else if(other.name == "SteelSpherePoint3")
        {
            Destroy(other.gameObject);
            // score++;
            // scoreText.text = "Score: " + score;
        } else if(other.name == "SteelSpherePoint4")
        {
            Destroy(other.gameObject);
            // score++;
            // scoreText.text = "Score: " + score;
        } else if(other.name == "SteelSpherePoint5")
        {
            Destroy(other.gameObject);
            // score++;
            // scoreText.text = "Score: " + score;
        } else if(other.name == "SteelSpherePoint6")
        {
            Destroy(other.gameObject);
            // score++;
            // scoreText.text = "Score: " + score;
        } else if(other.name == "SteelSpherePoint7")
        {
            Destroy(other.gameObject);
            // score++;
            // scoreText.text = "Score: " + score;
        } else if(other.name == "SteelSpherePoint8")
        {
            Destroy(other.gameObject);
            // score++;
            // scoreText.text = "Score: " + score;
        } else if(other.name == "SteelSpherePoint9")
        {
            Destroy(other.gameObject);
            // score++;
            // scoreText.text = "Score: " + score;
        } else if(other.name == "SteelSpherePoint10")
        {
            Destroy(other.gameObject);
            // score++;
            // scoreText.text = "Score: " + score;
        }
    }
}
