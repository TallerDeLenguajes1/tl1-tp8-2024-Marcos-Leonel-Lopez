namespace Tareas
{
    public class Tarea
    {
        private int tareaId = 0;
        private string descripcion;
        private int duracion;

        public Tarea(string descripcion, int duracion)
        {
            this.tareaId = ++tareaId;
            this.descripcion = descripcion;
            this.duracion = duracion;
        }

        public int TareaId { get => tareaId;}
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        public void mostrarTarea(){
            Console.WriteLine("===============");
            Console.WriteLine($"TareaId: {tareaId} \n Descripcion: {descripcion} \n Duracion: {duracion}");
            Console.WriteLine("===============");
        }
    }
}
