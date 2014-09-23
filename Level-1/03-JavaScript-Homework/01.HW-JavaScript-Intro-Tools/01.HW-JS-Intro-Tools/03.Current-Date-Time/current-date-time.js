var datetime = new Date();
var hours = datetime.getHours();
var minutes = datetime.getMinutes();

if (minutes < 10) {
    console.log(hours + ":" + "0" + minutes);
}else {
    console.log(hours + ":" + minutes);
}