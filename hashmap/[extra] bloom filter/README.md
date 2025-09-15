
# Filtro de Bloom (Bloom Filter)

## O que é o Filtro de Bloom?

O **Filtro de Bloom** é uma estrutura de dados probabilística usada para testar se um elemento pertence a um conjunto. Ele pode determinar rapidamente se um item **não está** no conjunto, mas **não pode garantir 100% de certeza** quando diz que um item **está** no conjunto, podendo retornar **falsos positivos**.

### Características principais:

-   **Falsos positivos**: O Filtro de Bloom pode indicar que um elemento está no conjunto quando ele não está. Contudo, ele **nunca** dará um **falso negativo**. Ou seja, se ele indicar que o item não está presente, ele com certeza não está.    
-   **Espaço eficiente**: A estrutura de dados do Filtro de Bloom usa uma quantidade de memória muito pequena em comparação com outras estruturas de dados, como tabelas de hash.    
-   **Rápido**: As operações de inserção e verificação de pertencimento são muito rápidas.
   

## Como funciona?

1.  **Funções Hash**: O Filtro de Bloom utiliza várias funções hash para mapear os elementos em diferentes posições de um vetor de bits.    
2.  **Inserção**: Quando você insere um elemento, o Filtro de Bloom calcula várias posições no vetor de bits (de acordo com o número de funções hash) e marca essas posições como `1`.    
3.  **Verificação**: Para verificar se um elemento está presente, o Filtro de Bloom calcula as mesmas posições no vetor e verifica se todas estão marcadas como `1`. Se qualquer uma das posições for `0`, o item definitivamente **não está** no conjunto. Se todas as posições forem `1`, o item **provavelmente está**, mas com uma pequena chance de falso positivo.

## Estrutura de Dados

O Filtro de Bloom é composto por:

-   **Vetor de bits**: Representa o conjunto de elementos, onde cada posição pode ser `0` (não inserido) ou `1` (inserido).    
-   **Funções Hash**: Funções que determinam as posições a serem marcadas no vetor de bits. Quanto mais funções hash, menor a chance de falsos positivos.
 

## Vantagens

-   **Eficiência de memória**: A estrutura é altamente eficiente em termos de espaço, mesmo para conjuntos grandes. 
-   **Velocidade**: A verificação de existência e a inserção de elementos são extremamente rápidas.
-   **Escalabilidade**: Pode ser usado para grandes volumes de dados, como verificações de pertencimento em caches e sistemas distribuídos.
    

## Limitações

-   **Falsos positivos**: O Filtro de Bloom pode indicar incorretamente que um item está presente, embora não esteja.
-   **Não pode remover itens**: Uma vez que um item é inserido no Filtro de Bloom, ele não pode ser removido. Isso ocorre porque várias entradas podem compartilhar a mesma posição de bit, dificultando a remoção.

## Conclusão
O **Filtro de Bloom** é uma estrutura de dados eficiente para armazenar e consultar grandes conjuntos de dados com um pequeno custo de memória. No entanto, ele tem a limitação de produzir falsos positivos, por isso é importante entender seu funcionamento antes de utilizá-lo em aplicações críticas.