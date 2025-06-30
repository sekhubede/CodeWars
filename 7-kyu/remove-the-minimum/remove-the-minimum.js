function removeSmallest(numbers) {
  if (numbers.length === 0) return [];
​
  const smallestValue = Math.min(...numbers);
  const indexOfSmallest = numbers.indexOf(smallestValue);
​
  const newArray = [...numbers];
  newArray.splice(indexOfSmallest, 1);
  return newArray;
}