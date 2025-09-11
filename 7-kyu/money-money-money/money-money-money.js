function calculateYears(principal, interest, tax, desired) {
    // your code
    let years = 0;
  
    while (principal < desired)
    {
      principal += principal * interest * (1 - tax);
      years++;
    }
  
    return years;
}