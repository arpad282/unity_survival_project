using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour //CTRL+ALT+S server explorer
{
    //local variables for the 3 sliders
    public Slider healthSlider;
    public Slider hungerSlider;
    public Slider thirstSlider;

    public AudioClip eat;

    public Animator anim;
    public GameObject cross;


    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("vertical", Input.GetAxis("Vertical"));
        anim.SetFloat("horizontal", Input.GetAxis("Horizontal"));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("jump");
        }
    
    }
}
