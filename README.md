# KartChaos – Semester 3 Field Project

**KartChaos** is a fast-paced 2D local co-op game built in **Unity 6** where two players must coordinate to control a single vehicle. Developed as a Semester 3 Field Project, this game explores unique control mechanics and teamwork-based gameplay.

---

## Gameplay and Mechanics
The game features a dual-control system inspired by classic titles like Atari's FireTruck. Responsibility for movement is split across the keyboard to encourage real-time cooperation:

* **Upward Movement:** Controlled by Player 1 using `Left Shift` + `A`.
* **Downward Movement:** Controlled by Player 2 using `Right Shift` + `L`.

### Health and Survival System
To move beyond a "one-hit-game-over" mechanic, I implemented a balanced health system to reward skilled play and recovery:

| Action | Impact |
| :--- | :--- |
| **Start Health** | 100 HP |
| **Obstacle Collision** | -20 HP |
| **Coin Collection** | +10 HP |
| **Progression** | Speed increases every 20 points |

---

## Development Journey
This project served as a significant learning milestone, transitioning from minimal Unity experience to a functional prototype.

* **Learning the Engine:** Built from the ground up by studying Unity documentation and resources like Game Maker's Toolkit to master C# scripting and 2D physics.
* **Balancing Difficulty:** Iterated from a punishing single-hit system to a health-based model, creating a more forgiving and engaging experience.
* **Audio Integration:** Sourced royalty-free assets from Zapsplat to provide tactile audio feedback for collisions and rewards.

---

## Tech Stack
* **Engine:** Unity Engine 6 (2D)
* **Language:** C#
* **Data:** `PlayerPrefs` for local high score persistence

---

## Future Goals
* **Customization:** Adding kart and obstacle skins to allow for creative freedom.
* **Connectivity:** Exploring online multiplayer functionality to expand beyond local co-op.

> **Developer:** [Siddhesh Umesh Sarang](https://siddheshumeshsarang.web.app)
