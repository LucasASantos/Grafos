using System;

public interface IGrafo
{
    void Grafo();
    int Ordem();
    bool InserirVertice(int vertice);
    bool RemoverVertice(int vertice);
    bool InserirAresta(int v1, int v2);
    bool RemoverAresta(int v1, int v2);
    int Grau(int vertice);
    bool Completo();
    bool Regular();
    void SequenciaGraus();
    void VerticesAdjacentes(int vertice);
    bool Isolado(int vertice);
    bool Impar(int vertice);
    bool Par(int vertice);
    bool Adjacentes(int v1, int v2);
}
