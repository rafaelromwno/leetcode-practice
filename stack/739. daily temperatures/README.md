## **Solução eficiente usando **Stack** (pilha)**

-   A ideia é percorrer as temperaturas **da esquerda para a direita** (ou da direita para a esquerda, depende da abordagem).
    
-   Use uma pilha para armazenar **índices de dias que ainda não encontraram uma temperatura maior**.
    
-   Para cada dia:
    
    -   Enquanto a pilha não estiver vazia e a temperatura atual for maior que a do topo da pilha:
        
        -   Retire o topo da pilha, calcule a diferença de dias e coloque no resultado.
            
    -   Coloque o índice atual na pilha.

## Por que a complexidade é **O(n)**

1.  **Loop `for` principal:** percorre cada índice do array uma vez → O(n).    
2.  **Loop `while` interno:**    
    -   À primeira vista, poderia parecer que o `while` adiciona outro loop e torna O(n²).        
    -   Mas **cada índice é empurrado (`Push`) na pilha exatamente 1 vez** e **retirado (`Pop`) da pilha exatamente 1 vez**.        
    -   Ou seja, o total de operações dentro do `while` ao longo de toda execução do algoritmo **não ultrapassa n**.        
3.  **Conclusão:**
    
    -   `for` → n iterações        
    -   `while` → no máximo n pop ao longo de todas as iterações        
    -   Soma → O(n + n) = O(n)
        
**Analogia:** cada índice “entra na fila” e “sai da fila” uma única vez, então mesmo que o `while` apareça dentro do `for`, não há repetições desnecessárias.