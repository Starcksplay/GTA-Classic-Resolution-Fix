🎮 GTA Classic Resolution Fix Wrapper

# GTA Classic Resolution Fix Wrapper

## What does it do?

This wrapper fixes the startup issues on Windows 10/11 where GTA III, GTA Vice City, and GTA San Andreas show errors such as:

* "Cannot find 1920x1080x32 video mode"
* The game stays running in the background without opening a window
* The game does not launch

The program temporarily forces the game to start in 640x480 resolution during the first launch and then restores the normal configuration.

---

## Installation

1. Download the latest release from the [Releases page](https://github.com/Starcksplay/GTA-Classic-Resolution-Fix/releases).
2. Open the folder where your GTA game is installed.
3. Make a backup copy of the original executable.
4. Rename the original file:

### GTA San Andreas:

```
gta_sa.exe → gta_sa_real.exe
```

### GTA Vice City:

```
gta-vc.exe → gta-vc_real.exe
```

### GTA III:

```
gta3.exe → gta3_real.exe
```

(or whatever the executable is named in your game folder)

5. Copy the wrapper file into the same folder.

The wrapper must have the original game executable name:

```
gta_sa.exe
gta-vc.exe
gta3.exe
```

6. Launch the game normally from your usual launcher.

---

## Notes

* The original game executable is not modified.
* The wrapper must be placed in the same folder as the real executable.
* The first-launch configuration is saved in:

```
Documents\GTA Wrapper Fix
```

* If you want to remove the fix, delete the wrapper and rename the files back:

```
gta_sa_real.exe → gta_sa.exe
gta-vc_real.exe → gta-vc.exe
gta3_real.exe → gta3.exe
```

---

## If it stops working:

Go to:

```
Documents\GTA Wrapper Fix
```

Delete the files inside and try again.

---

Compatible with modified installations using SilentPatch, CLEO, ModLoader, and other mods.
