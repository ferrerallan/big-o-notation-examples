/* O(1) - CONSTANT regardless of the size of the dataset */
void Constant( List<string> inputList )
{
    // Printing just the lenght of the list
    Console.WriteLine( inputList.Count );

    /* Explanation: regardless of the number of elements, the routine will always execute 1 instruction, 
       with the same cost, considering that the 'Count' method has a constant cost
    */
}

/* O(n) - LINEAR time complexity */
void Linear( List<string> inputList )
{
    // Printing all elements in array
    inputList.ForEach(el=>{
        Console.WriteLine( el );    
    });    

    /* Explanation: as the number of array elements grows, the number of instructions 
       grows proportionally and linearly
    */
}

/* O(n^2) - QUADRATIC time complexity */
void Quatratic( List<string> inputList, List<string> inputList2 )
{
    // Printing all elements in array
    inputList.ForEach(el=>{
        inputList2.ForEach(el2=>{
            Console.WriteLine( el + " " + el2 );    
        });    
    });    

    /* Explanation: increases in proportion to the number of array elements, 
       and increases in proportion to the number of array elements squared
    */
}

/* O(log n) - LOGARITHMIC time complexity */
void Logarithmic( List<string> inputList )
{
    // Printing all elements in array
    inputList.Where(el=> el.Contains("a")).ToList().ForEach(el=>{
        Console.WriteLine( el );    
    });

    /* Explanation: increases by a constant. If n doubles, the time to perform
       increases by a constant, smaller than n amount
    */
}

/* O(n!) - FACTORIAL time complexity */
void Factorial(int targetNumber)
{
    var result = Fatorial_Function(targetNumber);
    Console.WriteLine(result);

    /* Explanation: increases in proportion of all numbers included
    */
}

double Fatorial_Function(double numero)
{
    if (numero == 1)
        return 1;
    else
        return numero * Fatorial_Function(numero - 1);
}
