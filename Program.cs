using System;

// initialize variables - graded assignments 
int examenesAsignados = 5;

int[] mauroScores = new int[]{90, 86, 87, 98, 100, 94, 90};
int[] juanScores = new int[]{92, 89, 81, 96, 90, 89};
int[] emmaScores = new int[]{90, 85, 87, 98, 68, 89, 89, 89};
int[] lucasScores = new int[]{90, 95, 87, 88, 96, 96};
int[] ferScores = new int[]{ 92, 91, 90, 91, 92, 92, 92 };
int[] micaScores = new int[]{ 84, 86, 88, 90, 92, 94, 96, 98 };
int[] camiScores = new int[]{ 80, 90, 100, 80, 90, 100, 80, 90 };
int[] moreScores = new int[]{ 91, 91, 91, 91, 91, 91, 91 };


string[] nombreAlumnos = new string[] {"Mauro", "Juan", "Emma", "Lucas", "Fer", "Micaela", "Camila", "Morena"};
int[] alumnoPuntaje = new int[10];
string letraNotaAlumno = " ";

Console.WriteLine("Alumno\t\tNota Examen\tNota Final\tLetra\t\tCrédito Extra");

foreach(string nombres in nombreAlumnos)
{
    string estudianteActual = nombres;

    if( estudianteActual == "Mauro")
        alumnoPuntaje = mauroScores;

    else if (estudianteActual == "Juan")
        alumnoPuntaje = juanScores;

    else if (estudianteActual == "Emma")
        alumnoPuntaje = emmaScores;

    else if (estudianteActual == "Lucas")
        alumnoPuntaje = lucasScores;

    else if (estudianteActual == "Fer")
        alumnoPuntaje = ferScores;

    else if (estudianteActual == "Micaela")
        alumnoPuntaje = micaScores;

    else if (estudianteActual == "Camila")
        alumnoPuntaje = camiScores;

    else if (estudianteActual == "Morena")
        alumnoPuntaje = moreScores;
        
    else 
        continue;

    int sumPuntajeExamen = 0;

    int sumPuntajeTarea = 0;

    decimal notaActual = 0;

    int notasAsignadas = 0;

    foreach (int score in alumnoPuntaje)
    {
        if(notasAsignadas < examenesAsignados)
            sumPuntajeExamen += score;
        else
            sumPuntajeTarea += score / 10;

        notasAsignadas++;
   }

    decimal notaExamen = (decimal)(sumPuntajeExamen) / examenesAsignados;

    decimal creditoExtra =(decimal) (sumPuntajeTarea) / examenesAsignados;

    notaActual = notaExamen + creditoExtra / examenesAsignados;

    if(notaActual >= 97)
        letraNotaAlumno = "A+";
    else if (notaActual >= 93)
        letraNotaAlumno = "A";
    else if(notaActual >= 90)
        letraNotaAlumno = "A-";
    else if(notaActual >= 87)
        letraNotaAlumno = "B+";
    else if(notaActual >= 83)
        letraNotaAlumno = "B";
    else if(notaActual >= 80)
        letraNotaAlumno = "B-";
    else if(notaActual >= 77)
        letraNotaAlumno = "C+";
    else if(notaActual >= 73)
        letraNotaAlumno = "C";
    else if(notaActual >= 70)
        letraNotaAlumno = "C-";
    else if(notaActual >= 67)
        letraNotaAlumno = "D+";
    else if(notaActual >= 63)
        letraNotaAlumno = "D";
    else if(notaActual >= 60)
        letraNotaAlumno = "D-";
    else letraNotaAlumno = "F";

    Console.WriteLine($"{estudianteActual,-10}\t{notaExamen,5:F1}\t\t{notaActual,5:F1}\t\t{letraNotaAlumno,-5}\t\t{(creditoExtra)}");
    
}


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
