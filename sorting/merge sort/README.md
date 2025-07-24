# Merge Sort em C#

## O que é Merge Sort?

O **Merge Sort** (ordenamento por mistura) é um algoritmo de ordenação baseado no paradigma **dividir e conquistar**:

1. Divide o array em duas metades até restarem subarrays de 1 elemento.
2. Conquista: junta (merge) essas metades de forma **ordenada**.
3. O resultado final é um array completamente ordenado.

---

## Como funciona?

### Etapas principais:

1. Dividir o array em duas partes recursivamente
2. Ordenar cada metade
3. Mesclar as duas partes de volta em ordem crescente

---

## Função de Mesclagem (`Merge`)

A função `Mesclar` compara os elementos de dois subarrays ordenados e cria um novo subarray com os elementos organizados em ordem.

---

## 🧪 Exemplo de entrada

```
Entrada: [5, 2, 4, 7, 1, 3, 6]
```

Divisões e junções:

- Divide até: [5], [2], [4], [7], [1], [3], [6]
- Mescla: [2,5], [4,7], [1,3,6]
- Mescla final: [1,2,3,4,5,6,7]

---

## ⏱️ Complexidade

| Caso        | Complexidade | Justificativa                         |
|-------------|--------------|----------------------------------------|
| Melhor      | O(n log n)   | Sempre divide igualmente               |
| Médio       | O(n log n)   | Independente da ordem dos dados        |
| Pior        | O(n log n)   | Mesmo no pior caso                     |

- Complexidade de **espaço**: O(n) (usa arrays auxiliares)
- É **estável** (mantém a ordem de elementos iguais)

---

## Conclusão

O Merge Sort é um algoritmo estável, eficiente e previsível, ótimo para grandes volumes de dados que podem ser processados em paralelo ou em streams.
