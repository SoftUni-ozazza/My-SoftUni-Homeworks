<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <link href="Styles/01.rootSum.css" rel="stylesheet"/>
    <title>Annual Expenses</title>
</head>
<body>
<section>
    <article>
        <form method="post">
            <label for="start">Start Index:<input type="text" name="start" /></label>
            <label for="end">End Index:<input type="text" name="end" /></label>
            <input type="submit" value="Submit" />
        </form>
    </article>
<?php
if(isset($_POST['start']) && isset($_POST['end'])){
    echo "<article>";
    $start = htmlentities($_POST['start']);
    $end = htmlentities($_POST['end']);

    for($i = $start; $i <= $end; $i++){
        $isPrime = (($i == 2) || ($i == 3) ||
                    ($i == 5) || ($i == 7)) ||
                   (($i % 2 > 0) && ($i % 3 > 0) &&
                    ($i % 5 > 0) && ($i % 7 > 0));
        if($i > -1){
            if($i == 0 || $i== 1 || !$isPrime){
                //is not a prime
                echo ("{$i}, ");
            }elseif($isPrime){
                echo ("<strong>{$i}</strong>, ");
            }
        }else{
            echo("Primes are bigger than -1!");
        }
    }
    echo "</article>";
}
?>

</section>
</body>
</html>