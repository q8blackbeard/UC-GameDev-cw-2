using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    int Score = 0;
    public void IncreaseScore()
    {
        Score += 1;

        print(Score);

}
}
