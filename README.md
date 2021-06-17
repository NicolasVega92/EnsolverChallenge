# EnsolverChallenge
- He creado 2 proyectos diferentes utilizando C#/ ASP.NET MVC / RAZOR 
   ### 1 -> En la solucion ChallengeIndividual
  -  Cree los Modelos con DataAnnotation para luego poder hacer la migracion hacia la base de datos. (Task, Folder)
  -  Realice el DbContext en la carpeta Data dentro de la solución y estableci los DbSet
  -  Los controladores cumplen las funciones de Get / Update / Delete / Create con sus respectivas Views
  -  Encare el desafio creando un MVC donde el usuario puede:
     -  Ver: Mediante el Index del modelo de Task. Se mostrara una tabla con la lista de Tareas existentes. 
     -  Crear: Mediante un boton en el Index, llevara a otra View donde el usuario podra rellenar los campos necesarios.
     -  Editar: A lado de la vista de cada tarea tendra el boton Editar y Borrar. Editar conduce a otra vista, pero con los campos rellenados para poder modificarlos.
     -  Borrar: Conduce a la vista con los campos rellenados, pero deshabilitados para modificar. Eliminara de la base de datos el registro de la tarea.
     -  Otra opcion que se presenta en la barra de navegación es la solapa Carpetas, donde se listan las carpetas creadas, tambien se puede crear una nueva carpeta. (Falta la relación de ambos Modelos)

   ### 2 -> En la solución ChallengeToDoApp
   -  Realice una aplicación de navegador con almacenamiento en el LocalStorage (permite resfrecar la pantalla y no perder la informacion), donde el usuario puede colocar sus tareas, al presionar el boton "Add" y se listaran debajo. 
   -  El usuario con esas mismas Tareas puede realizar 2 cosas: 
      - Presionar la cruz roja, lo cual eliminara la tarea de la lista.
      - Presionar sobre la tarea y esto la "tachara" en la lista, pero no se borrara.
   
