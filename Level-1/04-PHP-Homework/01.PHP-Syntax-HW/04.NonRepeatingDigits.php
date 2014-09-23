<?php
$n = 247;
if ($n > 101) {
    for ($i = 102; $i < 1000; $i++) {
        $ones = $i % 10;
        $tens = ($i / 10) % 10;
        $hundreds = ($i / 100) % 10;
        if (($ones != $tens) && ($tens != $hundreds)) {
            if ($i > $n) {
                return;
            } else {
                echo($i . " ");
            }
        }
    }
} else {
    echo("no");
}
?>