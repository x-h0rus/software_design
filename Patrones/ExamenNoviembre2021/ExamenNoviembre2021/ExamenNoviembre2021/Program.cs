using ExamenNoviembre2021.Iterador;
using ExamenNoviembre2021.Tareas;
using ExamenNoviembre2021.Tareas.Interfaces;
using ExamenNoviembre2021.Visitante;
using ExamenNoviembre2021.Visitante.Interfaz;
using System;
using System.Collections.Generic;

namespace ExamenNoviembre2021
{
    class Program
    {
        static void Main(string[] args)
        {
            ITareaCompuesta ht = new TareaCompuesta("Hacer tarta");
            ITareaCompuesta hb = new TareaCompuesta("Hacer bizcocho");

            TareaSimple hmb = new TareaSimple("Hacer masa bizcocho", 0.25);
            hmb.Spent = 0.5;
            hmb.Remaining = 0;

            TareaSimple hornbiz = new TareaSimple("Hornear bizcocho", 0.5);
            hornbiz.Spent = 0.5;
            hornbiz.Remaining = 0;

            hb.Subtareas.Add(hmb);
            hb.Subtareas.Add(hornbiz);

            TareaSimple hcr = new TareaSimple("Hacer crema relleno", 0.5);
            hcr.Spent = 0.5;
            hcr.Remaining = 0.25;

            TareaSimple haco = new TareaSimple("Hacer cobertura", 0.25);

            TareaSimple rebi = new TareaSimple("Rellenar bizcocho", 0.25);

            TareaSimple coco = new TareaSimple("Colocar cobertura", 0.5);

            ITareaCompuesta decorar = new TareaCompuesta("Decorar");

            TareaSimple pdb = new TareaSimple("Poner decoracion base", 0.5);

            TareaSimple aae = new TareaSimple("Añadir adornos especiales", 0.5);

            decorar.Subtareas.Add(pdb);
            decorar.Subtareas.Add(aae);

            ht.Subtareas.Add(hb);
            ht.Subtareas.Add(hcr);
            ht.Subtareas.Add(haco);
            ht.Subtareas.Add(rebi);
            ht.Subtareas.Add(coco);
            ht.Subtareas.Add(decorar);

            //Lo saca bien
            Console.WriteLine(ht);


            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Pregunta 4");
            //--------------------PREGUNTA 4--------------------------
            IVisitanteAbstracto va = new VisitanteAbstracto();

            ITareaSimple tarea1 = new TareaSimple("A", 1);
            ITareaSimple tarea2 = new TareaSimple("B", 0);
            ITareaSimple tarea3 = new TareaSimple("C", 2);
            ITareaSimple tarea4 = new TareaSimple("D", 0);
            ITareaCompuesta tareaCompuesta1 = new TareaCompuesta("Tarea Compuesta 1");
            tareaCompuesta1.Subtareas.Add(tarea3);

            ISet<ITarea> tareas = new HashSet<ITarea>();
            tareas.Add(tarea1);
            tareas.Add(tarea2);
            tareas.Add(tareaCompuesta1);
            tareas.Add(tarea4);
            //Debe devolver una lista con 2 tareas
            //Console.WriteLine(va.devolverTareasNoCompletadas(tareas).ToString());

            ITareaSimple tarea5 = new TareaSimple("E", 15);
            tareas.Add(tarea5);

            //Debe devolver una lista con 3 tareas
            //Console.WriteLine(va.devolverTareasNoCompletadas(tareas).ToString());

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Pregunta 5");
            //--------------------PREGUNTA 5--------------------------
            TareaSimple tarea10 = new TareaSimple("Hacer crema relleno", 1);
            TareaSimple tarea11 = new TareaSimple("Hacer cobertura", 2);
            TareaSimple tarea12 = new TareaSimple("Rellenar bizcocho", 2);
            TareaSimple tarea13 = new TareaSimple("Colocar cobertura", 0.25);

            ISet<ITarea> tareas2 = new HashSet<ITarea>();
            tareas2.Add(tarea10);
            tareas2.Add(tarea11);
            tareas2.Add(tarea12);
            tareas2.Add(tarea13);
            //Debe dar false
            Console.WriteLine(TaskHelper.ContainsTwoTinyTask(tareas2));

            tarea10.Remaining = 0.5;
            //Debe dar verdadero
            Console.WriteLine(TaskHelper.ContainsTwoTinyTask(tareas2));
        }
    }
}
