using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class shooting1 : MonoBehaviour {

	public GameObject bullet;
	public GameObject bullethole;
	public GameObject recoil;
	public GameObject flash;
	public GameObject plane;
	public GameObject plane1;
	public GameObject plane2;
	public GameObject head;
	public GameObject body;
	public GameObject lower;
    public GameObject player;
    public GameObject player1;
    public GameObject player3;
    public GameObject player4;
    public GameObject player5;
	public float delayTime = 8;
    public int chance=7;
    public int sec;
    public int time;
    private IEnumerator cor;
    public Text chanceText;
    public Text scoreText;
    public Text miss;
	public int score;
    public int a;
    public int b;
    public int c;
    public int d;
	GameObject bullethole1;
    public GameObject[] players;
    GameObject obj;
    public float[] x;
    public float[] y;
    public float[] z;
    int xpos, ypos, zpos;
    GameObject text;


	private float counter=0;
	// Use this for initialization
	void Start () 
	{
		score = 0;
        cor = timer();
        StartCoroutine(cor);
        SetScoreText ();
        a = 0;
        b = 0;
        c = 0;
        d = 0;
        {
            xpos = Random.Range(0, 5);
            ypos = Random.Range(0, 5);
            zpos = Random.Range(0, 5);
            obj = Instantiate(players[Random.Range(0, 5)], new Vector3(x[xpos], y[ypos], z[zpos]), Quaternion.Euler(0, -180, 0)) as GameObject;
            obj.SetActive(true);
            d = d + 1;
          
        }
    }
    private IEnumerator timer()
    {

        while (true)
        {
            yield return new WaitForSeconds(1.15f);
            time = time + 1;
            if (time == 3)
            {
                miss.GetComponent<Animation>().Play();
                miss.text = "You Missed";
                score = score - 2;
                SetScoreText();
                time = 0;
               // SetTimeText();
                Destroy(obj);
                xpos = Random.Range(0, 5);
                ypos = Random.Range(0, 5);
                zpos = Random.Range(0, 5);
                obj = Instantiate(players[Random.Range(0, 5)], new Vector3(x[xpos], y[ypos], z[zpos]), Quaternion.Euler(0, -180, 0)) as GameObject;
                obj.SetActive(true);

                d = d + 1;
                if (d == 7 || score == 35)
                {

                    Time.timeScale = 0;
                    if (score >= 35)
                    {
                        SceneManager.LoadScene("level3");
                        Time.timeScale = 1;
                    }
                    else if (score < 35)
                    {
                        SceneManager.LoadScene("level2");
                        Time.timeScale = 1;
                    }

                }
            }
          
        }
       
    }




    // Update is called once per frame
    void FixedUpdate ()
    {
             


		if (Input.GetMouseButtonDown(0) && counter > delayTime) {

			Instantiate (bullet, transform.position, transform.rotation);
			GetComponent<AudioSource> ().Play ();
			counter = 0;
			flash.GetComponent<Animation> ().Play ();
			recoil.GetComponent<Animation> ().Play ();
			RaycastHit hit;
			Ray ray = new Ray (transform.position, transform.forward);
			if (Physics.Raycast (ray, out hit, 100f)) {

				bullethole1= Instantiate (bullethole, hit.point, Quaternion.FromToRotation (Vector3.up, hit.normal)) as GameObject;
				//-----changes here------

				//-----------------------
			
				}
                if (hit.collider.tag == "body") {
					//hit.transform.SendMessage("HitByRay");
                    StopCoroutine(cor);
                    a = a + 10;
					bullethole1.transform.parent = player.transform;

					plane.GetComponent<Animation> ().Play ();
					score = score + 10;
					SetScoreText ();
                    if (d == 7 || score==35)
                    {

                        Time.timeScale = 0;
                        if (score >= 35)
                        {
                            SceneManager.LoadScene("level3");
                            Time.timeScale = 1;
                        }
                        else if (score < 35)
                        {
                            SceneManager.LoadScene("level2");
                            Time.timeScale = 1;
                        }

                    }

                    if (a ==10) 
					{
        
						Destroy (obj);
                        xpos = Random.Range(0, 5);
                        ypos = Random.Range(0, 5);
                        zpos = Random.Range(0, 5);
                        obj = Instantiate(players[Random.Range(0, 5)], new Vector3(x[xpos], y[ypos], z[zpos]), Quaternion.Euler(0, -180, 0)) as GameObject;
                        obj.SetActive(true);
                        a = 0;
                        time = 0;
                       // SetTimeText();
                        StartCoroutine(cor);
                        d = d + 1;
                   
                    }
                  

                }

                else if (hit.collider.tag == "body1") {
                    StopCoroutine(cor);
                    b = b + 5;
					bullethole1.transform.parent = player.transform;
					plane1.GetComponent<Animation> ().Play ();
					score = score + 5;
					SetScoreText ();
                    if (d == 7||score==35)
                    {

                        Time.timeScale = 0;
                        if(score >= 35)
                        {
                            SceneManager.LoadScene("level3");
                            Time.timeScale = 1;
                        }
                        else if(score < 35)
                        {
                            SceneManager.LoadScene("level2");
                            Time.timeScale = 1;
                        }

                    }

                    if (b == 5) 
					{

						Destroy (obj);
                        xpos = Random.Range(0, 5);
                        ypos = Random.Range(0, 5);
                        zpos = Random.Range(0, 5);
                        obj = Instantiate(players[Random.Range(0, 5)], new Vector3(x[xpos], y[ypos], z[zpos]), Quaternion.Euler(0, -180, 0)) as GameObject;
                        obj.SetActive(true);
                        b = 0;
                        time = 0;
                        //SetTimeText();
                        StartCoroutine(cor);
                        d = d + 1;
                       
                    }


                   
                }

                else if (hit.collider.tag == "lower1") {
                    StopCoroutine(cor);
                    c = c + 2;
					bullethole1.transform.parent = player.transform;
                    plane2.GetComponent<Animation>().Play();
					score = score + 2;
					SetScoreText ();
                    if (d == 7||score==35)
                    {

                        Time.timeScale = 0;
                        if (score >= 35)
                        {
                            SceneManager.LoadScene("level3");
                            Time.timeScale = 1;
                        }
                        else if (score < 35)
                        {
                            SceneManager.LoadScene("level2");
                            Time.timeScale = 1;
                        }

                    }
                    if (c==2)
                    {
                        Destroy(obj);
                        xpos = Random.Range(0, 5);
                        ypos = Random.Range(0, 5);
                        zpos = Random.Range(0, 5);
                        obj = Instantiate(players[Random.Range(0, 5)], new Vector3(x[xpos], y[ypos], z[zpos]), Quaternion.Euler(0, -180, 0)) as GameObject;
                        obj.SetActive(true);
                        c = 0;
                        time = 0;
                        //SetTimeText();
                        StartCoroutine(cor);
                        d = d + 1;
                      
                    }
                   

                }

                else if(hit.collider.tag!= "head1" || hit.collider.tag!="lower1" || hit.collider.tag!="body1")
                {
                    score = score - 2;
                    SetScoreText();
                }

             
            }
			


		counter += Time.deltaTime;




	}

	void SetScoreText()
	{

		scoreText.text = "Score:"  + score.ToString ();

	}
    void SetchanceText()
    {
        chanceText.text = "Chances:" + time.ToString();
    }
}
