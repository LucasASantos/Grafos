using Grafo.Interfaces;

namespace Grafo.Classes.GrafoMA
{
    public class GrafoMA : IGrafo
    {
        private int[,] MA;
        private int qtVertices;

        public GrafoMA(int qtVertices)
        {
            this.qtVertices = qtVertices;
            MA = new int[qtVertices, qtVertices];  
            for (int i = 0; i<qtVertices; i++)
            {
                for(int j = 0; j < qtVertices; j++)
                {
                    MA[i, j] = 0;
                }
            }
        }

        public int Ordem()
        {
            return qtVertices;
        }

        public bool InserirAresta(int v1, int v2)
        {
            if (v1 < qtVertices && (v2 < qtVertices))
            {
                MA[v1, v2] = 1;
                MA[v2, v1] = 1;
                return true;
            }
            else return false;
        }

        public bool RemoverAresta(int v1, int v2)
        {
            if (v1 < qtVertices && (v2 < qtVertices))
            {
                MA[v1, v2] = 0;
                MA[v2, v1] = 0;
                return true;
            }
            else return false;
        }

        public int Grau(int vertice)
        {
            throw new System.NotImplementedException();
        }

        public bool Completo()
        {
            throw new System.NotImplementedException();
        }

        public bool Regular()
        {
            throw new System.NotImplementedException();
        }

        public void SequenciaGraus()
        {
            throw new System.NotImplementedException();
        }

        public void VerticesAdjacentes(int vertice)
        {
            throw new System.NotImplementedException();
        }

        public bool Isolado(int vertice)
        {
            throw new System.NotImplementedException();
        }

        public bool Impar(int vertice)
        {
            throw new System.NotImplementedException();
        }

        public bool Par(int vertice)
        {
            throw new System.NotImplementedException();
        }

        public bool Adjacentes(int v1, int v2)
        {
            throw new System.NotImplementedException();
        }
        public void ShowMA()
        {
            throw new System.NotImplementedException();
        }
        public void ShowLA()
        {
            throw new System.NotImplementedException();
        }
    }
}