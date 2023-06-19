namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX() { return this.x; }
        public int GetY() { return this.y;}
    }


    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;

            int XVertice1 = vertice1.GetX();
            int YVertice1 = vertice1.GetY();
            int Xvertice3 = vertice3.GetX();
            int YVertice3 = vertice3.GetY();

            int ancho = Math.Abs(XVertice1 - Xvertice3);
            int alto = Math.Abs(YVertice1 - YVertice3);
        }

        public float Area()
        {

        }

        public float Perimetro() 
        {

        }

        public float GetArea(){ return this.area; }
        public float GetPerimetro() { return this.perimetro;  }
    }
}