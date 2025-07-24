# QuickSort em C#

## O que é QuickSort?

O **QuickSort** é um algoritmo de ordenação do tipo **"dividir e conquistar"**.  
Ele seleciona um elemento chamado **pivô** e reorganiza os elementos do array de forma que:

- Os elementos **menores ou iguais ao pivô** ficam à esquerda;
- Os elementos **maiores que o pivô** ficam à direita.

Esse processo é aplicado **recursivamente** às sublistas resultantes.

---

## Como funciona o QuickSort?

### Etapas principais:

1. Escolher um **pivô** (geralmente o último elemento do subarray)
2. **Particionar** o array com base nesse pivô
3. Aplicar o **QuickSort** recursivamente nas duas partes

---

## Função de Particionamento

A função `Particionar` reorganiza os elementos do array, colocando:

- Os valores **menores ou iguais ao pivô** à esquerda;
- Os valores **maiores que o pivô** à direita.

No final, o **pivô é colocado na posição correta**.

---

## 🧪 Exemplo: `[5, 2, 3, 1]`

### Passo a passo:

1. **Pivô**: 1 → reorganiza: `[1, 2, 3, 5]`  
2. Subarray à esquerda: vazio (nada a fazer)  
3. Subarray à direita: `[2, 3, 5]`  
   - Pivô: 5 → já ordenado  
   - Subarray `[2, 3]`: pivô = 3 → também já ordenado

**Resultado final:** `[1, 2, 3, 5]`

---

## ⏱️ Complexidade

| Caso        | Tempo      | Explicação                                |
|-------------|------------|--------------------------------------------|
| Melhor      | O(n log n) | Quando o pivô divide o array de forma equilibrada |
| Médio       | O(n log n) | Em geral, para entradas aleatórias        |
| Pior        | O(n²)      | Quando o pivô é sempre o maior ou menor   |

- Complexidade de **espaço**: O(log n) (pilha de recursão)
- É **in-place** (não usa arrays auxiliares)

---

## Conclusão

O QuickSort é um dos algoritmos de ordenação mais eficientes na prática, combinando **velocidade**, **uso de memória eficiente** e **elegância** no uso da recursão.
