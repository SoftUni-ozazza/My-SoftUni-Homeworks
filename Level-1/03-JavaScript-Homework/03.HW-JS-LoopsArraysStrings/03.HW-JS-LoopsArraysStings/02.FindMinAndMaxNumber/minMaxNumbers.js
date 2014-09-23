function findMinAndMax(value) {
    var numbersArr = value;

    function intOrder(a, b) {
        return a > b;
    }

    numbersArr.sort(intOrder);

    console.log('Min -> ' + numbersArr[0]);
    console.log('Max -> ' + numbersArr[numbersArr.length - 1]);    
}

findMinAndMax([1, 2, 1, 15, 20, 5, 7, 31]);
findMinAndMax([2, 2, 2, 2, 2]);
findMinAndMax([500, 1, -23, 0, -300, 28, 35, 12]);