using Tareas;
int opc, repet = 0;
string aux;
string descripcion;
int duracion;
var tareasPendientes = new List<Tarea>();
var tareasRealizadas = new List<Tarea>();
Tarea auxTareas = null;


while (repet == 0)
{
    Console.WriteLine("================MENU================");
    Console.WriteLine("1) Agregar tarea \n 2) Indicar tarea realizada \n 3) Ver tareas pendientes \n 4) Ver tareas realizadas \n 5) Buscar tareas por descripcion ");
    Console.WriteLine("====================================");

    opc = intCorrecto(5, 1);

    switch (opc)
    {
        case 1:
            Console.WriteLine("Descripcion: ");
            descripcion = Console.ReadLine();
            Console.WriteLine("Duracion: ");
            duracion = intCorrecto(100, 10);
            tareasPendientes.Add(new Tarea(descripcion, duracion));
            break;
        case 2:
            Console.WriteLine("Indique Id: ");
            int idBuscado = intCorrecto(tareasPendientes.Count, 1);
            auxTareas = null;
            foreach (var tareaPendiente in tareasPendientes)
            {
                if (tareaPendiente.TareaId == idBuscado)
                {
                    auxTareas = tareaPendiente;
                    break;
                }
            }
            if (auxTareas != null)
            {
                tareasPendientes.Remove(auxTareas);
                tareasRealizadas.Add(auxTareas);
                Console.WriteLine($"La tarea {auxTareas.TareaId} fue realizada");
            }
            else
            {
                Console.WriteLine($"La tarea {idBuscado} no se encuentra en la lista");
            }
            break;
        case 3:
            Console.WriteLine("Tareas Pendientes:");
            foreach (var tareaPendiente in tareasPendientes)
            {
                tareaPendiente.mostrarTarea();
            }
            break;
        case 4:
            Console.WriteLine("Tareas Realizadas:");
            foreach (var tareaRealizada in tareasRealizadas)
            {
                tareaRealizada.mostrarTarea();
            }
            break;
        case 5:
            Console.WriteLine("Ingrese la descripcion de la tarea a buscar: ");
            descripcion = Console.ReadLine();
            foreach (var tareaPendiente in tareasPendientes)
            {
                if (tareaPendiente.Descripcion.IndexOf(descripcion, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    tareaPendiente.mostrarTarea();
                }
            }
            break;
        default:
            break;
    }
    Console.WriteLine($"Quiere realizar otra operacion? S / N");
    aux = Console.ReadLine();
    if (aux == "n" || aux == "N")
    {
        repet++;
    }
}
Console.WriteLine($"...");





static int intCorrecto(int max, int min)
{
    bool flag = true;
    int opc = 0;
    while (flag)
    {
        string aux;
        Console.WriteLine("Ingrese una Opcion : ");
        aux = Console.ReadLine();
        if (int.TryParse(aux, out opc) && opc <= max && opc >= min)
        {
            flag = false;
        }
        else
        {
            Console.WriteLine("No ingresó un numero correcto!");
            flag = true;
        }
    }
    return opc;
}