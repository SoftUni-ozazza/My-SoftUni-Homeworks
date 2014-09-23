function printNumbers(n) {
    var resultArr = [];
    
    if (n > 0){
        for (var i = 1; i <= n; i += 1) {
            if (i % 4 != 0 && i % 5 != 0) {
                resultArr.push(i);
            }
        }
    } else {
        resultArr.push('no');
    }
console.log(resultArr);
};

printNumbers(20);
printNumbers(-5);
printNumbers(13);