// write the function isAnagram
var isAnagram = function(test, original) {
  return (
    test.length === original.length &&
    test.toLowerCase().split("").sort().join("") ===
      original.toLowerCase().split("").sort().join("")
  );
};
​