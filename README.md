# xr-hands-teleport-test

A prototype to implement the [Ultraleap jump gems](https://docs.ultraleap.com/xr-guidelines/Interactions/locomotion.html#teleportation-examples) method of hand-based locomotion / teleportation using Unity XRI and XR Hands

https://github.com/jonjhiggins/xr-hands-teleport-test/assets/1374543/768a31df-04e5-44cb-9314-b13e357eab1d

Currently the gem is only on the left hand, remains there all the time and has some funky rotation behaviour, but it proves a way of using XR Ray attached to a non-controller/hand game object and using it to teleport. Mostly using XRI components with a few basic custom scripts.

## Development

- Tested on Unity Play Mode with Pico 4 Business and SteamVR.
- Requires an instance of the Ultraleap Unity Plugin at one directory above the root. Tested working on branch [feature/UINTY-1194_XR_Hands_Action_input](https://github.com/ultraleap/UnityPlugin/tree/feature/UINTY-1194_XR_Hands_Action_input).



