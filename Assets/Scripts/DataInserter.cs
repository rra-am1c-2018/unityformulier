using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DataInserter : MonoBehaviour {

    [SerializeField]
	private Text avatarName;
    [SerializeField]
	private Text age;
    [SerializeField]
    private int score;

	private string CreateUserURL = "http://www.loginregistration.am1c.org/insertuser.php";
    
    public Text AvatarName
    {
        get { return this.avatarName; }
        set { this.avatarName = value; }
    }
    
    public Text Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public int Score
    {
        get { return this.score; }
        set { this.score = value; }
    }

	// Use this for initialization
	void Start () {
        this.score = 320;
	}
	
	// Update is called once per frame
	void Update () {		
	}

	public void Klik(){
		CreateUser(this.avatarName.text, this.age.text, this.score);
        this.score += 200;
	}

	public void CreateUser(string avatarName, string age, int score){
		WWWForm form = new WWWForm();
		form.AddField("avatarNamePost", avatarName);
		form.AddField("agePost", age);
        form.AddField("score", score);

		WWW www = new WWW(CreateUserURL, form);
	}

}
