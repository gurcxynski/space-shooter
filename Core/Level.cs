using System.Text.Json.Serialization;

namespace Spaceshooter.Core
{
    public class Level
    {
        [JsonInclude] public int PlayerHP;
        [JsonInclude] public int PlayerLives;
        [JsonInclude] public float PlayerShootingSpeed;
        [JsonInclude] public float EnemyShootingSpeed;
        [JsonInclude] public int SimpleEnemies;
        [JsonInclude] public int SimpleEnemiesHP;
        [JsonInclude] public int MediumEnemies;
        [JsonInclude] public int MediumEnemiesHP;
        [JsonInclude] public bool Boss;
    }
}