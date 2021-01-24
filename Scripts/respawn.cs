using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class respawn : MonoBehaviour
{
    public Vector3 respawnPoint;
    public bool babyMode;

    private void Start()
    {
        respawnPoint = transform.position;
    }
    void Update()
    {
        if (gameObject.GetComponent<WallRunTutorial>().grounded && babyMode)
        {
            respawnPoint = transform.position;
        }

        if (transform.position.y <= -60)
        {
            RespawnFromPoint();
        }
    }
    public void RespawnFromPoint()
    {
        SceneManager.LoadScene(SceneManager.sceneCount-1);
        transform.position = respawnPoint;
    }
}
