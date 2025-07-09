function minMax(arr){
  return arr.reduce(
  ([min, max], currentValue) => [
    currentValue < min ? currentValue : min,
    currentValue > max ? currentValue : max
  ], [arr[0], arr[0]]);
}