using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager5 : MonoBehaviour
{
    public GameObject winText;
    public GameObject loseText;
    public Text randText;
    public Text countText;
    public Image backer;
    bool started = true;

    public GameObject cube;
    public GameObject sphere;

    public ShapeFactory shapeFactory;

    bool hitShape = false;

    int count = 0;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && started)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.tag == "Cube" || hit.transform.gameObject.tag == "Sphere")
                {
                    hit.transform.gameObject.GetComponent<Shape>().ShapeHit();
                    
                    if (hit.transform.gameObject.tag == randText.text)
                    {
                        Debug.Log(hit.transform.gameObject.tag);
                        Debug.Log(randText.text);
                        SpawnShape();
                        count++;
                        countText.text = count.ToString();
                    }

                    else
                    {
                        LoseGame();
                    }
                    
                }
            }
        }

        if (count >= 10)
        {
            WinGame();
        }
    }

    public void WinGame()
    {
        Time.timeScale = 0.1f;
        winText.SetActive(true);
    }

    public void LoseGame()
    {
        Time.timeScale = 0.1f;
        loseText.SetActive(true);
    }

    public void ResetGame()
    {
        started = true;
        count = 0;
        countText.text = count.ToString();
        winText.SetActive(false);
        loseText.SetActive(false);
        randText.text = "Cube";
        backer.color = new Color(99f / 255f, 224f / 255f, 69f / 255f);

        var cubes = GameObject.FindGameObjectsWithTag("Cube");
        var spheres = GameObject.FindGameObjectsWithTag("Sphere");
        foreach (GameObject cube in cubes)
        {
            Destroy(cube);
        }
        foreach (GameObject sphere in spheres)
        {
            Destroy(sphere);
        }

        Time.timeScale = 1.0f;
        Instantiate(shapeFactory.CreateShape("Cube"), new Vector3(0f, 7f, 0f), new Quaternion(0f, 0f, 0f, 0f));
        Instantiate(shapeFactory.CreateShape("Cube"), new Vector3(1f, 7f, 0f), new Quaternion(0f, 0f, 0f, 0f));
        Instantiate(shapeFactory.CreateShape("Sphere"), new Vector3(1f, 7f, 1f), new Quaternion(0f, 0f, 0f, 0f));
        Instantiate(shapeFactory.CreateShape("Sphere"), new Vector3(0f, 7f, 1f), new Quaternion(0f, 0f, 0f, 0f));
    }



    public void SpawnShape()
    {
        if (Random.Range(0, 2) == 1)
        {
            Instantiate(shapeFactory.CreateShape("Cube"), new Vector3(1f, 7f, 0f), new Quaternion(0f, 0f, 0f, 0f));
            Instantiate(shapeFactory.CreateShape("Sphere"), new Vector3(0f, 7f, 1f), new Quaternion(0f, 0f, 0f, 0f));
            randText.text = "Cube";
            backer.color = new Color(99f / 255f, 224f / 255f, 69f / 255f);
        }

        else
        {
            Instantiate(shapeFactory.CreateShape("Cube"), new Vector3(0f, 7f, 0f), new Quaternion(0f, 0f, 0f, 0f));
            Instantiate(shapeFactory.CreateShape("Sphere"), new Vector3(1f, 7f, 1f), new Quaternion(0f, 0f, 0f, 0f));
            randText.text = "Sphere";
            backer.color = new Color(164f / 255f, 63f / 255f, 224f / 255f);
        }
    }
}
