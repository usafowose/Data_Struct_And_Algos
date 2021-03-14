// Complete the solution so that it splits the string into pairs of two characters. If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').

// Examples:

// SplitString.Solution("abc"); // should return ["ab", "c_"]
// SplitString.Solution("abcdef"); // should return ["ab", "cd", "ef"]


const SplitString = (str = '') => {
    let splitByTwo =[]; 

    for (i=0; i<str.length; i+=2) {
        let [first, second, ...rest] = [...str].splice(i, str.length - i); 
        splitByTwo = str[i+1] ? [...splitByTwo, [first.concat(second)]] : splitByTwo = [...splitByTwo, [first.concat('_')]]; 
    }; 

    return splitByTwo.reduce((acc, cv) =>  [...acc, cv[0]], []);
}; 

console.log(SplitString("Hello World"));