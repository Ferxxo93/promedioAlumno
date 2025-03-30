using System;

// initialize variables - graded assignments 
int examAssignments = 5;

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

Console.WriteLine("Alumno\t\tNota\n");

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
        
    int sumPuntajeTarea = 0;

    decimal notaActual = 0;

    int notasAsignadas = 0;

    foreach (int score in alumnoPuntaje)
    {
        notasAsignadas+=1;
        if(notasAsignadas<=examAssignments)
        sumPuntajeTarea += score;
        else
        sumPuntajeTarea += score / 10;
    }

    notaActual = (decimal)(sumPuntajeTarea) / examAssignments;

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

    Console.WriteLine($"{estudianteActual}\t\t{notaActual}\t{letraNotaAlumno}");
    
}


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
