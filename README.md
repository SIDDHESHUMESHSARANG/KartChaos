# KartChaos - Semester 3 Field Project

**[span_0](start_span)[span_1](start_span)KartChaos** is a fast-paced 2D local co-op game built in Unity 6 where two players must coordinate to control a single vehicle[span_0](end_span)[span_1](end_span). [span_2](start_span)[span_3](start_span)[span_4](start_span)This project was developed as a Semester 3 Field Project to explore unique control mechanics and teamwork-based gameplay[span_2](end_span)[span_3](end_span)[span_4](end_span).

## Gameplay and Mechanics
[span_5](start_span)The game features a dual-control system inspired by classic titles like Atari's *FireTruck*[span_5](end_span). Responsibility for movement is split across the keyboard to encourage real-time cooperation:
* **[span_6](start_span)Upward Movement:** Controlled by one player using Left Shift + A[span_6](end_span).
* **[span_7](start_span)Downward Movement:** Controlled by the second player using Right Shift + L[span_7](end_span).

[span_8](start_span)Players must navigate through obstacles and collect coins to survive[span_8](end_span). To make the experience more engaging and fair, I implemented a health system:
* [span_9](start_span)The kart starts with 100 health points[span_9](end_span).
* [span_10](start_span)Colliding with an obstacle reduces health by 20 points[span_10](end_span).
* [span_11](start_span)Collecting a coin restores 10 health points[span_11](end_span).
* [span_12](start_span)The game features endless progression, increasing in speed every 20 points[span_12](end_span).

## Development Journey
[span_13](start_span)This project was a significant learning milestone, as I started with minimal Unity experience[span_13](end_span). Key challenges included:
* **[span_14](start_span)Learning the Engine:** I built the game from the ground up by studying Unity documentation and resources like Game Maker's Toolkit to master C# scripting and 2D physics[span_14](end_span).
* **[span_15](start_span)Balancing Difficulty:** Early versions felt frustrating because the game ended on a single hit[span_15](end_span). [span_16](start_span)[span_17](start_span)Transitioning to a health-based system allowed for a more skill-based, forgiving experience that rewards recovery[span_16](end_span)[span_17](end_span).
* **[span_18](start_span)Audio Integration:** Sourcing royalty-free assets from libraries like Zapsplat helped create an immersive atmosphere with distinct feedback for collisions and coin collection[span_18](end_span).

## Tech Stack
* **[span_19](start_span)Engine:** Unity Engine 6 (2D)[span_19](end_span).
* **[span_20](start_span)Language:** C#[span_20](end_span).
* **[span_21](start_span)Data:** PlayerPrefs for local high score saving[span_21](end_span).

## Future Goals
[span_22](start_span)I plan to add kart and obstacle customization to give players more creative freedom[span_22](end_span). [span_23](start_span)I am also interested in exploring online multiplayer functionality to expand the game beyond local play[span_23](end_span).

---
**[span_24](start_span)Developer:** [Siddhesh Umesh Sarang](https://siddheshumeshsarang.vercel.app)[span_24](end_span)