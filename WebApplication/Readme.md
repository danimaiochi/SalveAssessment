#Salve Assessment
The idea of this project is to load a dropdown with a couple of clinics and on selecting one, we show the patients of it in a grid.

The grid supports sorting.

The backend was built using Web Api and reading the data from CSV files.
The front end was done using HTML/jQuery/CSS.

##Things that can be improved if there's more time
* The way we read the records from CSV isn't the most efficient, ideally we would cache instead of always reading and parsing;
* The way we 'filter' the users based on a clinic is just because we have different files, we could load everything at once and filter using Linq for example;
* The time spent on layout was close to nothing as I tried to make the solution work instead of making it beautiful, so this can also be improved;
* There's no automated tests or error handling, so if anything goes wrong the app will not behave well;
* The grid and API calls are very specific, if this project would grow I'd spend some time making common components/methods so they can be reused;
* I've chosen to not use a front end framework (like Angular or React) to keep it as simple as possible.

##Extra thank you
As a dev, stackoverflow was a big help on making the grid sortable.
