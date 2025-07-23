## 📌 O que é o Bubble Sort?

O **Bubble Sort** é um algoritmo de ordenação simples que compara pares adjacentes de elementos e os troca de posição se estiverem fora de ordem. Esse processo é repetido até que a lista esteja completamente ordenada.

Apesar de sua simplicidade, o Bubble Sort **não é o mais eficiente** para grandes volumes de dados, sendo mais utilizado para fins didáticos.

---

## 🔢 Como funciona?

Durante cada passagem pela lista:

1. O algoritmo percorre o array do início ao fim.
2. Em cada iteração, compara dois elementos adjacentes.
3. Se o elemento da esquerda for maior que o da direita, os dois são trocados.
4. Ao final da primeira passagem, o maior elemento estará na última posição.
5. O processo se repete ignorando a última posição já ordenada.

Esse comportamento faz com que os maiores valores "borbulhem" para o final do array — daí o nome **Bubble Sort**.

---

## 🧠 Complexidade

| Caso           | Complexidade |
|----------------|--------------|
| Melhor caso    | O(n)         |
| Caso médio     | O(n²)        |
| Pior caso      | O(n²)        |
| Espaço extra   | O(1)         |

> 🔍 Melhor caso: quando o array já está ordenado (pode ser otimizado com um `flag` de troca).  
> 🚫 Pior caso: array em ordem inversa.
