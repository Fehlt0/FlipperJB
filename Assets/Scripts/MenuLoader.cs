using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuLoader : MonoBehaviour
{
    [SerializeField] private int levelNumber;
    
    
    public void GoNextLevel()
    {
        SceneManager.LoadScene(levelNumber);
    }
}
