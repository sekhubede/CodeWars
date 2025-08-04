function getDivisorsCnt(n){
  let count = 0;
  const sqrt = Math.floor(Math.sqrt(n));
  
  for (let i = 1; i <= sqrt; i++) {
    if (n % i === 0) {
     count += (i === n / i) ? 1 : 2; 
    }
  }
  
  return count;
  
}