# Fountain of Objects Game

The Fountain of Objects game is a 2D grid-based world full of rooms. Explore the cavern system, find the Fountain of Objects, activate it, and return to the entrance room to win the game.

## Gameplay Overview

- The game is set in a grid of rooms, each referenced by its row and column.
- Player navigation: "move north," "move south," "move east," and "move west."
- The cavern entrance is at (Row=0, Column=0), and the fountain room is at (Row=0, Column=2).
- The player starts at the entrance and must navigate in the dark, relying on senses.
- Unnatural darkness pervades the caverns, preventing both natural and human-made light.

## Objectives

1. **Sense and Move:**
   - The player is informed of their surroundings (see, hear, smell).
   - Commands like "move north" allow the player to navigate through rooms.

2. **Cavern Entrance and Exit:**
   - The entrance room has light ("You see light in this room coming from outside the cavern. This is the entrance.")
   - The player starts in the entrance room.

3. **Fountain Room:**
   - The fountain room contains the Fountain of Objects.
   - The Fountain can be enabled or disabled.
   - Hear water dripping or rushing waters depending on the state.
   - Type "enable fountain" in the fountain room to activate it.
   - Fountain starts in the disabled state.

4. **Winning the Game:**
   - Win by moving to the fountain room, enabling the Fountain, and returning to the entrance.
   - If the player is in the entrance and the fountain is on, they win.

5. **Text Colors:**
   - Use different colors in the console window for text types (e.g., magenta for narrative, white for descriptive, cyan for user input, yellow for entrance light, blue for fountain messages).

## Instructions

1. Clone the repository.
2. Run the game in a compatible environment.
3. Follow the on-screen instructions to navigate and interact with the game.

Feel free to customize the text colors and formatting based on your preferences.

Enjoy playing the Fountain of Objects game!
