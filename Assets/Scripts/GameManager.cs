using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    //Setup our singleton.
    public static GameManager instance;
    public List<TankData> tanks;
    public List<InputController> players;

    void Awake()
    {
        //If singleton already exists.
        if (instance != null)
        {
            //Self-destruct
            Destroy(gameObject);
        }
        else
        {
            //Otherwise, I am the instance.
            instance = this;
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
