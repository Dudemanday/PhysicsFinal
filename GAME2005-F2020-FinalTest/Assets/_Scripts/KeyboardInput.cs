using System.Collections;
using System.Collections.Generic;
using player = PlayerBehaviour;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyboardInput : MonoBehaviour
{
    private bool paused = false;

    // Start is called before the first frame update
    void Start() {}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            paused = !paused;
            GameObject.Find("Player").GetComponent<player>().enabled = paused;

            Debug.Log("paused:" + paused);
        }
        if (paused)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        if (Input.GetKeyDown("q"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("StartScene");
        }
    }
}
