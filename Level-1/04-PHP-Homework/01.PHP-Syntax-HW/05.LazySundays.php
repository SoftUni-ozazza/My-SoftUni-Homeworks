<?php
//$today = date('F jS, l, Y');
//$month = date('F');
//$year = date('Y');
//echo $month;

function getSundaysInMonth($year, $month){
    return new DatePeriod(
        new DateTime("first sunday of $year-$month"),
        DateInterval::createFromDateString('next sunday'),
        new DateTime("last day of $year-$month")
    );
}

foreach (getSundaysInMonth(2014, 8) as $sunday){
    echo $sunday->format("jS F, Y") . "<br>";
}
?>