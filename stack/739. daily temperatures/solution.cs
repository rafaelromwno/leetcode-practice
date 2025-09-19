public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        //temperatures = [75,71,69,72,76]
        int size = temperatures.Length;
        int[] ans = new int[temperatures.Length];
        Stack<int> indexStack = new Stack<int>();

        for(int i = 0; i < size; i++)
        {
            while (indexStack.Count != 0 && temperatures[i] > temperatures[indexStack.Peek()])
            {
                // retirar o topo da pilha
                int indexTop = indexStack.Pop();
                // calcular a diferenca de dias
                ans[indexTop] = i - indexTop;

            }            
            
            indexStack.Push(i);
        }

        return ans;
    }
}