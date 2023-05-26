using UnityEngine;
using System.Collections;

public class Spectator : MonoBehaviour
{
    public static Spectator instance;
    public bool predatorCam = false;

    //initial speed
    public int speed = 20;
    private void Awake()
    {
        instance = this;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //press shift to move faster
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            speed = 40;

        }
        else
        {
            //if shift is not pressed, reset to default speed
            speed = 20;
        }
        //For the following 'if statements' don't include 'else if', so that the user can press multiple buttons at the same time
        //move camera to the left
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + Camera.main.transform.right * -1 * speed * Time.deltaTime;
        }

        //move camera backwards
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + Camera.main.transform.forward * -1 * speed * Time.deltaTime;

        }
        //move camera to the right
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + Camera.main.transform.right * speed * Time.deltaTime;

        }
        //move camera forward
        if (Input.GetKey(KeyCode.W))
        {

            transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
        }
        //press SPACE to toggle Predator Camera ON/OFF
        if (Input.GetKeyDown(KeyCode.Space) && (predatorCam == false))
        {
            predatorCam = true;
            Debug.Log("Predator Cam enabled");
        }
        else if (Input.GetKeyDown(KeyCode.Space) && (predatorCam == true))
        {
            predatorCam = false;
            Debug.Log("Predator Cam disabled");
        }
    }
}