# proyectoVisualBasic
EJERCICIO 7: DISTRIBUIDORA ARROZ
Un empresario valenciano ha visto nuestro software de la distribuidora de cal, y nos pide si
lo podríamos adaptar para su holding del arroz. Nos pide que cuente con una interfaz más
profesional, convirtiéndose en un centro de control del proceso automatizado de carga del que
disponen.
Modifica el ejercicio 2 (distribuidora de cal) de la siguiente forma:
1.- Antes de empezar a cargar sacas, mostrar una pantalla donde:
a) se muestre el día y la hora actuales
b) se pueda configurar el rango de pesos de las sacas, mediante barras de desplazamiento.
c) se añada a un ListBox los tipos de camiones que tenemos, junto con sus pesos de carga y
una imagen representativa de ese tipo de camión.
d) se muestre un LinkLabel con un enlace a una supuesta página de información de la
empresa.
2.- Durante el proceso de carga, cuanto se vaya a cargar una saca, aparezca una imagen de una
saca llena (o similar) y se muestre una barra de progreso cuya velocidad de avance sea
proporcional al vaciado de la saca; junto con el mensaje parpadeante “Atención: cargando…”, y al
final aparezca una saca vacía (o una pala en lugar de saca)
3.- Cuando vaya a cargarse un camión nuevo, se acercará una imagen del tipo de camión
seleccionado al lugar donde debe haber una imagen de una saca.
4.- Cuando el camión esté lleno, la imagen del camión se alejará de la saca y podrá iniciarse la
carga de otro camión.
5.- Cuando vaya a cargarse un camión nuevo, se elegirá de entre la lista de tipos de camiones que
introdujimos al comenzar el programa.
6.- Al finalizar la jornada mostraremos los totales y subtotales de kilogramos cargados.
Sugerencias a usar en cada punto:
1.- Timer, VscrollBar/HscrollBar/TrackBar, LinkLabel, ListBox, CheckBox con conjunto de
imágenes (Image, ImageList)
2.- ProgressBar, Timer, Picture
3, 4.- Usar un bucle con Sleep de retardo, Picture
5.- ListBox o ComboBox
Sugerencias generales:
Realizar un boceto en papel sobre cómo distribuirías los componentes en la pantalla, así
como las entradas de menús y botones necesarias (al menos una para dar de alta los tipos de
camiones y otra para el proceso de carga). En todo proyecto informático es necesario un análisis
previo de la solución, antes de “picar” ningún código.
En lugar de usar InputBox y MsgBox, se podrían usar Label y TextBox que se habilitarían o
deshabilitarían (propiedad Enabled) según el momento del proceso de carga en que nos
encontremos.
