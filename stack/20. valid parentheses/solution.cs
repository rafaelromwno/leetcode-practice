public class Solution {
    public bool IsValid(string s) {

        Dictionary<char,char> symbols = new Dictionary<char,char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (symbols.ContainsKey(c)) // c é um simbolo de fechamento?
            {
                if (stack.Count != 0 && stack.Peek() == symbols[c]) // se a pilha não estiver vazia E o último elemento da pilha for o fechamento correspondente
                    stack.Pop();
                else
                    return false;
            }
            else
                stack.Push(c);
        }

        // se a pilha estiver vazia, todos os símbolos foram fechados corretamente
        return stack.Count == 0;
    }
}