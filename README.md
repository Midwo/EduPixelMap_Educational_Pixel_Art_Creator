# 1. EduPixelMap - Educational Pixel‑Art Creator (Windows Form APP)
 
A simple and intuitive tool for creating 20×20 pixel‑art educational boards for children.

Designed for teachers, therapists, and educators who want to prepare printable pixel‑art tasks for kids — coloring, gluing, spatial reasoning, and pattern‑following exercises.
# 2. Screenshots: 

**1. Main drawing interface**

<img src="https://github.com/Midwo/EduPixelMap_Educational_Pixel_Art_Creator/blob/master/MapaEdukacyjna/GenMap1.png" width="700" alt="EduPixelMap Screen 1">

**2. Instruction mode (color‑by‑number)**

<img src="https://github.com/Midwo/EduPixelMap_Educational_Pixel_Art_Creator/blob/master/MapaEdukacyjna/GenMap3.png" width="400" alt="EduPixelMap Screen 3">

**3. Printable worksheet preview**

<img src="https://github.com/Midwo/EduPixelMap_Educational_Pixel_Art_Creator/blob/master/MapaEdukacyjna/GenMap4.png" width="400" alt="EduPixelMap Screen 4">

**4. Blank 20x20 grid (printable template)**

<img src="https://github.com/Midwo/EduPixelMap_Educational_Pixel_Art_Creator/blob/master/MapaEdukacyjna/GenMap2.png" width="400" alt="EduPixelMap Screen 2">

**5. Color block grid overlay (cut-out squares)**

<img src="https://github.com/Midwo/EduPixelMap_Educational_Pixel_Art_Creator/blob/master/MapaEdukacyjna/GenMap5.png" width="400" alt="EduPixelMap Screen 5">

# 3. Overview

EduPixelMap is a lightweight Windows Forms application that allows users to:
* draw pixel‑art on a 20×20 grid,
* choose colors and fill cells interactively,
* generate printable boards,
* create instruction sheets for children,
* save and load projects.

Originally created as a fast prototype for a special‑needs school.

# 4. Features
- **20×20 editable pixel grid** - click to fill cells with the selected color.
- **Color picker** - choose any color and apply it to grid cells.
- **Clear board** - reset the entire grid with one click.
- **Printable output** - generate clean, kid‑friendly boards.
- **Instruction mode** - create worksheets with color‑coded tasks.
- **Simple, accessible UI** - designed for teachers and young users.

# 5.  How It Works
1. Each grid cell is represented by a button tagged as "grid".
2. A single event handler updates the clicked cell’s color.
3. Clearing the board iterates through all controls with the "grid" tag.
 
# 6. Tech Stack
* C#
* .NET / Windows Forms
* GDI+
* Visual Studio

# 7. How to Run
1. Clone the repository.
2. Open the solution in Visual Studio.
3. Build and run the project (F5).
   
# 8. Motivation
This demo tool was originally created for a special‑needs school to help teachers prepare simple, printable pixel‑art worksheets.
There are almost no free tools of this kind available online, so this project fills a small but real educational gap.

# 9. Contributing
This is a small personal project, but if you want to report a bug or suggest an improvement, feel free to open an issue.

# 10. License
> [!NOTE]
> MIT.
