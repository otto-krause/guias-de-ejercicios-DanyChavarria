namespace E4
{
    public class Gatito
    {
        string nombre;
        bool vacunas;
        int energia;
        public Gatito(string nombre , bool vacunas , int energia)
        {
            this.nombre = nombre;
            this.vacunas = vacunas;
            this.energia = energia;

        }
        public bool estaSaludable()
        {
            return vacunas && energia > 30;
        }

        public string Nombres()
        {
            return nombre;
        }
        public bool estaVacunado()
        {
            return vacunas;
        }
        public int Comer()
        {
            return energia += 50;

        }
        public int Jugar( int minutos )
        {

            return energia -= 2 * minutos;
        }
    }
}