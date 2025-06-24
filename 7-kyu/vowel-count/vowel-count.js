function getCount(str) {
  let vowelsCount = 0;
  const vowels = 'aeiou';
  
  for (let i = 0; i < str.length; i++) {
    if(vowels.includes(str[i].toLowerCase())) {
      vowelsCount++;
    }
  }
  
  return vowelsCount;
}