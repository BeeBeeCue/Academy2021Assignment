<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]







<!-- ABOUT THE PROJECT -->
## About The Project


<p>The aim was to create a game prototype for Next games.

</p>

## Game Comments
What I decided to do:
I tried to mimic the game as closely as possible. I got the core mechanics down I belive. The bounce feels quite smooth.
I took the AudioManager from Brackeys, it is simple but I added a slight variation in pitch, I think it is pretty cool.
The traps were pretty basic, I only mande 2x, but they are just 4 objects within a parent. Each uses a polygon collider and is a trigger for the player.
The player uses OntriggerEnter2D and checks for tags. I thought Tag comparison would be the easiest way to implement this game.


What I would like to add:
More traps.
 - Triangles (create logic that it uses only 3 colors and checks that it has the player color)
 - Color changing lines (create a Corutine and make a timer, 1-1.5sec, and it will rotate through the colors)
 - Powerups, one might be that the ball splits in two, on the left and right so you have to bounce it with both hands. I would split the screen in half for the tap areas or use different keys on the keyboard. It would need different traps
 - You go up, fetch a key at the top, then you have to go down through the traps again, so you have to learn the gravity too
 - Different gravity zones. Either mess with the player Impulse force, the linear drag or the gravity scale.



The thing I did not have time to do was:
 - Restricting the camera to only upward motion and kill the player when he goes down out of sight. I am using Cinemachine. I would just clamp the Y value and compare the current position to the old postion, if it is smaller than don't move the camera. Then I could use the built in camera collider to kill the player.
 - ScoreManager. I wanted to make as much as I could decoupled. I wanted to have a public gameManager that would either use delegate or Events to the scoreManager. But I just put it in the PlayerController for now. It works, but could be better.




<!-- CONTACT -->
## Contact

Kristófer Knutsen - kristoferknutsen@hotmail.com


<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements

* [Img Shields](https://shields.io)






<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/BeeBeeCue/MapViz.svg?style=for-the-badge
[contributors-url]: https://github.com/BeeBeeCue/MapViz/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/BeeBeeCue/MapViz.svg?style=for-the-badge
[forks-url]: https://github.com/BeeBeeCue/MapViz/network/members
[stars-shield]: https://img.shields.io/github/stars/BeeBeeCue/MapViz.svg?style=for-the-badge
[stars-url]: https://github.com/BeeBeeCue/MapViz/stargazers
[issues-shield]: https://img.shields.io/github/issues/BeeBeeCue/MapViz.svg?style=for-the-badge
[issues-url]: https://github.com/BeeBeeCue/MapViz/issues
[license-shield]: https://img.shields.io/github/license/BeeBeeCue/MapViz?style=for-the-badge
[license-url]: https://github.com/BeeBeeCue/MapViz/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/k-knutsen
[product-screenshot]: images/MapViz.png
