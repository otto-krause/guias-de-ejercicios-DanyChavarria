namespace E5
{
    public class Triangulo
    {
        int ladoA = 0;
        int ladoB = 0;
        int ladoC = 0;

        public Triangulo( int ladoA , int ladoB , int ladoC)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC ;
        }

        public bool EsEscaleno( int ladoA , int ladoB , int ladoC)
        {
            return ladoA != ladoB && ladoA != ladoC && ladoC != ladoB ;
        }
        
        public bool EsIsosceles( int ladoA , int ladoB , int ladoC)
        {
            return ladoA == ladoB || ladoA == ladoC || ladoB == ladoC;
        }

        public bool EsEquilatero( int ladoA , int ladoB , int ladoC)
        {
            return ladoA == ladoB && ladoB == ladoC;
        }
        public bool EsTrianguloRectangulo(int ladoA, int ladoB, int ladoC)
        {


            return ladoC * ladoC == ladoA * ladoA + ladoB * ladoB;
        }


    }
}