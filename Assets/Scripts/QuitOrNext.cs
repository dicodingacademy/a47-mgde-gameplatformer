using UnityEngine;
using UnityEngine.SceneManagement;
public class QuitOrNext : MonoBehaviour
{
    public string NameScene = "Level 2";
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag.Equals("Player"))
        {
            SceneManager.LoadScene(NameScene);
        }
    }
}