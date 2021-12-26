# Operações LINQ
O Language-Integrated Query (LINQ) é uma maneira de você utilizar uma sintaxe de consulta padronizada para coleções de objetos.

int[] numbers = { 5, 10, 8, 3, 6, 12 };

// Query syntax:
IEnumerable<int> numQuery =
        from num in numbers
        where num % 2 == 0
        orderby num
        select num;

// Method syntax
IEnumerable<int> numQuery2 = numbers.Where(num => num % 2 == 0).Orderby(n => n);

## Ordem dos estudos
* Obtendo e ordenando valores com LINQ
* Valores mínimo, máximo e médio com LINQ
* Sum e Distinct