# PrimerParcial1C2024-UNLAM-PW3
Resolucion al primer parcial,proporcionado en la materia PROGRAMACION WEB 3 de la carrera TECNICATURA EN DESARROLLO WEB de la Universidad Nacional de La Matanza

Consigna:
Realizar una aplicación “Registro Aduanero de Barcos”, en Asp.Net MVC que incluya las siguientes funcionalidades y restricciones:
    1) Al ejecutar la aplicación, esta debe iniciar por defecto en un controlador llamado “Inicio” en una acción “Bienvenida”. La vista
correspondiente deberá incluir un mensaje de bienvenida al sitio: “Bienvenido al sitio de Registro Aduanero de Barcos”
    2) 2.1) Agregar un layout llamado “_AduanaLayout.cshtml” con 2 links, pero que contenga un pie o footer Fijo: con la información
      del alumno:
                          Nombre y Apellido
                                DNI
    2-2) Se deberán incluir dos links en el Layout:
        a) Registrar Barco
        b) Listado Barcos
Se pretende que la aplicación tenga un controlador “Barcos”, que tenga la lógica necesaria para poder mostrar alguna de las
dos vistas según la elección del usuario: a): Registrar o b) Listado
    3) La vista Registrar Barco, tendrá el siguiente formato:
Al hacer clic en Registrar se deberá programar una acción que permita realizar el cálculo y registro de la tasa
correspondiente con su lógica de negocio respectiva. En términos generales, el cálculo de la Tasa es el siguiente: 
                Tasa =(Antiguedad * 0.10) + (Tripulacion maxima / 2).
                
    4) Se deberá agregar las siguientes validaciones al registro anterior:
- Nombre: Hasta 20 caracteres. Campo requerido
- Antiguedad: Numérico, Campo Obligatorio. La cantidad vendida debe ser mayor a 0 y menor a 200.
- Tripulacion Maxima: Numérico, campo obligatorio. El precio unitario debe ser mayor o igual a 1 y menor a 500.
