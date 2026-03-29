Here is a comprehensive `README.md` file for your repository based on the provided project files:

```markdown
# The Neari Blog Theme

The Neari Blog Theme is an Orchard Core CMS theme adapted for blogs. It integrates Bootstrap and Liquid templating to provide a stylish, responsive blogging experience.

## Features and Technologies

* **Framework:** Built on `.NET 8.0`.
* **CMS:** Designed for Orchard Core version `2.2.1`.
* **Tags:** Blog, Bootstrap, Liquid, OrchardCoreCMS, Theme.
* **Base Template:** The theme's frontend design is based on the stylish [Start Bootstrap - Clean Blog](https://startbootstrap.com/theme/clean-blog/) theme.

## Asset Management

The front-end assets for this theme are built using npm within the `Assets` directory. To work with the theme's source files, you must have npm installed. 

You can use the following npm scripts to build and manage the assets:
* `npm run build`: Builds the project—this builds assets, HTML, JS, and CSS into the `dist` folder.
* `npm run build:assets`: Copies the files in the `src/assets/` directory into `dist`.
* `npm run build:pug`: Compiles the Pug files located in the `src/pug/` directory into `dist`.
* `npm run build:scripts`: Brings the `src/js/scripts.js` file into `dist`.
* `npm run build:scss`: Compiles the SCSS files located in the `src/scss/` directory into `dist`.
* `npm run clean`: Deletes the `dist` directory to prepare for rebuilding the project.
* `npm start` (or `npm run start`): Runs the project, launches a live preview in your default browser, and watches for changes made to files in `src`.
* `npm run start:debug`: Runs the project in debug mode.

## Credits

* Theme structure and metadata by the OrchardCoreTeam.
* Frontend styling is based on the Clean Blog theme created by Start Bootstrap (David Miller).
```