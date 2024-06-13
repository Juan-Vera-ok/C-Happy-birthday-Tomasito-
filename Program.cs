using System;

class Program
{
    static void Main()
    {
        const int NUM_CURSOS = 5;
        int[] estudiantesPorCurso = new int[NUM_CURSOS];
        string[] maxDonadorPorCurso = new string[NUM_CURSOS];
        double[] maxDonacionPorCurso = new double[NUM_CURSOS];
        double[] recaudacionPorCurso = new double[NUM_CURSOS];
        
        double recaudacionTotal = 0;
        
        // Solicitar la cantidad de estudiantes en cada curso
        for (int i = 0; i < NUM_CURSOS; i++)
        {
            Console.Write($"Ingrese la cantidad de estudiantes en el curso {i + 1}: ");
            estudiantesPorCurso[i] = int.Parse(Console.ReadLine());
        }

        // Solicitar datos de cada estudiante en cada curso
        for (int curso = 0; curso < NUM_CURSOS; curso++)
        {
            for (int estudiante = 0; estudiante < estudiantesPorCurso[curso]; estudiante++)
            {
                Console.Write("Ingrese el nombre del estudiante: ");
                string nombre = Console.ReadLine();
                
                // Omitir a Tomás del curso 3
                if (curso == 2 && nombre.ToLower() == "tomás") continue;
                
                Console.Write("Ingrese la cantidad de dinero que va a otorgar: ");
                double donacion = double.Parse(Console.ReadLine());
                
                // Actualizar recaudación del curso
                recaudacionPorCurso[curso] += donacion;
                
                // Verificar si es la mayor donación del curso
                if (donacion > maxDonacionPorCurso[curso])
                {
                    maxDonacionPorCurso[curso] = donacion;
                    maxDonadorPorCurso[curso] = nombre;
                }
            }
            
            // Actualizar recaudación total
            recaudacionTotal += recaudacionPorCurso[curso];
        }
        
        // Calcular promedio de recaudación por curso
        double promedioRecaudacion = recaudacionTotal / NUM_CURSOS;

        // Mostrar resultados
        Console.WriteLine("\nEstadísticas de la recaudación:");
        for (int i = 0; i < NUM_CURSOS; i++)
        {
            Console.WriteLine($"\nCurso {i + 1}:");
            Console.WriteLine($"Estudiante que más plata puso: {maxDonadorPorCurso[i]} con {maxDonacionPorCurso[i]} unidades monetarias");
            Console.WriteLine($"Recaudación total: {recaudacionPorCurso[i]} unidades monetarias");
        }
        Console.WriteLine($"\nRecaudación total entre los 5 cursos: {recaudacionTotal} unidades monetarias");
        Console.WriteLine($"Promedio de dinero recaudado por curso: {promedioRecaudacion} unidades monetarias");
    }



    
}
