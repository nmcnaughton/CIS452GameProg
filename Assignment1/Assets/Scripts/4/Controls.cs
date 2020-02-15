using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour
{
    int count = 0;
    IShot shot;
    bool canShoot = true;
    public GameObject player;

    public Text sizeText;
    public Text numberText;
    int sizeCount = 1;
    int numberCount = 1;

    public GameObject winImage;
    public GameObject loseImage;
    
    public Text fireText;

    public Spawner spawner;

    // Start is called before the first frame update
    void Start()
    {
    }
    
    public void SpawnShot(float size, int number)
    {
        spawner.SpawnShot(size, number);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A) && count < 4)
        {
            if(count == 0)
            {
                shot = new BasicShot();
            }

            shot = new LargeShotDecorator(shot);
            sizeCount++;
            count++;
            sizeText.text = "Size: " + sizeCount;
        }

        if (Input.GetKeyDown(KeyCode.S) && count < 4)
        {
            if (count == 0)
            {
                shot = new BasicShot();
            }

            shot = new RepeatShotDecorator(shot);

            numberCount++;
            count++;
            numberText.text = "Shots: " + numberCount;
        }

        if(Input.GetKeyDown(KeyCode.UpArrow) && canShoot)
        {
            if (count == 0)
            {
                shot = new BasicShot();
            }

            spawner.SpawnShot(shot.GetSize(), shot.GetNumber());

            canShoot = false;
            StartCoroutine(Timer());

            numberCount = 1;
            sizeCount = 1;
            count = 0;

            numberText.text = "Shots: " + numberCount;
            sizeText.text = "Size: " + sizeCount;
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            float angle = 50 * Time.deltaTime;

            player.transform.Rotate(player.transform.forward, angle);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            float angle = -50 * Time.deltaTime;

            player.transform.Rotate(player.transform.forward, angle);
        }

        if (count >= 3)
        {
            fireText.transform.parent.gameObject.SetActive(true);
        }

        if (count < 4)
        {
            fireText.transform.parent.gameObject.SetActive(false);
        }
    }

    public void WinGame()
    {
        ReactivateWin();
        Time.timeScale = 0.1f;
        spawner.StopAllCoroutines();
        StopAllCoroutines();
    }

    public void LoseGame()
    {
        ReactivateLose();
        Time.timeScale = 0.1f;
        spawner.StopAllCoroutines();
        StopAllCoroutines();
    }

    void ReactivateWin()
    {
        winImage.SetActive(true);
    }

    void ReactivateLose()
    {
        loseImage.SetActive(true);
    }

    public void Retry()
    {
        var smalls = GameObject.FindGameObjectsWithTag("SmallEnemy");
        foreach(GameObject small in smalls)
        {
            Destroy(small);
        }
        var larges = GameObject.FindGameObjectsWithTag("LargeEnemy");
        foreach (GameObject large in larges)
        {
            Destroy(large);
        }
        var bosses = GameObject.FindGameObjectsWithTag("BossEnemy");
        foreach (GameObject boss in bosses)
        {
            Destroy(boss);
        }
        
        Time.timeScale = 1;

        spawner.BeginGame();
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(.5f);
        canShoot = true;
    }
}
