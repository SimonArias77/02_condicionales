
//CONDICIONALES

// Console.Write("INGRESA TU EDAD POR FAVOR =>");
// byte edad = Convert.ToByte(Console.ReadLine());

// CONDICIONAL SIMPLE 

// if (edad >= 18) // TRUE
// {
//     Console.WriteLine("eres mayor de edad");
// }


// CONDICIONAL NORMAL

// if (edad >= 18) // TRUE
// {
//     Console.WriteLine("eres mayor de edad");
// }
// else
// {
//     Console.WriteLine("eres menor de edad");
// }

// CONDICIONAL COMPUESTA

// if (edad >= 18) // TRUE
// {
//     Console.WriteLine("eres mayor de edad");
// }
// else if ( edad >= 12 && edad < 18)
// {
//     Console.WriteLine("eres un adolescente");
// }
// else
// {
//     Console.WriteLine("eres menor de edad");
// }


// using System.Collections;

// Console.Write("INGRESA TU NÚMERO DEL 1 AL 7 POR FAVOR =>");
// byte numero = Convert.ToByte(Console.ReadLine());

// if (numero == 1)
// {
//     Console.Write("ELEGISTE EL DÍA LUNES");
// }
// else

//     switch (numero)
//     {
//         case 1:
//             Console.Write("elegiste el día lunes");
//             break;
//         case 2:
//             Console.Write("elegiste el día martes");
//             break;
//         case 3:
//             Console.Write("elegiste el día miércoles");
//             break;
//         case 4:
//             Console.Write("elegiste el día jueves");
//             break;
//         case 5:
//             Console.Write("elegiste el día viernes");
//             break;
//         case 6:
//             Console.Write("elegiste el día sábado");
//             break;
//         case 7:
//             Console.Write("elegiste el día domingo");
//             break;
//         default:
//             Console.Write("ELEGISTE UN NÚMERO INCORRECTO");
//             break;
//     }

// EJERCICIOS SESIÓN 2: CONDICIONALES

// 1. Escribe un programa que pida al usuario un número y muestre si es par o impar usando
// una condición if.

// Console.WriteLine("ingrese un número entero");
// int numero = Convert.ToByte(Console.ReadLine());

// if (numero % 2 == 0)
// {
//     Console.WriteLine("el número es par");
// }
// else
// {
//     Console.WriteLine("el número es impar");
// }

// 2. Escribe un programa que pida al usuario que ingrese su nombre. Luego, verifica si el
// nombre ingresado no es nulo ni está vacío. Si el nombre es válido, muestra un mensaje de
// bienvenida; de lo contrario, muestra un mensaje de error.

// Console.WriteLine("ingrese su nombre por favor");
// string nombre = Console.ReadLine();

// if (string.IsNullOrEmpty(nombre));
// {
//     Console.WriteLine($"el string {nombre} está nulo o vacío");
// } 
// else { 
//     Console.WriteLine($"el string {nombre} no está nulo ni vacío");
// }

// 3. Escribe un programa que pida al usuario su edad y muestre si es mayor o menor de edad
// usando if-else.

// Console.WriteLine("ingrese su edad");
// byte edad = Convert.ToByte(Console.ReadLine());

// if (edad >= 18){
//     Console.WriteLine("usted es mayor de edad");
// }else {
//     Console.WriteLine("usted es menor de edad");
// }

// 4. Escribe un programa que pida al usuario un día de la semana (como número del 1 al 7) y
// muestre el nombre del día correspondiente usando switch.

// Console.WriteLine("Ingrese un número del 1 al 7:");
// byte diaSemana = Convert.ToByte(Console.ReadLine());

// switch (diaSemana)
// {
//     case 1:
//         Console.WriteLine("El día es Lunes");
//         break;
//     case 2:
//         Console.WriteLine("El día es Martes");
//         break;
//     case 3:
//         Console.WriteLine("El día es Miércoles");
//         break;
//     case 4:
//         Console.WriteLine("El día es Jueves");
//         break;
//     case 5:
//         Console.WriteLine("El día es Viernes");
//         break;
//     case 6:
//         Console.WriteLine("El día es Sábado");
//         break;
//     case 7:
//         Console.WriteLine("El día es Domingo");
//         break;
//     default:
//         Console.WriteLine("Ingresaste un número incorrecto");
//         break;
// }

// 5. Escribe un programa que pida al usuario su equipo de nacionalidad, si es colombiana debe
// decirle que es nativo el país y si no lo es debe decir que es extranjeto (hacer ejercicio con
// operador ternario)

// Console.WriteLine("por favor escriba su nacionalidad:");
// string nacionalidad = Console.ReadLine();

// if ( nacionalidad == "colombiana"){
//     Console.WriteLine("es nativo del país");
// }
// else {
//     Console.WriteLine("usted es extranjero");
// }

// 6. Escribe un programa que pida al usuario tres números y muestre cuál es el mayor usando
// if-else.

// Console.WriteLine("escriba tres números por favor:");
// int num1 = Convert.ToByte(Console.ReadLine());
// int num2 = Convert.ToByte(Console.ReadLine());
// int num3 = Convert.ToByte(Console.ReadLine());

// if ( num1 > num2 &&  num1 > num3){
//     Console.WriteLine($"El número {num1} es mayor");
// }
// else if ( num2 > num1 && num2 > num3){
//     Console.WriteLine($"El número {num2} es mayor");
// }
// else {
//     Console.WriteLine($"El número {num3} es mayor");
// }

// 7. Escribe un programa que pida al usuario que ingrese una contraseña. Verifica si la
// contraseña no es nula ni está vacía. Si la contraseña es válida, muestra un mensaje
// indicando que la contraseña es aceptada; de lo contrario, muestra un mensaje indicando
// que la contraseña no puede estar en blanco.

Console.WriteLine("ingrese su contraseña por favor");
string contraseña = Console.ReadLine();
// 8. Escribe un programa que pida al usuario un número del 1 al 12 y muestre el nombre del
// mes correspondiente usando switch.
// 9. Escribe un programa que pida al usuario una calificación numérica y muestre la letra
// correspondiente (A, B, C, D, F) usando if-else.
// 10. Escribe un programa que pida al usuario un carácter y determine si es una vocal o una
// consonante usando switch.
// 11. Escribe un programa que pida al usuario dos números y muestre si son iguales o diferentes
// usando if-else.
// 12. Escribe un programa que solicite al usuario que ingrese su dirección. Verifica si la dirección
// no es nula, no está vacía y no consiste sólo en espacios en blanco. Si la dirección es válida,
// muestra un mensaje de confirmación; de lo contrario, muestra un mensaje de error.
// 13. Escribe un programa que pida al usuario un número y determine si es positivo, negativo o
// cero usando if-else.
// 14. Escribe un programa que pida al usuario una letra y determine si es una vocal usando
// if-else.
// 15. Escribe un programa que pida al usuario una temperatura en grados Celsius y determine si
// es caliente (mayor a 30), templada (entre 10 y 30) o fría (menor a 10) usando if-else.
// 16. Escribe un programa que pida al usuario un año y determine si es un año bisiesto usando
// if-else.
// 17. Escribe un programa que pida al usuario que ingrese un valor. Verifica si el valor ingresado
// no es nulo, no está vacío y no contiene solo espacios en blanco. Si la entrada es válida,
// muestra el valor; de lo contrario, pide al usuario que ingrese un valor válido.
// 18. Escribe un programa que pida al usuario un número del 1 al 7 y determine si es un día
// laborable o de fin de semana usando switch.