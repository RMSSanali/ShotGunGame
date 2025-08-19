# Shotgun – Windows Forms Game 🎯

This repository contains my implementation of the **Shotgun** game as part of *Inlämningsuppgift 2* in the course **Objektorienterad programmering med C# .NET**.  
The player competes against the computer using actions **Shoot**, **Load**, **Block**, and the special **Shotgun** move.

---

## Table of Contents
- Extended Description
- Assignment Scope
- Game Rules
- How to Run Locally
- Implementation Notes (OOP)
- Screenshots / Demo
- Project Documentation
- Author
- Assignment Status

---

## Extended Description
This project was created during the course *Objektorienterad programmering med C# .NET*.  
The task was to build a playable **Windows Forms (WinForms)** application where the user plays *Shotgun* against a computer opponent that picks moves randomly.

Key objectives:
- Show each player’s current bullet count clearly at all times.
- Prevent shooting unless the player has bullets (same for the computer).
- Announce the winner and allow “Play Again.”
- Enable the **Shotgun** action only when the player has **≥ 3 bullets**.
- Write clean, object-oriented C# code following the course guidelines.

All core features are implemented as required for a passing grade (G).

---

## Assignment Scope
This submission focuses on:
- A functional **WinForms UI** for interaction and status display.
- A **game engine** enforcing rules, turn results, and win conditions.
- A **simple AI** (random move selection).

Optional improvements (not required for G) are noted in the roadmap and can be added later (e.g., smarter AI).

---

## Game Rules
- **Load vs Load** → Both players gain **+1 bullet**.  
- **Load vs Block** → The loading player gains **+1 bullet**.  
- **Block vs Block** → No change.  
- **Shoot vs Block** → The shooter **loses 1 bullet**.  
- **Shoot vs Shoot** → Both players **lose 1 bullet**.  
- **Shoot vs Load** → **Shooter wins** the game.  
- **Shotgun (needs 3+ bullets)** → **Instant win** (even if opponent shoots or blocks).

---

## How to Run Locally
1. **Clone** the repo:
   ```bash
   git clone https://github.com/<your-username>/ShotgunGame.git

   
## Implementation Notes (OOP)

- **GameState** class to track bullets, last moves, and win state.

- **Player** abstraction for Human and Computer:

  - Human: selected via UI buttons.

  - Computer: random strategy (can be extended).

- **GameEngine** service:

  - Validates actions (e.g., cannot Shoot with 0 bullets).

  - Resolves round outcomes based on rules.

  - Exposes events/results to the UI.

- **WinForms** UI:

  - Clearly displays bullet counts and last actions.

  - Disables invalid buttons (e.g., Shoot when bullets = 0; Shotgun when bullets < 3).

  - Dialog to show winner and Play Again option.

- **Roadmap (optional):**

    - Smarter AI (avoid “Block” when opponent has 0 bullets, etc.)
    - Sound effects and animations
    - Persistent high scores

## Screenshots / Demo

<p align="center">
  <img src="https://github.com/user-attachments/assets/dcbc1273-f3a8-4bd6-906b-10f5af25c480" width="400"/>
  <img src="https://github.com/user-attachments/assets/5ba5fec1-a5a2-4086-a3c9-f0f0c5ede2a7" width="400"/>
</p>
<p align="center"><em>Player loads a bullet while opponent blocks</em></p>

<p align="center">
  <img src="https://github.com/user-attachments/assets/d00d211a-e9f2-4bd8-9a15-5373fe6e2bf1" width="400"/>
  <img src="https://github.com/user-attachments/assets/e77a9eb5-91cd-4b18-827f-fd3beb78f8af" width="400"/>
</p>
<p align="center"><em>Shooting action and empty bullets warning</em></p>

<p align="center">
  <img src="https://github.com/user-attachments/assets/8bba091d-ba9d-4f59-b69a-a4069cbfb1e4" width="400"/>
</p>
<p align="center"><em>Shotgun move → instant win</em></p>

## 📄 Project Documentation

A short technical note is included in the repo (e.g., docs/notes.md) describing:

- Class responsibilities (GameState, GameEngine, Player).
- UI flow and state updates.
- How to extend AI logic.

## 👤 Author
Sanali Sewwandi
Cloud Developer Student – CUA24S
JENSEN Yrkeshögskola, 2025
