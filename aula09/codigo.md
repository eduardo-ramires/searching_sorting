using System.ComponentModel;

&#x20;

Métodos de Ordenação

&#x20;   - Ordenar é um recurso para busca ou pesquisa otimizada

&#x20;   - Categorias de algoritmos de ordenação

&#x20;       - Simplicidade versus complicação (quantidade do código)

&#x20;           simples:

&#x20;               - bolha

&#x20;               - seleção

&#x20;               - inserção

&#x20;               - agitação

&#x20;               - pente

&#x20;           complicado:

&#x20;               - merge

&#x20;               - quick

&#x20;       - Estabilidade versus instalibilidade

&#x20;           estável:

&#x20;               - bolha

&#x20;               - agitação

&#x20;               - inserção

&#x20;               - merge

&#x20;           instáveis:

&#x20;               - seleção

&#x20;               - pente (por causa da distância ou gap ou h)

&#x20;               - quick (por causa da distância)

&#x20;       - Complexidade: alta (muito esforço) versus baixa (pouco esforço)

&#x20;           - como se calcula esforço ou a complexidade em ordenação (QUANTIDADE de comparações + QUANTIDADE de trocas)

&#x20;           - funções de complexidade:

&#x20;               - O(n!) - fatorial

&#x20;               - O(n^k) - polinomial

&#x20;               - O(n^2) - exponencial

&#x20;               - O(n . log n) - linear vezes logaritmica

&#x20;               - O(n) - linear

&#x20;               - O(log n) - logartimica (todos os algoritmos baseados na filosofia de ÁRVORE)

&#x20;       - Peculiaridades

&#x20;           - bolha - agitação - inserção: se a estrutura já estiver ordenada, há baixo esforço - O(n)

&#x20;           - pente: com a entrada da distância, o pente fica muito melhor em termos de complexidade. O pente trabalha com distância. Enquanto a distância for maior que 1, o método é instável. Quando a distância fica 1, o método se transforma no bolha e fica estável.

&#x20;           - seleção: se um vetor estiver ordenado, o método continua fazendo o mesmo esforço de ordenação de um vetor desordenado

&#x20;           - merge e o quick: são baseados em técnicas recursivas. Para cada método, há 2 submétodos

&#x20;               - merge: chamada recursiva e o submétodo intercalação (ordenação se dá na volta do empilhamento)

&#x20;                   - Java o utiliza

&#x20;               - quick: chamada recursiva e o submétodo posicionar (posicionar o pivo no seu lugar certo, no empilhamento)

&#x20;                   - C# o utiliza

&#x20;

&#x20;   - Outros métodos de ordenação

&#x20;       - Shell sort: é uma evolução do inserção. Usa a mesma filosofia de melhora do pente com o bolha. Ou seja, aplica uso de distância (gap). Como o pente, o Shell, ao trabalhar com distância, é instável. Mas quando a distância fica 1, ele se transforma no inserção e passa a ser estável.

&#x20;

&#x20;       - Heap sort: baseado na teoria de árvore, porém, dentro de uma lista

&#x20;

&#x20;       - Bucket sort: método de ordenação pelo dígito do número

&#x20;

&#x20;       - Radix sort: melhoria do Bucket

&#x20;

&#x20;

&#x20;          

&#x20;

void bolha(List<int> lista)

{

&#x20;   int tmp;

&#x20;   bool houveTroca;

&#x20;   int dist = lista.Count();

&#x20;   do

&#x20;   {

&#x20;       dist = (int)(dist / 1.3);

&#x20;       if (dist < 1)

&#x20;       {

&#x20;           dist = 1;

&#x20;       }

&#x20;       houveTroca = false;

&#x20;       for (int i = 0; i+dist < lista.Count() - 1; i++)

&#x20;       {

&#x20;           if (lista\[i] > lista\[i + dist])

&#x20;           {

&#x20;               houveTroca = true;

&#x20;               tmp = lista\[i];

&#x20;               lista\[i] = lista\[i+dist];

&#x20;               lista\[i+dist] = tmp;

&#x20;           }

&#x20;       }

&#x20;   } while (dist > 1 || houveTroca);

}

