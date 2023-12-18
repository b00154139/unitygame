using UnityEngine;

public class PlayerBorder : MonoBehaviour
{
    public enum EPlayer // Renamed to avoid naming conflicts
    {
        Left,
        Right
    }

    public EPlayer player;
    public Score Score; 

    void OnCollisionEnter(Collision col)
    {
        Ball ball = col.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            ball.transform.position = new Vector3(0f, 1f, 0f);

            if (player == EPlayer.Right)
            {
                Score.scorePlayerRight++;
            }
            else if (player == EPlayer.Left)
            {
                Score.scorePlayerLeft++;
            }

            // Reset the game
            GameManager.Instance.ResetGame();
        }
    }
}