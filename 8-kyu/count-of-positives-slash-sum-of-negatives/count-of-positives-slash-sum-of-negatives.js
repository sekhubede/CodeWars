function countPositivesSumNegatives(input) {
  
  if (!Array.isArray(input) || input.length === 0) return [];
  
  let countOfPositives = 0;
  let sumOfNegatives = 0;
  
  for (const num of input) {
    if (num > 0) countOfPositives++;
    else if (num < 0) sumOfNegatives += num;
  }
​
  return [countOfPositives, sumOfNegatives];
  
}