[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)

Respuestas:
1.  String es tipo por referencia pero se comporta como inmutable. Está en el heap pero cada vez que se cambia se crea una nueva instancia del mismo.

2.  \n (salto de linea), \t (tab), \\ (barra invertida),\' (comillas), \0 (nulo), \v (tab vertical), etc...

3.  Si colocas @ antes de una cadena no interpreta \n, ni \t, pero permite escribir rutas.
Si colocas $ te permite interpretar valores de variables dentrod el string usando {}.


RESPuestas problema optativo

- Las Regex son patrones especiales que se usan para buscar o reemplazar texto en strings. Buscan caracteres o cadenasde caracteres especificos y sirven para identificar qué tipo de texto es una cadena ingresada.
- Funcionan en una variedad de lenguajes conocidos y parecen encontrarse siempre en los más modernos o actualmente más usados (Phyton, Javascript, php).
- Son útiles cuand se quieren validar datos de entrada, extraer información especifica de un texto largo o reemplazar texto.
- EN nuestro querido C# las usamos escribiendo arriba "using System.Text. RegularExpressions" y usando las funciones que este namespace para strings: Regex.IsMatch, Regex.Match, Regex.Replace, etc..


