sistema;

espacio de nombres  semana3_estructuras_de_controlsemana3_estructuras_de_control
{

     programa de clase
    {
        static void Main(cadena[] argumentos)
{
    Consola.ForegroundColor = ConsoleColor.Negro;

    menú();

}

menú vacío  estático ()
        {
    int repetir_menu;
    Consola.BackgroundColor = ConsoleColor.azul;
    Sistema.Consola.WriteLine(" Estructuras de control en Visual C # ");
    Sistema.Consola.WriteLine(" 1. Menú de opciones ");
    Sistema.Consola.WriteLine(" 2. Salir ");

    Sistema.Consola.WriteLine(" Ingrese 1 para mostrar menú o 2 para salir. ");
    repetir_menu = Int32.Analizar(Consola.ReadLine());

    cambiar(repetir_menu)
            {
        caso  1 :
                    opciones();

        romper;
        caso  2 :
                    Medio ambiente . Salir(0);
        Sistema.Consola.WriteLine(" Usted ha seleccionado salir! ");

        romper;
        por defecto :
                    Sistema.Consola.WriteLine(" Opción equivocada ");
        romper;
    }
    opciones();
}


opciones de vacío  estático ()
        {

    int opcion;
    Consola.Borrar();
    Consola.BackgroundColor = ConsoleColor.Rojo;

    Sistema.Consola.WriteLine(" Ejemplos de estructuras de control ");
    Sistema.Consola.WriteLine(" 1. USO DEL IF ");
    Sistema.Consola.WriteLine(" 2. USO DEL MIENTRAS ");
    Sistema.Consola.WriteLine(" 3. USO DEL DOWHILE ");
    Sistema.Consola.WriteLine(" 4. USO DEL FOR ");

    Sistema.Consola.WriteLine(" Ingrese la opción: ");
    opcion = Int32.Analizar(Consola.ReadLine());

    interruptor(opcion)
            {
        caso  1 :
                    ejemplo_if();
        romper;
        caso  2 :
                    ejemplo_ while () ;
        romper;
        caso  3 :
                    ejemplo_doWhile();
        romper;
        caso  4 :
                    ejemplo_for();
        romper;
        por defecto :
                    Sistema.Consola.WriteLine(" Opción equivocada ");
        romper;
    }
    Sistema.Consola.ReadKey();
    // principal ();

}

vacío estático ejemplo_if ()
        {
    Sistema.Consola.WriteLine(" Ejemplo de IF ");
    Consola.WriteLine(" ingrese un número entre 1 y 3 ");
    int num = int.Analizar(Consola.ReadLine());
    si(num == 1)
            {
        Consola.WriteLine(" valor es 1 ");
    }
    demás
            si(num == 2)
            {
        Consola.WriteLine(" valor es 2 ");
    }
    demás
            si(num == 3)
            {
        Consola.WriteLine(" valor es 3 ");
    }
    demás
            {
        Consola.WriteLine(" no se encontro el valor ");
    }
    Consola.ReadKey();

}

vacío estático ejemplo_ while ()
        {
    Sistema.Consola.WriteLine(" Ejemplo de while ");
    Consola.WriteLine(" ingrese un numero ");
    int numero1 = int.Analizar(Consola.ReadLine());
    Consola.WriteLine(" ingrese un número mayor que el anterior ");
    int numero2 = int.Analizar(Consola.ReadLine());
    while (numero1 < numero2)
    {
        Consola.WriteLine(" valores: " + numero1);
        numero1++;
    }
    Consola.ReadKey();
}


vacío estático ejemplo_doWhile ()
        {
    Sistema.Consola.WriteLine(" Ejemplo de doWhile ");

    secreto de cadena;
    palabra de cadena;
    Consola.WriteLine(" ingrese la palabra secreta ");
    secreto = Consola.ReadLine();
    hacer
            {
        Consola.WriteLine(" vuelva a introducir la palabra secreta ");
        palabra = Consola.ReadLine();
        si(palabra! = secreto)
                    Consola.WriteLine(" palabra incorrecta ");
    }
    mientras(palabra! = secreto);

    Consola.WriteLine(" Palabra Correcta ");
    Consola.ReadKey();

}

vacío estático ejemplo_for ()
        {
    Sistema.Consola.WriteLine(" Ejemplo de para ");

    {
        Sistema.Consola.WriteLine(" Contador iniciado ");
        para(int  num = 1 ; num <= 10; num++ )
                {
            Consola.WriteLine(num);
        }

        Consola.ReadLine();
    }
}


    }
}
    }
}
