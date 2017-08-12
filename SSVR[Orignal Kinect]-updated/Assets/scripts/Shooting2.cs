using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shooting2 : MonoBehaviour
{

    public GameObject bullet;
    public GameObject bullethole;
    public GameObject recoil;
    public GameObject flash;
    public GameObject plane;
    public GameObject plane1;
    public GameObject plane2;
    public GameObject head1;
    public GameObject body1;
    public GameObject lower1;
    public GameObject target1;
    public int a = 0;
    public int b = 0;
    public int c = 0;
    public float delayTime = 8;
    public Text scoreText;
    public int score;
    GameObject bullethole1;
    //GameObject tar;
    public float[] x;
    public float[] y;
    public float[] z;
    int xpos, ypos, zpos;
    GameObject ab;

    private float counter = 0;
    // Use this for initialization
    void Start()
    {
        score = 0;
        a = 0;
        b = 0;
        c = 0;
        SetScoreText();
        xpos = Random.Range(0, 10);
        ypos = xpos;
        zpos = xpos;
        ab= Instantiate(target1, new Vector3(x[xpos], y[ypos], z[zpos]), Quaternion.Euler(0, -180, 0)) as GameObject;
        ab.SetActive(true);

    }



    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.anyKey == true && counter > delayTime)
        {

            Instantiate(bullet, transform.position, transform.rotation);
            GetComponent<AudioSource>().Play();
            counter = 0;
            flash.GetComponent<Animation>().Play();
            recoil.GetComponent<Animation>().Play();
            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(ray, out hit, 100f))
            {

                bullethole1 = Instantiate(bullethole, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal)) as GameObject;

                if (hit.collider.tag == "head1")
                {

                    //bullethole1.transform.parent = target.transform;
                    a= a+10;
                    plane.GetComponent<Animation>().Play();
                  
                    score = score + 10;
                    SetScoreText();
                   if(a==10)
                    {
                        target1.GetComponent<Animation>().Play();
                        Destroy(ab);
                        xpos = Random.Range(0, 10);
                        ypos = xpos;
                        zpos = xpos;
                        ab = Instantiate(target1, new Vector3(x[xpos], y[ypos], z[zpos]), Quaternion.Euler(0, -180, 0)) as GameObject;
                        ab.SetActive(true);
                        a = 0;
                    }
                
            
            
     

                }

                else if (hit.collider.tag == "body1")
                {

                    b=b+5;
                    //bullethole1.transform.parent = target1.transform;
                    plane1.GetComponent<Animation>().Play();
                  
                    score = score + 5;
                    SetScoreText();
                    if(b==5)
                    {
                        target1.GetComponent<Animation>().Play();
                        Destroy(ab);
                        xpos = Random.Range(0, 10);
                        ypos = xpos;
                        zpos = xpos;
                        ab = Instantiate(target1, new Vector3(x[xpos], y[ypos],z[zpos]), Quaternion.Euler(0, -180, 0)) as GameObject;
                        ab.SetActive(true);
                        b = 0;
                    }
                
                


                }

                else if (hit.collider.tag == "lower1")
                {

                    c=c+2;
                    plane2.GetComponent<Animation>().Play();
                   
                    score = score + 2;
                    SetScoreText();
                    if(c==2)
                    {
                        target1.GetComponent<Animation>().Play();
                        Destroy(ab);
                        xpos = Random.Range(0, 10);
                        ypos = xpos;
                        zpos = xpos;
                        ab = Instantiate(target1, new Vector3(x[xpos], y[ypos], z[zpos]), Quaternion.Euler(0, -180, 0)) as GameObject;
                        ab.SetActive(true);
                        c = 0;
                    }
                  





                }



            }

        }


        counter += Time.deltaTime;




    }

    void SetScoreText()
    {
        scoreText.text = "Score:" + score.ToString();

    }

}
