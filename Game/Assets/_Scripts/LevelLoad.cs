using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour {

    [SerializeField] int timeToWait = 2;
	int currentSceneIndex;

	// Use this for initialization
	void Start () {
		currentSceneIndex = SceneManager.GetActiveScene ().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(waitForTime());
        }
	}
	
    IEnumerator waitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        loadNextLevel();
    }

    public void loadNextLevel()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
