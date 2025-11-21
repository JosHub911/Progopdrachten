# Progopdrachten M5

## Les 1
In deze opdracht worden pilaren gespawned door op het scherm te klikken.

**Script:**  
[Spawner](Assets/Scripts/Spawner.cs)

**Resultaat:**  
![Pillaren](https://github.com/user-attachments/assets/da09766f-c696-4f0d-84bc-c2c7b2675c14)



Daarnaast spawnen ballen automatisch iedere seconde.

**Script:**  
[Balls](Assets/Scripts/Ballen.cs)

**Resultaat:**  
![Balls](https://github.com/user-attachments/assets/76d43bbc-c929-4bb8-8c3b-a12aac78252c)

---

## Les 2
Coin system: een speler (blok) verzamelt coins en de score wordt live bijgewerkt.

**Script:**  
[ScoreSystem](Assets/Scripts/ScoreSystem.cs)

**Resultaat:**  
![CoinCollect](https://github.com/user-attachments/assets/5cdbe098-8d1a-4b58-aae8-15fac447533d)

---

## Les 3
Debugging-opdracht. Document met uitleg en gevonden bugs:

**Document:**  
https://docs.google.com/document/d/1A9Way1L0EpJQ_nYAU97fFFEAygIEalajdR3z9GcCELA/edit?usp=sharing

Bugs gevonden in de Tower Defence game.  
De opdracht “Mythe” ontbreekt.

**Screenshot:**  
<img width="1849" height="940" alt="Screenshot 2025-10-10 091009" src="https://github.com/user-attachments/assets/1df9183e-362b-4b24-a1f9-b017a2252104" />

---

## Les 4
Alle scripts van de Space Shooter zijn herschreven volgens het Single Responsibility Principle.

**Map:**  
[Scripts](Assets/Scripts/Spaceshooter)

**Resultaat:**  
![Spaceshooter](https://github.com/user-attachments/assets/d9751b27-2152-477e-8509-4377636e682c)

---

## Les 5
Nog niet uitgevoerd.

---

## Les 6
Dependency analyse.

**Document:**  
https://docs.google.com/document/d/1bXBO7FFVSXiE5CwlVJwobjQiokGVwQ9dZ05z7R6Xghg/edit?usp=sharing


# Progopdrachten M6

## Les 1

Moet nog een Gif van maken

## Les 2

**Class Diagrams van mijn TD game**

+-------------------+
|       Bullet      |
+-------------------+
| - damage: int     |
| - lifeTime: float |
+-------------------+
| + Start()         |
| + OnTriggerEnter2D(collider) |
+-------------------+
        |
        v
   interacts with
+-------------------+
|  Enemymovement /  |
|      Enemy        |
+-------------------+
| - health: int     |
| - cashReward: int |
| - spriteRenderers |
| - visuals: Transform |
+-------------------+
| + TakeDamage(dmg) |
| + KillEnemy()     |
| + FlashEffect()   |
+-------------------+

+-------------------+
|   EnemySpawner    |
+-------------------+
| - enemyTypes[]    |
| - baseEnemies     |
| - enemiesPerSecond|
| - maxWaves        |
| - currentWave     |
+-------------------+
| + SpawnEnemy()    |
| + EnemyDestroyed()|
| + IsAllWavesDone()|
+-------------------+
        ^
        |
      spawns
+-------------------+
|   EnemyType       |
+-------------------+
| - prefab: GameObject |
| - spawnWeight       |
| - minSpeed / maxSpeed|
| - weightIncreasePerWave|
+-------------------+

+-------------------+
|  Enemymovement    |
+-------------------+
| - rb: Rigidbody2D |
| - moveSpeed: float|
| - health: int     |
| - target          |
| - PathIndex       |
+-------------------+
| + TakeDamage(dmg) |
+-------------------+
        ^
        |
+-------------------+
| StraightEnemy     |
+-------------------+
| - rb: Rigidbody2D |
| - moveSpeed       |
| - target          |
| - pathIndex       |
+-------------------+
| + SetSpeed()      |
+-------------------+
        ^
        |
+-------------------+
| ZigZagEnemy       |
+-------------------+
| - zigzagAmplitude |
| - zigzagFrequency |
| - time: float     |
+-------------------+
| + SetSpeed()      |
+-------------------+

+-------------------+
|     Turret        |
+-------------------+
| - range           |
| - fireRate        |
| - bulletPrefab    |
| - firePoint       |
| - bulletSpeed     |
| - turnSpeed       |
| - target          |
+-------------------+
| + Update()        |
| + Shoot()         |
| + EnemyLockOn()   |
+-------------------+
        |
        v
      shoots
+-------------------+
|      Bullet       |
+-------------------+

+-------------------+
|   PlayerShoot     |
+-------------------+
| - shootingPoint   |
| - bulletPrefab    |
| - bulletSpeed     |
| - bulletCooldown  |
| - spreadAngle     |
+-------------------+
| + Shoot(dir)      |
| + ApplySpread(dir)|
| + GetMouseDirection()|
+-------------------+
        |
        v
      spawns
+-------------------+
|      Bullet       |
+-------------------+

+-------------------+
|   PopupSpawner    |
+-------------------+
| - popupPrefab     |
| - player: Transform|
+-------------------+
| + SpawnPopup(msg) |
+-------------------+
        |
        v
+-------------------+
|   PopupText       |
+-------------------+
| - text: TMP_Text  |
| + Show(msg)       |
+-------------------+

+-------------------+
|  ScreenFlash      |
+-------------------+
| - flashImg: Image |
| + Flash()         |
+-------------------+

+-------------------+
| UIManager / UIAnimator |
+-------------------+
| - redPanel: Image  |
| - popupPrefab      |
| - playerTransform  |
| + RedFlash()       |
| + ShowPopup(text)  |
| + Fade()           |
| + Slide()          |
+-------------------+

+-------------------+
| CashSystem        |
+-------------------+
| - cashAmount: int |
| - cashText: TMP   |
+-------------------+
| + AddCash()       |
| + SpendCash()     |
+-------------------+

+-------------------+
| TurretBuildManager|
+-------------------+
| + PlaceTurret(prefab,pos) |
+-------------------+
        ^
        |
      used by
+-------------------+
| TurretDragUI      |
+-------------------+
| - turretPrefab    |
| - turretCost      |
+-------------------+
| + OnBeginDrag()   |
| + OnDrag()        |
| + OnEndDrag()     |
+-------------------+

+-------------------+
| SoundManager      |
+-------------------+
| - sfxSource       |
| - musicSource     |
| - clips           |
+-------------------+
| + PlayShoot()     |
| + PlayPlaceTower()|
| + PlayBackgroundMusic()|
+-------------------+

+-------------------+
| LevelManager      |
+-------------------+
| - lives           |
| - Path[]          |
| - Healthbar       |
| - gameOverUI      |
+-------------------+
| + LoseLife()      |
| + GameOver()      |
| + RestartLevel()  |
| + LoadMainMenu()  |
+-------------------+

+-------------------+
| CamShake          |
+-------------------+
| + Shake(duration,strength) |
+-------------------+

+-------------------+
| CameraDrag        |
+-------------------+
| - panSpeed        |
| - bounds          |
| - useBounds       |
| + StartDrag()     |
| + ContinueDrag()  |
| + EndDrag()       |
+-------------------+

+-------------------+
| EndlessRunner     |
+-------------------+
| - vbegin, g       |
| - velocity        |
| - acceleration    |
| - State enum      |
| - t, tmax         |
+-------------------+

+-------------------+
| Shooting          |
+-------------------+
| - lifetime        |
+-------------------+

+-------------------+
| Background        |
+-------------------+
| - bgBackground: Renderer|
| - speed          |
+-------------------+

+-------------------+
| SceneSwitcher     |
+-------------------+
| - nextSceneName   |
| - spawner         |
+-------------------+


