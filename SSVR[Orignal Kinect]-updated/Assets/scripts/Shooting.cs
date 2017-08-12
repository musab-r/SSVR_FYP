using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shooting : MonoBehaviour {

	public GameObject bullet;
	public GameObject bullethole;
	public GameObject recoil;
	public GameObject flash;
	public GameObject plane;
	public GameObject plane1;
	public GameObject plane2;
	public GameObject head1;
	public GameObject head2;
	public GameObject head3;
	public GameObject body1;
	public GameObject body2;
	public GameObject body3;
	public GameObject lower1;
	public GameObject lower2;
	public GameObject lower3;
	public GameObject target;
	public GameObject target1;
	public GameObject target2;
	public GameObject anim2;
	public GameObject anim3;
	public int a= 0;
	public int b=0;
	public int c= 0;
    public Text timeText;
    public int time;
    public float delayTime = 8;
	public Text scoreText;
	public int score;
    public int sec;
 	GameObject bullethole1;
    private IEnumerator cor;
    public Text GoodText;
    public Text BetterText;
    public Text BadText;
    public Text VeryBadText;
    public Text MissText;
    public Text ExitText;
    public Text GameOverText;
    public GameObject canva;
    public GameObject canva1;
    public GameObject canva2;
    public GameObject canva3;
    public GameObject canva4;
    public GameObject GameOver;
    public GameObject Exit;

	private float counter=0;
	// Use this for initialization
	void Start () 
	{
		score = 0;
		SetScoreText ();
        time = 0;
        SetTimeText();
        cor = timer();
        StartCoroutine(cor);
        SetBetterText();
        SetBadText();
        SetVeryBadText();
        SetGoodText();

		
	}

    private IEnumerator timer()
    {

        while (true)
        {
            yield return new WaitForSeconds(1);
            time = time + 1;
            SetTimeText();
        }

    }


	// Update is called once per frame
	void FixedUpdate () {

      
		if (Input.anyKey == true && counter > delayTime) 
        {
			Instantiate (bullet, transform.position, transform.rotation);
			GetComponent<AudioSource> ().Play ();
			counter = 0;
			flash.GetComponent<Animation> ().Play ();
			recoil.GetComponent<Animation> ().Play ();
			RaycastHit hit;
			Ray ray = new Ray (transform.position, transform.forward);
			if (Physics.Raycast (ray, out hit, 100f)) {
				
				bullethole1= Instantiate (bullethole, hit.point, Quaternion.FromToRotation (Vector3.up, hit.normal)) as GameObject;

                if (hit.collider.tag == "head1")
                {
                    {
                        StopCoroutine(cor);
                        if (time <= 5)
                        {
                            SetGoodText();
                            canva.GetComponent<Animation>().Play();
                        }
                        else if (time <= 10)
                        {
                            SetBetterText();
                            canva1.GetComponent<Animation>().Play();
                            score = score - 2;
                            SetScoreText();
                        }
                        else if (time <= 15)
                        {
                            SetBadText();
                            canva2.GetComponent<Animation>().Play();
                            score = score - 4;
                            SetScoreText();
                        }
                        else if (time > 15)
                        {
                            SetVeryBadText();
                            canva3.GetComponent<Animation>().Play();
                            score = score - 6;
                            SetScoreText();
                        }
                        time = 0;
                        SetTimeText();
                    }
                    StartCoroutine(cor);

                    b++;
                    time = 0;
                    bullethole1.transform.parent = target.transform;
                    SetTimeText();
                    plane.GetComponent<Animation>().Play();
                    score = score + 10;
                    SetScoreText();
                    if (score >= 60)
                    {

                        SceneManager.LoadScene("level2");
                    }

                    if (b == 3)
                    {
                        anim2.GetComponent<Animation>().Play();
                        target2.GetComponent<MeshRenderer>().enabled = true;
                    }

                   

                } 

				else if (hit.collider.tag == "body1") {
                    {
                        StopCoroutine(cor);
                        if (time <= 5)
                        {
                            SetBetterText();
                            canva1.GetComponent<Animation>().Play();

                        }
                        else if (time <= 10)
                        {
                            SetBadText();
                            canva2.GetComponent<Animation>().Play();
                            score = score - 2;
                            SetScoreText();

                        }
                        else if (time <= 15)
                        {
                            SetBadText();
                            canva2.GetComponent<Animation>().Play();
                            score = score - 3;
                        }
                        else if (time > 15)
                        {
                            SetVeryBadText();
                            canva3.GetComponent<Animation>().Play();
                            score = score - 4;
                        }
                        time = 0;
                        SetTimeText();
                    }

                    StartCoroutine(cor);

					b++;
					plane1.GetComponent<Animation> ().Play ();
                    bullethole1.transform.parent = target.transform;
                    score = score + 5;
					SetScoreText ();
                    if (score >= 60)
                    {

                        SceneManager.LoadScene("level2");
                    }

                    if (b == 3) 
					{
						anim2.GetComponent<Animation> ().Play ();
						target2.GetComponent<MeshRenderer> ().enabled = true;
					}


					
						

				} 

				else if (hit.collider.tag == "lower1") {

                    {
                        StopCoroutine(cor);
                        if (time <= 5)
                        {
                            SetBadText();
                            canva2.GetComponent<Animation>().Play();

                        }
                        else if (time <= 10)
                        {
                            SetBadText();
                            canva2.GetComponent<Animation>().Play();

                        }
                        else if (time <= 15)
                        {
                            SetVeryBadText();
                            canva3.GetComponent<Animation>().Play();
                            score = score - 1;
                        }
                        if (time > 15)
                        {
                            SetVeryBadText();
                            score = score - 2;
                        }
                        time = 0;
                        SetTimeText();
                    }

                    StartCoroutine(cor);

					b++;
					plane2.GetComponent<Animation> ().Play ();
                    bullethole1.transform.parent = target.transform;
                    score = score + 2;
					SetScoreText ();
                    if (score >= 60)
                    {

                        SceneManager.LoadScene("level2");
                    }

                    if (b == 3) 
					{
						anim2.GetComponent<Animation> ().Play ();
						target2.GetComponent<MeshRenderer> ().enabled = true;
					}


				
				
				}

				else if (hit.collider.tag == "head2") 
				{
                    {
                        StopCoroutine(cor);
                        if(time<=5)
                        {
                            SetGoodText();
                            canva.GetComponent<Animation>().Play();
                        }
                        else if(time<=10)
                        {
                             SetBetterText();
                            canva1.GetComponent<Animation>().Play();
                            score = score - 2;
                            SetScoreText();
                        }
                        else if(time<=15)
                        {
                             SetBadText();
                            canva2.GetComponent<Animation>().Play();
                            score = score - 4;
                            SetScoreText();
                        }
                        else if(time>15)
                        {
                             SetVeryBadText();
                            canva3.GetComponent<Animation>().Play();
                            score = score - 6;
                            SetScoreText();
                        }
                        time = 0;
                        SetTimeText();
                    }
                    StartCoroutine(cor);
					a++;
                    bullethole1.transform.parent = target1.transform;
                    plane.GetComponent<Animation> ().Play ();
					score = score + 10;
					SetScoreText ();
					if (a == 3) 
					{
						target.GetComponent<Animation> ().Play ();
						target1.GetComponent<MeshRenderer> ().enabled = true;

					}


				} 

				else if (hit.collider.tag == "body2") 
				{
                   
                    {
                        StopCoroutine(cor);
                        if (time <= 5)
                        {
                            SetBetterText();
                            canva1.GetComponent<Animation>().Play();
                             
                        }
                        else  if (time <= 10)
                        {
                            SetBadText();
                            canva2.GetComponent<Animation>().Play();
                            score = score - 2;
                            SetScoreText();

                        }
                        else if (time <= 15)
                        {
                            SetBadText();
                            canva2.GetComponent<Animation>().Play();
                            score = score - 3;
                        }
                        else if (time > 15)
                        {
                            SetVeryBadText();
                            canva3.GetComponent<Animation>().Play();
                            score = score - 4;
                        }
                        time = 0;
                        SetTimeText();
                    }

                    StartCoroutine(cor);
                    a++;
                    bullethole1.transform.parent = target1.transform;
                    plane1.GetComponent<Animation> ().Play ();
					score = score + 5;
					SetScoreText ();
					if (a == 3) 
					{
						target.GetComponent<Animation> ().Play ();
						target1.GetComponent<MeshRenderer> ().enabled = true;

					}
			
				} 

				else if (hit.collider.tag == "lower2") 
				{

                    {
                        StopCoroutine(cor);
                        if (time <= 5)
                        {
                            SetBadText();
                            canva2.GetComponent<Animation>().Play();

                        }
                        else if (time <= 10)
                        {
                            SetBadText();
                            canva2.GetComponent<Animation>().Play();

                        }
                        else if (time <= 15)
                        {
                            SetVeryBadText();
                            canva3.GetComponent<Animation>().Play();
                            score = score - 1;
                        }
                        if (time > 15)
                        {
                            SetVeryBadText();
                            score = score - 2;
                        }
                        time = 0;
                        SetTimeText();
                    }

                    StartCoroutine(cor);

					a++;
                    bullethole1.transform.parent = target1.transform;
                    plane2.GetComponent<Animation> ().Play ();
					score = score + 2;
					SetScoreText ();
					if (a == 3) 
					{
						target.GetComponent<Animation> ().Play ();
						target1.GetComponent<MeshRenderer> ().enabled = true;
					}
				
				} 

				else if (hit.collider.tag == "head3") 
				{
              
                    
                    {
                        StopCoroutine(cor);
                        if (time <= 5)
                        {
                            SetGoodText();
                            canva.GetComponent<Animation>().Play();
                        }
                        else if (time <= 10)
                        {
                            SetBetterText();
                            canva1.GetComponent<Animation>().Play();
                            score = score - 2;
                            SetScoreText();
                        }
                        else if (time <= 15)
                        {
                            SetBadText();
                            canva2.GetComponent<Animation>().Play();
                            score = score - 4;
                            SetScoreText();
                        }
                        else if (time > 15)
                        {
                            SetVeryBadText();
                            canva3.GetComponent<Animation>().Play();
                            score = score - 6;
                            SetScoreText();
                        }
                        time = 0;
                        SetTimeText();
                    }
                    StartCoroutine(cor);

					c++;
                    bullethole1.transform.parent = target2.transform;
                    plane.GetComponent<Animation> ().Play ();
					score = score + 10;
					SetScoreText ();
                    if (score >= 60)
                    {

                        SceneManager.LoadScene("level2");
                    }

                    if (c == 3 && score != 60)
                    {
                        anim3.GetComponent<Animation>().Play();
                        StopCoroutine(cor);
                        GameOver.GetComponent<Text>().enabled = true;
                        GameOverText.text = "Play Again";
                        Exit.GetComponent<Text>().enabled = true;
                        ExitText.text = "Exit";

                    }


				
                   


				} 

				else if (hit.collider.tag == "body3") 
				{
                    {
                        StopCoroutine(cor);
                        if (time <= 5)
                        {
                            SetBetterText();
                            canva1.GetComponent<Animation>().Play();

                        }
                        else if (time <= 10)
                        {
                            SetBadText();
                            canva2.GetComponent<Animation>().Play();
                            score = score - 2;
                            SetScoreText();

                        }
                        else if (time <= 15)
                        {
                            SetBadText();
                            canva2.GetComponent<Animation>().Play();
                            score = score - 3;
                        }
                        else if (time > 15)
                        {
                            SetVeryBadText();
                            canva3.GetComponent<Animation>().Play();
                            score = score - 4;
                        }
                        time = 0;
                        SetTimeText();
                    }

                    StartCoroutine(cor);

					c++;
                    bullethole1.transform.parent = target2.transform;
                    plane1.GetComponent<Animation> ().Play ();
					score = score + 5;
					SetScoreText ();
                    if (score >= 60)
                    {

                        SceneManager.LoadScene("level2");
                    }
                    if (c == 3 && score!=60) 
					{
						anim3.GetComponent<Animation> ().Play ();
                        StopCoroutine(cor);
                        GameOver.GetComponent<Text>().enabled = true;
                        GameOverText.text = "Play Again";
                        Exit.GetComponent<Text>().enabled = true;
                        ExitText.text = "Exit";

					}


					




				} 

				else if (hit.collider.tag == "lower3") 
				{
                    {
                        StopCoroutine(cor);
                        if (time <= 5)
                        {
                            SetBadText();
                            canva2.GetComponent<Animation>().Play();

                        }
                        else if (time <= 10)
                        {
                            SetBadText();
                            canva2.GetComponent<Animation>().Play();

                        }
                        else if (time <= 15)
                        {
                            SetVeryBadText();
                            canva3.GetComponent<Animation>().Play();
                            score = score - 1;
                        }
                        if (time > 15)
                        {
                            SetVeryBadText();
                            score = score - 2;
                        }
                        time = 0;
                        SetTimeText();
                    }

                    StartCoroutine(cor);

					c++;
                    bullethole1.transform.parent = target2.transform;
                    plane2.GetComponent<Animation> ().Play ();
					score = score + 2;
					SetScoreText ();
                    if (score >= 60)
                    {

                        SceneManager.LoadScene("level2");
                    }

                    if (c == 3 && score < 60)
                    {
                        anim3.GetComponent<Animation>().Play();
                        StopCoroutine(cor);
                        GameOver.GetComponent<Text>().enabled = true;
                        GameOverText.text = "Play Again";
                        Exit.GetComponent<Text>().enabled = true;
                        ExitText.text = "Exit";

                    }


				



				}
                else if(hit.collider.tag!="head2"|| hit.collider.tag!="body2"||hit.collider.tag != "lower2"||hit.collider.tag != "head1"|| hit.collider.tag != "body1" || hit.collider.tag != "lower1" || hit.collider.tag != "head3" || hit.collider.tag != "body3" || hit.collider.tag != "lower3")
                {

                    MissText.text = "You Missed The Target!!";
                    canva4.GetComponent<Animation>().Play();
                    score = score - 2;
                    SetScoreText();
                }
						
			}

		}


			counter += Time.deltaTime;
		


	
}

	void SetScoreText()
	{
		scoreText.text = "Score:"  + score.ToString ();

	}

    void SetTimeText()
    {
        timeText.text = "Time:" + time.ToString();
    }

    void SetGoodText()
    {
        GoodText.text = "Excellent!!";
    }

    void SetBetterText()
    {
        BetterText.text = "Good Job!";
    }
    void SetBadText()
    {
        BadText.text = "Bad";
    }
    void SetVeryBadText()
    {
        VeryBadText.text = "Poor";
    }
}
