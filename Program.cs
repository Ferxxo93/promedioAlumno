using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] mauroScores = new int[]{90, 86, 87, 98, 100, 94, 90};
int[] juanScores = new int[]{92, 89, 81, 96, 90, 89};
int[] emmaScores = new int[]{90, 85, 87, 98, 68, 89, 89, 89};
int[] lucasScores = new int[]{90, 95, 87, 88, 96, 96};

string[] nombreAlumnos = new string[] {"Mauro", "Juan", "Emma", "Lucas"};
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
        
    int sumPuntajeTarea = 0;

    decimal notaActual = 0;

    foreach (int score in alumnoPuntaje)
    {
        sumPuntajeTarea += score;
    }

    notaActual = (decimal)(sumPuntajeTarea) / currentAssignments;

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
