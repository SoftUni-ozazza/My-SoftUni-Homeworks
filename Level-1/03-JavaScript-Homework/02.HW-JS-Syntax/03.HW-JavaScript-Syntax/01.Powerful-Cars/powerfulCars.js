function convertKWtoHP(value) {
    var hp = Math.round(value / 0.745699872 * 100) / 100;
    return hp;
}
console.log(convertKWtoHP(75));
console.log(convertKWtoHP(150));
console.log(convertKWtoHP(1000));
